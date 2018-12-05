using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avengers.Utils;
using Avengers.Dominio;
using Avengers.Persistencia;
using Avengers.Dominio.Gestores;

namespace Avengers.Presentacion
{

    public partial class NewCustomer : Form
    {
        private int refzipcodescities = 0;
        private String idioma;
        public NewCustomer(String idioma)
        {
            InitializeComponent();
            initReg("");
            this.idioma = idioma;
            if (this.idioma == "ESPAÑOL")
            {
                idioma_es();
                this.Text = "Nuevo cliente";
            }
            else
            {
                idioma_en();
                this.Text = "New Customer";
            }
        }
        private void idioma_es()
        {
            label1.Text = Avengers.Recursos.Espanol.lblName;
            label2.Text = Avengers.Recursos.Espanol.lblSurname;
            label3.Text = Avengers.Recursos.Espanol.lblDni;
            lblPhone.Text = Avengers.Recursos.Espanol.lblPhone;
            lblAdrees.Text = Avengers.Recursos.Espanol.lblAdrees;
            label6.Text = Avengers.Recursos.Espanol.lblRegion;
            label7.Text = Avengers.Recursos.Espanol.lblProvince;
            label8.Text = Avengers.Recursos.Espanol.lblCity;
            btnCancel.Text = Avengers.Recursos.Espanol.btnCancel;
            btnAddNew.Text = Avengers.Recursos.Espanol.btnAddNew;
            btnAdd.Text = Avengers.Recursos.Espanol.btnAdd;
        }
        private void idioma_en()
        {
            label1.Text = Avengers.Recursos.Ingles.lblName;
            label2.Text = Avengers.Recursos.Ingles.lblSurname;
            label3.Text = Avengers.Recursos.Ingles.lblDni;
            lblPhone.Text = Avengers.Recursos.Ingles.lblPhone;
            lblAdrees.Text = Avengers.Recursos.Ingles.lblAdrees;
            label6.Text = Avengers.Recursos.Ingles.lblRegion;
            label7.Text = Avengers.Recursos.Ingles.lblProvince;
            label8.Text = Avengers.Recursos.Ingles.lblCity;
            btnCancel.Text = Avengers.Recursos.Ingles.btnCancel;
            btnAddNew.Text = Avengers.Recursos.Ingles.btnAddNew;
            btnAdd.Text = Avengers.Recursos.Ingles.btnAdd;
        }

        
        public void initReg(String cond)
        {
            Customer c = new Customer();
            c.getGestor().readInDB("REGION", "REGIONS", cond);
            DataTable tregion = c.getGestor().getCustomers();
            cmbReg.Items.Clear();
            cmbCity.Items.Clear();
            cmbProv.Items.Clear();
            cmbZIP.Items.Clear();
            foreach (DataRow row in tregion.Rows)
            {
                cmbReg.Items.Add(row["REGION"]);
            }
        }
        private void initProv(String cond)
        {

            Customer c = new Customer();
            c.getGestor().readInDB("STATE", "STATES", cond);
            DataTable tstate = c.getGestor().getCustomers();
            cmbProv.Items.Clear();
            cmbCity.Items.Clear();
            cmbZIP.Items.Clear();
            foreach (DataRow row in tstate.Rows)
            {
                cmbProv.Items.Add(row["STATE"]);
            }

        }

        private void initCities(String cond)
        {
            Customer c = new Customer();
            c.getGestor().readInDB("CITY", "CITIES", cond);
            DataTable tcity = c.getGestor().getCustomers();
            cmbCity.Items.Clear();
            cmbZIP.Items.Clear();
            foreach (DataRow row in tcity.Rows)
            {
                cmbCity.Items.Add(row["CITY"]);
            }
        }
        private void initZipCode(String cond)
        {
            Customer c = new Customer();
            c.getGestor().readInDB("ZIPCODE", "ZIPCODES", cond);
            DataTable tzip = c.getGestor().getCustomers();
            cmbZIP.Items.Clear();

            foreach (DataRow row in tzip.Rows)
            {
                // if (tzip.Rows.Count > 1)
                // {
                //     cmbZIP.Visible = true;
                //     txtZIP.Visible = false;
                //     txtZIP.Clear();
                cmbZIP.Items.Add(row["ZIPCODE"]);
                //}else
                //{
                //    cmbZIP.Visible = false;
                //    txtZIP.Visible = true;
                //    txtZIP.Clear();
                //    txtZIP.Text = row["ZIPCODE"].ToString();
                //}

            }
        }
        /*
         * Metodo para comprobar si  estan rellenos los campos obligatorios
         */
        private bool checkAdd()
        {
            return !(string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtSurname.Text) && string.IsNullOrEmpty(txtDNI.Text)) && Utils.check.checkDNI(txtDNI.Text) && !GestorCustomers.existDNI(txtDNI.Text);
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
                if (string.IsNullOrEmpty(txtSurname.Text))
                {
                    error += "\t - El campo \"Apellido\" no puede estar vacio \n";
                }
                if (string.IsNullOrEmpty(txtDNI.Text))
                {
                    error += "\t - El campo \"DNI\" no puede estar vacio \n";
                }
                if (!Utils.check.checkDNI(txtDNI.Text))
                {
                    error += "\t - El DNI no tiene el formato correcto \n" +
                              " \t\t ejemplo- 00000000A \n";
                }
                if (GestorCustomers.existDNI(txtDNI.Text))
                {
                    error += "\t - Ya existe un cliente con este DNI: " + txtDNI.Text;
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
                if (string.IsNullOrEmpty(txtSurname.Text))
                {
                    error += "\t - The field \"Surname\" can`t be empty \n";
                }
                if (string.IsNullOrEmpty(txtDNI.Text))
                {
                    error += "\t - The field \"DNI\" can`t be empty \n";
                }
                if (!Utils.check.checkDNI(txtDNI.Text))
                {
                    error += "\t - The DNI doesn't the correct format \n" +
                              " \t\t Example- 00000000A \n";
                }
                if (GestorCustomers.existDNI(txtDNI.Text))
                {
                    error += "\t - Already exist a User with the DNI: " + txtDNI.Text;
                }
                return error;
            }
            
        }


        public String inserSql()
        {
            //Construimos El insert
            String sql = "Insert into customers values (null,'" + txtName.Text.ToUpper() + "','" + txtSurname.Text.ToUpper() + "',";

            //en caso de que los campos esten vacios ponemos a null
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                sql += "null,";
            }
            else
            {
                sql += "'" + txtAddress.Text.ToUpper() + "',";
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                sql += "null,";
            }
            else
            {
                sql += "'" + txtPhone.Text.ToUpper() + "',";
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                sql += "null,";
            }
            else
            {
                sql += "'" + txtEmail.Text.ToUpper() + "',";
            }
            //insertamos valor para deleted y el codigo de referencia
            if (this.refzipcodescities == 0)
            {
                sql += "0,null,";
            }
            else
            {
                sql += "0," + this.refzipcodescities + ",";
            }
            //terminamos insertando el dni
            sql += "'" + txtDNI.Text.ToUpper() + "')";

            return sql;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            bool email = true;
            if (!String.IsNullOrEmpty(txtEmail.Text) && !Utils.check.checkEmail(txtEmail.Text))
            {
                email = false;
            }
            if (checkAdd() && email)
            {
                String sql = inserSql();
                GestorCustomers.insertCustomer(sql);
                Dispose();

            }
            else
            {
                if (!email)
                {
                    if (this.idioma == "ESPAÑOL")
                    {
                        MessageBox.Show(errorDialog() + "\t - El campo \"Email\"no tiene el formato correcto \n");
                    }
                    else
                    {
                        MessageBox.Show(errorDialog() + "\t - The field \"Email\"doesn't the correct format \n");
                    }
                }
                else
                {
                    MessageBox.Show(errorDialog());
                }

            }
        }

        private void cmbReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProv.Items.Clear();
            String cond = " Where Refregion = (Select idRegion from regions where Region = '" + cmbReg.SelectedItem.ToString() + "')";
            initProv(cond);
        }

        private void cmbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cond = " Where idcity in(select refcity from zipcodescities z inner join states s on z.refstate= s.idstate where state= '" + cmbProv.SelectedItem.ToString() + "')";
            cmbCity.Items.Clear();
            initCities(cond);
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cond = " Where idzipcode in(select refzipcode from zipcodescities z inner join cities c on z.refcity= c.idcity where city= '" + cmbCity.SelectedItem.ToString() + "')";
            cmbZIP.Items.Clear();
            initZipCode(cond);
        }

        private void cmbZIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            getZipcodesCities();
        }

        private void getZipcodesCities()
        {
            String tables = " zipcodescities z inner join zipcodes zip on refzipcode=idzipcode " +
                           " inner join cities c on refcity=idcity " +
                           " inner join states s on refstate=idstate ";
            String cond = " zipcode='" + cmbZIP.SelectedItem.ToString() + "' And city='" + cmbCity.SelectedItem.ToString() + "' And State= '" + cmbProv.SelectedItem.ToString() + "'";

            ConnectOracle search = new ConnectOracle();
            int resp = Convert.ToInt16(search.DLookUp("IDZIPCODESCITIES", tables, cond));
            this.refzipcodescities = resp;
        }
        private void clean()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtDNI.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtZIP.Clear();
            initReg("");
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {

            bool email = true;
            if (!String.IsNullOrEmpty(txtEmail.Text) && !Utils.check.checkEmail(txtEmail.Text))
            {
                email = false;
            }
            if (checkAdd() && email)
            {

                String sql = inserSql();
                GestorCustomers.insertCustomer(sql);
                clean();

            }
            else
            {
                if (!email)
                {
                    if (this.idioma == "ESPAÑOL")
                    {
                        MessageBox.Show(errorDialog() + "\t - El campo \"Email\"no tiene el formato correcto \n");
                    }
                    else
                    {
                        MessageBox.Show(errorDialog() + "\t - The field \"Email\"doesn't the correct format \n");
                    }
                        
                }
                else
                {
                    MessageBox.Show(errorDialog());
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
