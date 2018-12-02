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
        public NewOrder()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
           
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

        private void btnFindProd_Click(object sender, EventArgs e)
        {
            ViewProduct vp = new ViewProduct(this);
            vp.ShowDialog(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //String sql="Insert into ordersproducts values(null,"
            //if(Dominio.Gestores.GestorCustomers.existCustomer(this.dtoCustomer.Idcustomer) && Dominio.Gestores.GestorProducts.existProduct(this.dtoProduct.Name){
            //    Dominio.Gestores.GestorOrdersProduct.insertOrderProduct()
            //}
        }
    }
}
