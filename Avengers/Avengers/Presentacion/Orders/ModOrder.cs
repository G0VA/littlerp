using Avengers.Dominio;
using Avengers.Dominio.Gestores;
using Avengers.Presentacion.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avengers.Presentacion.Orders
{
    public partial class ModOrder : Form
    {
        //Atributos Orders
        public String idOrder;
        private String idcustomer;
        private String refuser;
        private String refpaymentmethod;
        private String total;
        private String prepaid;


        private User u;
        private String idioma;
       
        private DtoCustomer dtoCustomer;
        private DtoProduct dtoProduct;
        private float t;
        
        public ModOrder(User u, String idioma, String idOrder)
        {
            InitializeComponent();
            this.u = u;
            this.idioma = idioma;
            this.idOrder = idOrder;
            initTable();
            initPay(" Where deleted=0");
            initOrder();
        }

        private void initOrder()
        {
            Order o = new Order();
            o.getGestor().readInOrders("*", " Where idorder='" + this.idOrder + "'");

            DataTable torder = o.getGestor().getOrders();
            lblNumeroOrder.Text = "ORDER ID: " + this.idOrder;
            foreach (DataRow row in torder.Rows)
            {
                
                this.idcustomer = row["REFCUSTOMER"].ToString();
                this.refuser = row["REFUSER"].ToString();
                date.Text = row["DATETIME"].ToString();
                this.refpaymentmethod = row["REFPAYMENTMETHOD"].ToString();
                this.total = row["TOTAL"].ToString();
                this.prepaid = row["PREPAID"].ToString();

            }
           
            
            //Console.WriteLine(o.getGestor().getUnString("SELECT NAME||' '|| SURNAME FROM CUSTOMERS WHERE IDCUSTOMER = '" + this.idcustomer + "'"));
            txtCustomer.Text = o.getGestor().getUnString("SELECT NAME||' '|| SURNAME FROM CUSTOMERS WHERE IDCUSTOMER = '" + this.idcustomer + "'").ToString();
            cmbPay.SelectedValue = refpaymentmethod;
            txtTotal.Text = this.total;
            txtPrepaid.Text = this.prepaid;
            
        }

        private void initTable()
        {
            

            dgvModOrder.Columns.Clear();

            OrderProduct op = new OrderProduct();
            String columnas = " o.idorderproduct, o.reforder,o.refproduct, p.name, o.amount, o.pricesale ";
            String tablas = "  ordersproducts o inner join products p on refproduct=idproduct ";
            String condi = " where o.reforder= " + this.idOrder;
           // Console.WriteLine(columnas + tablas + condi);
            op.getGestor().readInDB(columnas, tablas, condi);


            DataTable torders = op.getGestor().getOrderProduct();
            dgvModOrder.Columns.Clear();

            if (this.idioma == "ESPAÑOL")
            {
                dgvModOrder.Columns.Add("IDORDERPRODUCT", "ID");
                dgvModOrder.Columns.Add("REFORDER", "REFORDER");
                dgvModOrder.Columns.Add("REFPRODUCT", "IDPRODUCTO");
                dgvModOrder.Columns.Add("NAME", "PRODUCTO");
                dgvModOrder.Columns.Add("AMOUNT", "CANTIDAD");
                dgvModOrder.Columns.Add("PRICESALE", "PRECIO DE VENTA");

            }
            else
            {
                dgvModOrder.Columns.Add("IDORDERPRODUCT", "ID");
                dgvModOrder.Columns.Add("REFORDER", "REFORDER");
                dgvModOrder.Columns.Add("REFPRODUCT", "IDPRODUCT");
                dgvModOrder.Columns.Add("NAME", "PRODUCT");
                dgvModOrder.Columns.Add("AMOUNT", "AMOUNT");
                dgvModOrder.Columns.Add("PRICESALE", "PRICESALE");

            }


            foreach (DataRow row in torders.Rows)
            {
                dgvModOrder.Rows.Add(row["IDORDERPRODUCT"], row["REFORDER"], row["REFPRODUCT"],row["NAME"], row["AMOUNT"], row["PRICESALE"]);
            }

            dgvModOrder.Columns["IDORDERPRODUCT"].Visible = false;
            dgvModOrder.Columns["REFORDER"].Visible = false;
            dgvModOrder.Columns["REFPRODUCT"].Visible = false;


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

        public void idioma_es()
        {
            this.lblCustomer.Text = Avengers.Recursos.Espanol.lblCustomer;
            this.lblAmount.Text = Avengers.Recursos.Espanol.lblAmount;
            this.lblDate.Text = Avengers.Recursos.Espanol.lblDate;
            this.lblPayMethod.Text = Avengers.Recursos.Espanol.lblPay;
            this.lblPricesale.Text = Avengers.Recursos.Espanol.lblPricesale;
            this.lblProduct.Text = Avengers.Recursos.Espanol.lblProduct;
            this.btnModify.Text = Avengers.Recursos.Espanol.btnModify;
            this.btnCancel.Text = Avengers.Recursos.Espanol.btnCancel;

        }
        public void idioma_en()
        {
            this.lblCustomer.Text = Avengers.Recursos.Ingles.lblCustomer;
            this.lblAmount.Text = Avengers.Recursos.Ingles.lblAmount;
            this.lblDate.Text = Avengers.Recursos.Ingles.lblDate;
            this.lblPayMethod.Text = Avengers.Recursos.Ingles.lblPay;
            this.lblPricesale.Text = Avengers.Recursos.Ingles.lblPricesale;
            this.lblProduct.Text = Avengers.Recursos.Ingles.lblProduct;
            this.btnModify.Text = Avengers.Recursos.Ingles.btnModify;
            this.btnCancel.Text = Avengers.Recursos.Ingles.btnCancel;
        }

        private void btnFindProd_Click(object sender, EventArgs e)
        {
            ViewProduct vp = new ViewProduct(this, idioma);
            vp.ShowDialog(this);
        }

        private void btnFindCust_Click(object sender, EventArgs e)
        {
            ViewCustomer vc = new ViewCustomer(this,this.idioma);
            vc.ShowDialog(this);
        }

        public void updateProduct(DtoProduct product)
        {
            // Console.WriteLine(product.Name);
            this.dtoProduct = product;
            txtProduct.Text = product.Name;
            txtPrice.Text = product.Price;

        }
        public void updateCustomer(DtoCustomer customer)
        {
            //Console.WriteLine(customer.Name+" "+ customer.Surname);
            this.dtoCustomer = customer;
            this.idcustomer = customer.Idcustomer;
            txtCustomer.Text = customer.Name + " " + customer.Surname;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.t = 0;
            int idx = dgvModOrder.CurrentRow.Index;
   
            if(MessageBox.Show("Do you want Delete this product?", "Delete orderProduct", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String sql = "Delete from ordersproducts where idorderproduct= " + dgvModOrder.Rows[idx].Cells[0].Value.ToString();
                
                float total = Convert.ToSingle(txtTotal.Text);
                t = Convert.ToSingle(dgvModOrder.Rows[idx].Cells[4].Value) * Convert.ToSingle(dgvModOrder.Rows[idx].Cells[5].Value);
                total = total - t;
                txtTotal.Text = total.ToString();
                String sqlUpdate = "Update orders set Total=" + txtTotal.Text + "where idorder=" + this.idOrder;
                GestorOrdersProduct.UpdateOrderProduct(sqlUpdate);
                GestorOrdersProduct.deleteOrderProduct(sql);
                
                dgvModOrder.Rows.RemoveAt(idx);
            }
           //restar cantidad del precio
          



        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.t = 0;

            if (!String.IsNullOrEmpty(txtProduct.Text))
            {
                Console.WriteLine(txtProduct.Text);
                dgvModOrder.Rows.Add(null, null, null, txtProduct.Text, nudAmount.Value.ToString(), txtPrice.Text);
                Console.WriteLine(txtPrice.Text);
              
                for (int i = 0; i < dgvModOrder.RowCount; i++)
                {
                    this.t = this.t + (float.Parse(dgvModOrder.Rows[i].Cells[4].Value.ToString()) * float.Parse(dgvModOrder.Rows[i].Cells[5].Value.ToString()));
                }
                txtTotal.Text = Convert.ToString(t);
             
            }
            else
            {
                if (this.idioma == "ESPAÑOL")
                {
                    MessageBox.Show("Debes seleccionar un producto");
                }
                else
                {
                    MessageBox.Show("You must select one Product");
                }

            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            Order o = new Order();



            //Sql para insertar order al hacer click en OK -- modificar el valor numero 3 que hace ref a user
            String sql = "Update orders set REFPAYMENTMETHOD ='" + cmbPay.SelectedValue + "', DATETIME = SYSDATE, TOTAL = '" + txtTotal.Text + "', PREPAID = '" + txtPrepaid.Text + "' Where idorder = " + this.idOrder;
            o.getGestor().setData(sql);

            sql = "SELECT MAX(IDORDER) FROM ORDERS";
            String ido = o.getGestor().getUnString(sql);

            //Console.WriteLine("Traza-- ID ORDER  " + ido);
            for (int i = 0; i < dgvModOrder.RowCount; i++)
            {
                //String idp = o.getGestor().getDataV2("IDPRODUCT", "PRODUCTS", "WHERE UPPER(NAME) =" + dataGridView1.Rows[i].Cells[0].Value.ToString().ToUpper() + "'");
                sql = "SELECT IDPRODUCT FROM PRODUCTS WHERE UPPER(NAME) = '" + dgvModOrder.Rows[i].Cells[3].Value.ToString().ToUpper() + "'";

                String idp = o.getGestor().getUnString(sql);

                //Console.WriteLine("Traza-- ID PRODURC " + idp);

                sql = "Update ordersproducts set REFPRODUCT = '" + idp + "', AMOUNT = " + float.Parse(dgvModOrder.Rows[i].Cells[4].Value.ToString()) + ", PRICESALE = '" + float.Parse(dgvModOrder.Rows[i].Cells[5].Value.ToString()) + "' Where REFORDER = " + this.idOrder;

                o.getGestor().setData(sql);
            }


            this.Dispose();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
