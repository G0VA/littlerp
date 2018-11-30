using Avengers.Dominio;
using Avengers.Dominio.Gestores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avengers.Presentacion.Customers
{
    public partial class ModCustomer : Form
    {
        private int idCustomer;
        private string refzipcodescities;
        public ModCustomer(int id)
        {
            this.idCustomer = id;
            InitializeComponent();
           
            initReg("");
            initCustomer();
        }
        private void initCustomer()
        {
            Customer c = new Customer();
            c.getGestor().readCustomers(" Where IDCUSTOMER ="+this.idCustomer);

            DataTable tcustomers = c.getGestor().getCustomers();


            foreach (DataRow row in tcustomers.Rows)
            {
                lblDNI.Text = row["DNI"].ToString();   
                txtName.Text = row["NAME"].ToString();
                txtSurname.Text = row["SURNAME"].ToString();
                txtEmail.Text = row["EMAIL"].ToString();
                txtPhone.Text = row["PHONE"].ToString();
                txtAddress.Text = row["ADDRESS"].ToString();
                String refzip= (row["REFZIPCODESCITIES"]==null)?null: row["REFZIPCODESCITIES"].ToString();
                if (!String.IsNullOrEmpty(refzip))
                {
                    selectCombos(refzip);
                }else
                {
                    cmbReg.SelectedItem = null;
                }
               

            }
        }

        private void selectCombos(String refzip)
        {
            Customer ZipCodeCity = new Customer();

            ZipCodeCity.getGestor().readInDB("refzipcode, refcity, refregion, refstate",
                " zipcodescities  inner join zipcodes  on refzipcode = idzipcode inner join cities on refcity = idcity " +
                "inner join  states on refstate = idstate inner join regions on refregion = idregion", "where idzipcodescities = " + refzip);
            DataTable tzipcodescities = ZipCodeCity.getGestor().getCustomers();
            
            foreach (DataRow row in tzipcodescities.Rows)
            {
                cmbReg.SelectedValue = row["refregion"].ToString();
                initProv("Where refregion=" + row["refregion"].ToString());
                cmbProv.SelectedValue = row["refstate"].ToString();
                initCities("Where idcity=" + row["refcity"].ToString());
                cmbCity.SelectedValue = row["refcity"].ToString();
                initZipCode("Where idzipcode=" + row["refzipcode"].ToString());
                cmbZIP.SelectedValue = row["refzipcode"].ToString();

            }

        }

        public void initReg(String cond)
        {
            Customer c = new Customer();
            c.getGestor().readInDB("IDREGION, REGION ", "REGIONS", cond);
            DataTable tregion = c.getGestor().getCustomers();

            cmbReg.DataSource = tregion;
            cmbReg.DisplayMember="REGION";
            cmbReg.ValueMember="IDREGION";

        }
        private void initProv(String cond)
        {

            Customer c = new Customer();
            c.getGestor().readInDB("IDSTATE, STATE", "STATES", cond);
            DataTable tstate = c.getGestor().getCustomers();
 
            cmbProv.DataSource = tstate;
            cmbProv.DisplayMember = "STATE";
            cmbProv.ValueMember = "IDSTATE";

        }

        private void initCities(String cond)
        {
            Customer c = new Customer();
            c.getGestor().readInDB("IDCITY, CITY", "CITIES", cond);
            DataTable tcity = c.getGestor().getCustomers();

            cmbCity.DataSource = tcity;
            cmbCity.DisplayMember = "CITY";
            cmbCity.ValueMember = "IDCITY";
        }
        private void initZipCode(String cond)
        {
            Customer c = new Customer();
            c.getGestor().readInDB("IDZIPCODE, ZIPCODE", "ZIPCODES", cond);
            DataTable tzip = c.getGestor().getCustomers();

            cmbZIP.DataSource = tzip;
            cmbZIP.DisplayMember = "ZIPCODE";
            cmbZIP.ValueMember = "IDZIPCODE";
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

            return error;
        }
        private String extraerRefZipCodesCities()
        {
            String refe = null;

            refe=GestorCustomers.getData("IDZPICODESCITIES", "ZIPCODESCITIES", " WHERE REFZIPCODE=" + cmbZIP.SelectedValue.ToString()
                + " REFCITY=" + cmbCity.SelectedValue.ToString() + " REFSTATE=" + cmbProv.SelectedValue.ToString()); 

            return refe;

        }
        public String updateSql()
        {
            //Construimos El insert
            String sql = "Update customers set  NAME='" + txtName.Text.ToUpper() + "', SURNAME='" + txtSurname.Text.ToUpper() + "',";

            //en caso de que los campos esten vacios ponemos a null
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                sql += "ADDRESS=null,";
            }
            else
            {
                sql += "ADDRESS='" + txtAddress.Text.ToUpper() + "',";
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                sql += "PHONE=null,";
            }
            else
            {
                sql += "PHONE='" + txtPhone.Text.ToUpper() + "',";
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                sql += "EMAIL=null,";
            }
            else
            {
                sql += "EMAIL='" + txtEmail.Text.ToUpper() + "',";
            }

            if (cmbCity.SelectedIndex!=-1 && cmbProv.SelectedIndex != -1 && cmbZIP.SelectedIndex != -1) 
            {
                sql += "REFZIPCODESCITIES= (Select idzipcodescities from zipcodescities  WHERE REFZIPCODE=" + cmbZIP.SelectedValue.ToString() +
                    " and REFCITY =" + cmbCity.SelectedValue.ToString() + "  and REFSTATE = " + cmbProv.SelectedValue.ToString() + "),";
            }else
            {
                sql += "REFZIPCODESCITIES= null,";
            }
            //terminamos insertando el dni
            sql += "DNI='" + lblDNI.Text.ToUpper() + "' WHERE IDCUSTOMER="+this.idCustomer;

            return sql;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }



        private void cmbReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                initProv(" Where refregion = " + (cmbReg.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
                //buscar solucion menos chapuzas
            }

        }

        private void cmbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                initCities(" where idcity IN(Select refcity from zipcodescities where refstate=" + (cmbProv.SelectedValue.ToString())+")");
            }
            catch (Exception ex)
            {
                //buscar solucion menos chapuzas
            }
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                initZipCode(" where idzipcode IN(Select refzipcode from zipcodescities where refcity=" + (cmbCity.SelectedValue.ToString()) + ")");

            }
            catch (Exception ex)
            {
                //buscar solucion menos chapuzas
            }
        }
        private bool checkUpdate()
        {
            return !(string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtSurname.Text));
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do yo Want Update this Customers ?", "Update Customer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool email = true;
                if (!String.IsNullOrEmpty(txtEmail.Text) && !Utils.check.checkEmail(txtEmail.Text))
                {
                    email = false;
                }
                if (checkUpdate() && email)
                {
                    String sql = updateSql();
                    Console.WriteLine(sql);
                    GestorCustomers.setData(sql);
                    Dispose();

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
