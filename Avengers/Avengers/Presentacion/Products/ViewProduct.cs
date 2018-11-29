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

        private void initComboEditorial(String cond)
        {
            Product p = new Product();
            p.getGestor().readInProductV3(cond, "EDITORIAL", "EDITORIAL");
            DataTable tproduct = p.getGestor().getProducts();
            comboEditorial.Items.Clear();
            comboEditorial.Items.Add(" ");
            foreach (DataRow row in tproduct.Rows)
            {
                comboEditorial.Items.Add(row["EDITORIAL"]);

            }
        }
        private void initComboGender(String cond)
        {
            Product p = new Product();
            p.getGestor().readInProductV3(cond, "GENDER", "GENDER");
            DataTable tproduct = p.getGestor().getProducts();
            comboGender.Items.Clear();
            comboGender.Items.Add(" ");
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

            if (comboEditorial.SelectedIndex != -1)
            {
                sql += " And Upper(Editorial) = Upper('" + comboEditorial.SelectedItem.ToString() + "')";
            }
            if (comboGender.SelectedIndex != -1)
            {
                sql += " And Upper(Gender) = Upper('" + comboGender.SelectedItem.ToString() + "')";
            }
            if (chckDelete.Checked)
            {
                sql += " And deleted = 1";
            }
            if (!chckDelete.Checked)
            {
                sql += " And deleted = 0";
            }
            if (rbtnAscend.Checked)
            {
                sql += " ORDER BY PRICE ASC";
            }
            if (rbtnDescend.Checked)
            {
                sql += " ORDER BY PRICE DESC";
            }
            initTable(sql);
        }



        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void comboEditorial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filtrar();
        }

        private void comboGender_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filtrar();
        }

        private void rbtnDescend_CheckedChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void rbtnAscend_CheckedChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewProduct np = new NewProduct();
            np.ShowDialog();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            initTable("Where Deleted = 0");
            txtName.Clear();
            comboGender.SelectedItem = " ";
            comboEditorial.SelectedItem = " ";
            this.groupBox1.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) =>
            {
                rbtnAscend.Checked = false;
                rbtnDescend.Checked = false;
            });

        }

        private void chckDelete_CheckedChanged(object sender, EventArgs e)
        {
            filtrar();
        }
    }
}
