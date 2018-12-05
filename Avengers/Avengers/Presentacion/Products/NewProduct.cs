using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avengers.Dominio.Gestores;
using Avengers.Dominio;

namespace Avengers.Presentacion.Products
{
    public partial class NewProduct : Form
    {
        private String idioma;
        public NewProduct(String idioma)
        {
            InitializeComponent();
            initComboEditorial("Where Deleted = 0");
            initComboGender("Where Deleted = 0");
            this.idioma = idioma;
            if (this.idioma == "ESPAÑOL")
            {
                idioma_es();
                this.Text = "Nuevo Producto";
            }
            else if (this.idioma == "INGLES")
            {
                idioma_en();
                this.Text = "New Product";
            }
        }

        public void idioma_es()
        {
            label1.Text = Avengers.Recursos.Espanol.lblName;
            label3.Text = Avengers.Recursos.Espanol.label3;
            label4.Text = Avengers.Recursos.Espanol.label2;
            label6.Text = Avengers.Recursos.Espanol.label6;
            label5.Text = Avengers.Recursos.Espanol.label4;
            lblDescrip.Text = Avengers.Recursos.Espanol.lblDescrip;
            btnCancel.Text = Avengers.Recursos.Espanol.btnCancel;
            btnAddandNew.Text = Avengers.Recursos.Espanol.btnAddNew;
            btnAdd.Text = Avengers.Recursos.Espanol.btnAdd;
        }
        public void idioma_en()
        {
            label1.Text = Avengers.Recursos.Ingles.lblName;
            label3.Text = Avengers.Recursos.Ingles.label3;
            label4.Text = Avengers.Recursos.Ingles.label2;
            label6.Text = Avengers.Recursos.Ingles.label6;
            label5.Text = Avengers.Recursos.Ingles.label4;
            lblDescrip.Text = Avengers.Recursos.Ingles.lblDescrip;
            btnCancel.Text = Avengers.Recursos.Ingles.btnCancel;
            btnAddandNew.Text = Avengers.Recursos.Ingles.btnAddNew;
            btnAdd.Text = Avengers.Recursos.Ingles.btnAdd;
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
            p.getGestor().readInProductV3(cond, "EDITORIAL", "EDITORIAL");
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
            p.getGestor().readInProductV3(cond, "GENDER", "GENDER");
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
            String sql = "Insert into products values (null,'" + comboGender.Text.ToString().ToUpper() + "','" + comboEditorial.Text.ToString().ToUpper() + "',";

            //en caso de que los campos esten vacios ponemos a null
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                sql += "null,";
            }
            else
            {
                sql +=  txtPrice.Text + ",";
            }

            sql +=  0 + ",";

            if (String.IsNullOrEmpty(txtName.Text))
            {
                sql += "null,";
            }
            else
            {
                sql += "'" + txtName.Text.ToUpper() + "',";
            }
            if (String.IsNullOrEmpty(txtDescription.Text))
            {
                sql += "null,";
            }
            else
            {
                sql += "'" + txtDescription.Text.ToUpper() + "',";
            }
            if (String.IsNullOrEmpty(txtStock.Text))
            {
                sql += "null,";
            }
            else
            {
                sql += txtStock.Text + ")";
            }


            return sql;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            bool price = true;
            if (!Utils.check.checkPrice(txtPrice.Text))
            {
                price = false;
            }
            if (checkAdd() && price)
            {
                GestorProducts.writeProduct(inserSql());
                Dispose();

            }
            else
            {
                if (this.idioma == "ESPAÑOL")
                {
                    if (!price)
                    {
                        MessageBox.Show(errorDialog() + "\t - El campo \"Precio\"no tiene el formato correcto \n");
                    }
                    else
                    {
                        MessageBox.Show(errorDialog());
                    }
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
        }
        private String errorDialog()
        {
            if (this.idioma == "ESPAÑOL")
            {
                String error = "Se han encontrado algunos errores: \n";
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    error += "\t - El campo \"Nombre\" no puede estar vacio \n";
                }
                if (string.IsNullOrEmpty(txtStock.Text))
                {
                    error += "\t - El campo \"Stock\" no puede estar vacio \n";
                }
                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    error += "\t - El campo \"Precio\" no puede estar vacio \n";
                }
                if (!Utils.check.checkPrice(txtPrice.Text))
                {
                    error += "\t - El precio no tiene el formato correcto \n";
                }
                if (GestorProducts.existProduct(txtName.Text))
                {
                    error += "\t - Ya existe un producto con nombre: " + txtName.Text;
                }
                return error;
            }
            else
            {
                String error = "Some Errors has been found: \n";
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
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clean()
        {
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            comboEditorial.Items.Clear();
            comboGender.Items.Clear();
            initComboEditorial("Where Deleted = 0");
            initComboGender("Where Deleted = 0");
        }

        private void btnAddandNew_Click(object sender, EventArgs e)
        {
            bool price = true;
            if (!Utils.check.checkPrice(txtPrice.Text))
            {
                price = false;
            }
            if (checkAdd() && price)
            {
                GestorProducts.writeProduct(inserSql());
                clean();

            }
            else
            {
                if (this.idioma == "ESPAÑOL")
                {
                    if (!price)
                    {
                        MessageBox.Show(errorDialog() + "\t - El campo \"Precio\"no tiene el formato correcto \n");
                    }
                    else
                    {
                        MessageBox.Show(errorDialog());
                    }
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
        }
    }
}
