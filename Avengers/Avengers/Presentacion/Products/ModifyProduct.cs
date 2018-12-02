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
using Avengers.Dominio.Gestores;
using Avengers.Presentacion.Products;

namespace Avengers.Presentacion.Products
{
    public partial class ModifyProduct : Form
    {
        public String id;
        public ModifyProduct()
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
            foreach (DataRow row in tproduct.Rows)
            {
                comboGender.Items.Add(row["GENDER"]);

            }
        }

      
        public String inserSql()
        {
            //Construimos El insert
            String sql = "Update products SET GENDER = '" + comboGender.Text.ToString().ToUpper() + "', EDITORIAL = '" + comboEditorial.Text.ToString().ToUpper() + "',";

            //en caso de que los campos esten vacios ponemos a null
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                sql += " PRICE = null,";
            }
            else
            {
                sql +=" PRICE ="+ txtPrice.Text + ",";
            }


            if (String.IsNullOrEmpty(txtName.Text))
            {
                sql += " NAME = null,";
            }
            else
            {
                sql += " NAME ='" + txtName.Text.ToUpper() + "',";
            }
            if (String.IsNullOrEmpty(txtDescription.Text))
            {
                sql += " DESCRIPTION = null,";
               
            }
            
            else
            {
                sql += " DESCRIPTION ='" + txtDescription.Text.ToUpper() + "',";
            }
            if (String.IsNullOrEmpty(txtStock.Text))
            {
                sql += " STOCK = null";
            }
            else
            {
                sql += " STOCK = "+ txtStock.Text;
            }
            

            return sql;

        }
        private String errorDialog()
        {
            String error = " Some Errors has been found: \n";

            if (string.IsNullOrEmpty(txtName.Text))
            {
                error += "\t - The field \"Name\" can`t be empty \n";
            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                error += "\t - The field \"Stock\" can`t be empty \n";
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                error += "\t - The field \"Price\" can`t be empty \n";
            }
            if (!Utils.check.checkPrice(txtPrice.Text))
            {
                error += "\t - The Price doesn't the correct format \n";
            }
            if (GestorProducts.existProduct(txtName.Text))
            {
                error += "\t - Already exist a Product with name: " + txtName.Text;
            }

            return error;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            bool price = true;
            if (!Utils.check.checkPrice(txtPrice.Text))
            {
                price = false;
            }
            if (checkAdd() && price)
            {

                Console.WriteLine(inserSql()+" Where IDPRODUCT =" + this.id);
                GestorProducts.updateProduct(inserSql(),this.id);
                Console.WriteLine("TRAZA3");
                Dispose();

            }
            else
            {
                if (!price)
                {
                    MessageBox.Show(errorDialog() + "\t - The field \"Price\"doesn't the correct format \n");
                }
                else
                {
                    MessageBox.Show(errorDialog());
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
