using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avengers.Dominio;
using Avengers.Presentacion.Products;
using Oracle.DataAccess.Client;

namespace Avengers.Presentacion.Orders
{
   
    public partial class NewOrder : Form 
    {
        private DtoCustomer dtoCustomer;
        private DtoProduct dtoProduct;
        private float t;
        public NewOrder()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            iniTable();
            initPay(" Where deleted=0");
            cmbPay.SelectedIndex = -1;
        }
   

        private void btnFindCust_Click(object sender, EventArgs e)
        {
            ViewCustomer vc = new ViewCustomer(this);
         
            vc.ShowDialog(this);
        }


        public void updateCustomer(DtoCustomer customer)
        {
            Console.WriteLine(customer.Name+" "+ customer.Surname);
            this.dtoCustomer = customer;
            txtCustomer.Text = customer.Name + " " + customer.Surname;

        }
        public void updateProduct(DtoProduct product)
        {
            Console.WriteLine(product.Name);
            this.dtoProduct = product;
            txtProduct.Text = product.Name;
            txtPrice.Text = product.Price;

        }
        public void initPay(String cond)
        {
            Order o = new Order();
            o.getGestor().readInDB("IDPAYMENTMETHOD, PAYMENTMETHOD ", "PAYMENTMETHODS", cond);
            DataTable torder = o.getGestor().getOrders();

            cmbPay.DataSource = torder;
            cmbPay.DisplayMember = "PAYMENTMETHOD";
            cmbPay.ValueMember = "IDPAYMENTMETHOD";

        }

        private void btnFindProd_Click(object sender, EventArgs e)
        {
            ViewProduct vp = new ViewProduct(this);
            vp.ShowDialog(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.t = 0; 
            Order o = new Order();

            if (!String.IsNullOrEmpty(txtProduct.Text) )
            {
                dataGridView1.Rows.Add(txtProduct.Text, nudAmount.Value.ToString(), txtPrice.Text);
                if (!String.IsNullOrEmpty(txtDiscount.Text))
                {
                    // -1 esta puesto por la fila en blanco
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        this.t = this.t + (float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) * float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));                        
                    }
                    this.t = this.t - (this.t * ((float.Parse(txtDiscount.Text)) / 100));
                    tbxTotal.Text = Convert.ToString(t);

                }
                else {
                    if (dataGridView1.RowCount > 1)
                    {
                        
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            this.t = this.t + (float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) * float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                        }
                        tbxTotal.Text = Convert.ToString(t);
                    }                      
                }
            }
            else
            {
                MessageBox.Show("You must select one Product");
            }
    
        }

        private void iniTable()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("PRODUCT", "PRODUCT");
            dataGridView1.Columns.Add("AMOUNT", "AMOUNT");
            dataGridView1.Columns.Add("PRICESALE", "PRICESALE");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private bool check()
        {
            return !String.IsNullOrEmpty(txtCustomer.Text) && (cmbPay.SelectedIndex != -1);

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Order o = new Order();

            if(check())
            {
                String id = dtoCustomer.Idcustomer;
                //Sql para insertar order al hacer click en OK -- modificar el valor numero 3 que hace ref a user
                String sql = "Insert into orders values (null,'" + id + "', 1, SYSDATE, '" + cmbPay.SelectedValue + "', '" + tbxTotal.Text + "', DEFAULT,0)";
                o.getGestor().setData(sql);
                //Console.WriteLine(sql);
                sql = "SELECT IDORDER FROM ORDERS WHERE TOTAL = '" + (tbxTotal.Text) + "'";
                String ido = o.getGestor().getUnString(sql);
                //Console.WriteLine("Traza-- ID ORDER  " + ido);
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    //String idp = o.getGestor().getDataV2("IDPRODUCT", "PRODUCTS", "WHERE UPPER(NAME) =" + dataGridView1.Rows[i].Cells[0].Value.ToString().ToUpper() + "'");
                    sql = "SELECT IDPRODUCT FROM PRODUCTS WHERE UPPER(NAME) = '" + dataGridView1.Rows[i].Cells[0].Value.ToString().ToUpper() + "'";
                    String idp = o.getGestor().getUnString(sql);
                    //Console.WriteLine("Traza-- ID PRODURC " + idp);

                    sql = "Insert into ordersproducts values (null, '" + ido + "', '" + idp + "', " + float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) + ", " + float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())+")";
                    o.getGestor().setData(sql);
                }


                this.Dispose();
            }
            else
            {
                MessageBox.Show("Select one customer and any paymentmethod");
            }               
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.t = 0;
            if(dataGridView1.RowCount > 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                if (!String.IsNullOrEmpty(txtDiscount.Text))
                {
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        this.t = this.t + (float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) * float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                    }
                    this.t = this.t - (this.t * ((float.Parse(txtDiscount.Text)) / 100));
                    tbxTotal.Text = Convert.ToString(t);

                }
                else
                {
                    if (dataGridView1.RowCount > 1)
                    {

                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            this.t = this.t + (float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) * float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                        }
                        tbxTotal.Text = Convert.ToString(t);
                    }
                }
            }
                
        }
    }
}
