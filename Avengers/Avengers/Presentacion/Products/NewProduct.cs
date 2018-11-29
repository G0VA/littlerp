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
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
            initComboEditorial("Where Deleted = 0");
            initComboGender("Where Deleted = 0");
        }

        private bool checkAdd()
        {
            return !(string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtStock.Text) &&
                string.IsNullOrEmpty(txtPrice.Text) && !comboEditorial.SelectedItem.Equals(" ") && 
                !comboGender.SelectedItem.Equals(" "));
        }
        private void initComboEditorial(String cond)
        {
            Product p = new Product();
            p.getGestor().readInProduct(cond, "EDITORIAL");
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
            p.getGestor().readInProduct(cond, "GENDER");
            DataTable tproduct = p.getGestor().getProducts();
            comboGender.Items.Clear();
            comboGender.Items.Add(" ");
            foreach (DataRow row in tproduct.Rows)
            {
                comboGender.Items.Add(row["GENDER"]);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String gender;
            String editorial;
            bool price = true;
            if (!Utils.check.checkPrice(txtPrice.Text))
            {
                price = false;
            }
            if (checkAdd() && price)
            {

                gender = comboGender.SelectedItem.ToString();
                editorial = comboEditorial.SelectedItem.ToString();
                Product p = new Product();
                DataSet data = new DataSet();
                data = p.getGestor().readInProductV2("Where Upper(Name) = Upper('" + txtName.Text + "')", "Name");
                if (data.ToString() == null)
                {
                    p.getGestor().writeProduct(gender, editorial, float.Parse(txtPrice.Text),
                        txtName.Text, txtDescription.Text, int.Parse(txtStock.Text));

                }
                else
                {
                    MessageBox.Show("EXISTING BOOK");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
