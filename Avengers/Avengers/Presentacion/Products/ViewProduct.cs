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

namespace Avengers.Presentacion.Products
{
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
            initTable("Where Deleted = 0");
            initComboEditorial("Where Deleted = 0");
            initComboGender("Where Deleted = 0");
        }

        private void initComboEditorial(String cond) {
            Product p = new Product();
            p.getGestor().readInProduct(cond, "EDITORIAL");
            DataTable tproduct = p.getGestor().getProducts();
            comboEditorial.Items.Clear();

            foreach (DataRow row in tproduct.Rows) {
                comboEditorial.Items.Add(row["EDITORIAL"]);
            }
        }
        private void initComboGender(String cond)
        {
            Product p = new Product();
            p.getGestor().readInProduct(cond, "GENDER");
            DataTable tproduct = p.getGestor().getProducts();
            comboGender.Items.Clear();

            foreach (DataRow row in tproduct.Rows)
            {
                comboGender.Items.Add(row["GENDER"]);
            }
        }
        private void initTable(String cond)
        {
            dgvProduct.Columns.Clear();

            Product p = new Product();
            p.getGestor().readProducts(cond);


            DataTable tproducts = p.getGestor().getProducts();
            dgvProduct.Columns.Clear();

            //dgvCustomers.DataSource = tcustomers;
            

            dgvProduct.Columns.Add("IDPRODUCT", "ID");
            dgvProduct.Columns.Add("GENDER", "GENDER");
            dgvProduct.Columns.Add("EDITORIAL", "EDITORIAL");
            dgvProduct.Columns.Add("PRICE", "PRICE €");
            dgvProduct.Columns.Add("NAME", "NAME");
            dgvProduct.Columns.Add("DESCRIPTION", "DESCRIPTION");
            dgvProduct.Columns.Add("STOCK", "STOCK");


            foreach (DataRow row in tproducts.Rows)
            {
                dgvProduct.Rows.Add(row["IDPRODUCT"], row["GENDER"], row["EDITORIAL"], row["PRICE"], row["NAME"], row["DESCRIPTION"], row["STOCK"]);
            }

        }
        public void filtrar()     
        {
            String sql = "Where 1=1";
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                sql += " And Upper(Name) like '%" + txtName.Text.ToUpper() + "%' ";
            }
            initTable(sql);
        }

        public void filtrarCombo(String condicion) {
            String sql = " Where 1=1";


            if (!comboEditorial.Items.Equals("Choose Editorial"))
            {
                sql += "And Upper(Editorial) = Upper('" + condicion + "')";
            }
            if (!comboGender.Items.Equals("Choose Gender"))
            {
                sql += "And Upper(Gender) = Upper('" + condicion +"')";
            }
            initTable(sql);
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void comboEditorial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String editorial = comboEditorial.Items[comboEditorial.SelectedIndex].ToString();
            filtrarCombo(editorial);
        }

        private void comboGender_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String gender = comboGender.Items[comboGender.SelectedIndex].ToString();
            filtrarCombo(gender);
        }
    }
}
