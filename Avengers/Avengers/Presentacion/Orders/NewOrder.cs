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

namespace Avengers.Presentacion.Orders
{
   
    public partial class NewOrder : Form 
    {
        private DtoCustomer dtoCustomer;
        private DtoProduct dtoProduct;
        private float total;
        private float totald;
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

            Order o = new Order();
            //String id = o.getGestor().getDataV2("IDCUSTOMER", "CUSTOMERS",
            //    "WHERE UPPER(NAME) ='" + txtCustomer.Text.ToUpper() + "'");
            //Console.WriteLine(txtCustomer.Text.ToUpper());

            //if(dataGridView1.Rows[0].Cells[1].Value.ToString().Length==0)
            if (!String.IsNullOrEmpty(txtProduct.Text) )
            {
                dataGridView1.Rows.Add(txtProduct.Text, nudAmount.Value.ToString(), txtPrice.Text);
                if (!String.IsNullOrEmpty(txtDiscount.Text))
                {
                    this.total = this.total + (float.Parse(txtPrice.Text) * float.Parse(nudAmount.Value.ToString()));
                    float descuento = this.total * ((float.Parse(txtDiscount.Text)) / 100);
                    this.total = this.total - descuento;                    
                    tbxTotal.Text = Convert.ToString(this.total);
                    
                }
                else {
                    this.total = this.total + (float.Parse(txtPrice.Text) * int.Parse(nudAmount.Value.ToString()));                    
                    tbxTotal.Text = Convert.ToString(this.total);
                }
            }
            else
            {
                MessageBox.Show("You must select one Product");
            }
                


            //dataGridView1.Rows.Add(0, dataGridView1.Rows[0].Cells[1], txtProduct.Text, nudAmount.Value.ToString(), txtPrice.Text);

            
            
             //String sql="Insert into ordersproducts values(null,"
            //if(Dominio.Gestores.GestorCustomers.existCustomer(this.dtoCustomer.Idcustomer) && Dominio.Gestores.GestorProducts.existProduct(this.dtoProduct.Name){
            //    Dominio.Gestores.GestorOrdersProduct.insertOrderProduct()
            //}
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
            //String id = o.getGestor().getDataV2("IDCUSTOMER", "CUSTOMERS", "WHERE UPPER(NAME) ='" + txtCustomer.Text.ToUpper() + "'");

            if(check())
            {
                String id = dtoCustomer.Idcustomer;
                String sql = "Insert into orders values (null,'" + id + "', 1, SYSDATE, '" + cmbPay.SelectedValue + "', " + int.Parse(tbxTotal.Text) + ", DEFAULT,0)";
                o.getGestor().setData(sql);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("error");
            }
            
            //String id2 = o.getGestor().getDataV2("IDPAYMENTMETHOD", "PAYMENTMETHODS", "WHERE UPPER(PAYMENTMETHOD) ='" + .Text.ToUpper() + "'");
           
        }
    }
}
