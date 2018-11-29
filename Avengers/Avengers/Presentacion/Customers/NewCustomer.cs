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
        public NewCustomer()
        {
            InitializeComponent();
            initReg("");
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
            String error = " Some Errors has been found: \n";

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

   
        public void insertCustomer()
        {
            //Construimos El insert
            String sql = "Insert into customers values (null,'" + txtName.Text.ToUpper() + "','" + txtSurname.Text.ToUpper() + "',";

            //en caso de que los campos esten vacios ponemos a null
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                sql += "null,";
            }else
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
            }else
            {
                sql += "0," + this.refzipcodescities + ",";
            }
            //terminamos insertando el dni
            sql += "'" + txtDNI.Text.ToUpper() + "')";

            ConnectOracle insert = new ConnectOracle();
            insert.setData(sql);

            //insertamos en el log de customers
            //ConnectOracle insertlog = new ConnectOracle();

            //String log = "Insert into log_customers values (null,'USUARIO','INSERT',SYSDATE," + sql + ")";
            //insertlog.setData(log);
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            bool email = true;
            if (!String.IsNullOrEmpty(txtEmail.Text)&& !Utils.check.checkEmail(txtEmail.Text))
            {
                email = false;
            }
            if (checkAdd() && email)
            {

                insertCustomer();
                Dispose();

            }
            else
            {
                if (!email)
                {
                    MessageBox.Show(errorDialog()+ "\t - The field \"Email\"doesn't the correct format \n");
                }else
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

                insertCustomer();
                clean();

            }
            else
            {
                if (!email)
                {
                    MessageBox.Show(errorDialog() + "\t - The field \"Email\"doesn't the correct format \n");
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
