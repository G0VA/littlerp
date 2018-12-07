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

            //esta consulta me da -1 comprobar por que
            Console.WriteLine(GestorCustomers.getData(" NAME ", " CUSTOMERS ", " IDCUSTOMER = '" + this.idcustomer + "'"));
           // txtCustomer.Text = GestorCustomers.getData(" NAME||' '||SURNAME ", " CUSTOMERS ", " IDCUSTOMER='" + this.idcustomer + "'").ToString();
            cmbPay.SelectedValue = refpaymentmethod;
            tbxTotal.Text = this.total;
            
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
    }
}
