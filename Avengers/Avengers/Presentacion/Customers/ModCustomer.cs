using Avengers.Dominio;
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
        public ModCustomer(int id)
        {
            this.idCustomer = id;
            InitializeComponent();
            initCustomer();
            initReg("");
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
                String refzip= row["REFZIPCODESCITIES"].ToString();
               // selectCombos(refzip);

            }
        }

        private void selectCombos(String refzip)
        {
            Customer ZipCodeCity = new Customer();

            ZipCodeCity.getGestor().readInDB("zipcode, city, region, state",
                " zipcodescities  inner join zipcodes  on refzipcode = idzipcode inner join cities on refcity = idcity " +
                "inner join  states on refstate = idstate inner join regions on refregion = idregion", "where idzipcodescities = " + refzip);
            DataTable tzipcodescities = ZipCodeCity.getGestor().getCustomers();
            
            foreach (DataRow row in tzipcodescities.Rows)
            {

                cmbReg.SelectedItem = row["REGION"].ToString();
                
            }

        }

        public void initReg(String cond)
        {
            Customer c = new Customer();
            c.getGestor().readInDB("REGION ", "REGIONS", cond);
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
                cmbZIP.Items.Add(row["ZIPCODE"]);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cmbReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDNI.Text = cmbReg.ValueMember.ToString();
        }
    }
}
