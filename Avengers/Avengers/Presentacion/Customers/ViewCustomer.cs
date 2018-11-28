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

namespace Avengers.Presentacion
{
    public partial class ViewCustomer : Form
    {

        public ViewCustomer()
        {
            InitializeComponent();
            initTable(" Where Deleted =0");
            initCombos();
        }

        private void initTable(String cond)
        {
            dgvCustomer.Columns.Clear();
         
            Customer c = new Customer();
            c.getGestor().readCustomers(cond);

            
            DataTable tcustomers = c.getGestor().getCustomers();
            dgvCustomer.Columns.Clear();

            //dgvCustomers.DataSource = tcustomers;

            dgvCustomer.Columns.Add("IDCUSTOMER", "ID");
            dgvCustomer.Columns.Add("NAME", "NAME");
            dgvCustomer.Columns.Add("SURNAME", "SURNAME");
            dgvCustomer.Columns.Add("DNI", "NIF/DNI");
            dgvCustomer.Columns.Add("ADDRESS", "ADDRESS");
            dgvCustomer.Columns.Add("PHONE", "PHONE");
            dgvCustomer.Columns.Add("EMAIL", "EMAIL");
            dgvCustomer.Columns.Add("REFZIPCODESCITIES", "REFZIP");
           

            foreach (DataRow row in tcustomers.Rows)
            {
                dgvCustomer.Rows.Add(row["IDCUSTOMER"], row["NAME"], row["SURNAME"], row["DNI"], row["ADDRESS"], row["PHONE"], row["EMAIL"], row["REFZIPCODESCITIES"]);
            }
            
        }

        private void initCombos()
        {
            initRegion("");
            initProv("");
            cmbCity.Enabled = false;
            //initZip();
        }

        private void initRegion(String cond)
        {
            Customer c = new Customer();
            c.getGestor().readInDB("REGION","REGIONS", cond);
            DataTable tregion = c.getGestor().getCustomers();
            cmbReg.Items.Clear();

            foreach(DataRow row in tregion.Rows)
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

            foreach (DataRow row in tstate.Rows)
            {
                cmbProv.Items.Add(row["STATE"]);
            }

        }

        private void initCities(String cond)
        {
            Customer c = new Customer();
            c.getGestor().readInDB("CITY", "CITIES", cond);
            DataTable tstate = c.getGestor().getCustomers();
            cmbCity.Items.Clear();

            foreach (DataRow row in tstate.Rows)
            {
                cmbCity.Items.Add(row["CITY"]);
            }
        }

        public void filtrar()
        {
            int comb = 0;
            String sql = " Where 1=1";
            String subCons = " AND REFZIPCODESCITIES IN (SELECT IDZIPCODESCITIES FROM ZIPCODESCITIES Z INNER JOIN STATES S " +
                                "ON Z.REFSTATE = S.IDSTATE INNER JOIN REGIONS R ON S.REFREGION = R.IDREGION "+
                                " INNER JOIN CITIES CI ON Z.REFCITY = CI.IDCITY "+
                                " INNER JOIN ZIPCODES ZIP ON ZIP.IDZIPCODE=Z.REFZIPCODE WHERE 1=1 ";

            if (!String.IsNullOrEmpty(txtName.Text))
            {
                sql += " And Upper(Name) like '%" + txtName.Text.ToUpper() + "%' ";
            }
            if (!String.IsNullOrEmpty(txtSurname.Text))
            {
                sql += " And upper(Surname) like '%" + txtSurname.Text.ToUpper() + "%'";
            }
            if (!String.IsNullOrEmpty(txtDNI.Text))
            {
                sql += " And Upper(DNI) like '%" + txtDNI.Text.ToUpper() + "%'";
            }


            if(cmbReg.SelectedIndex != -1)
            {
                subCons += " AND R.REGION = '" + cmbReg.SelectedItem.ToString()+"' ";
                comb++;
            }
            if (cmbProv.SelectedIndex != -1)
            {
                subCons += " AND  S.STATE = '" + cmbProv.SelectedItem.ToString() + "' ";
                comb++;
            }
            if(cmbCity.SelectedIndex != -1)
            {
                subCons += " AND CI.CITY = '" + cmbCity.SelectedItem.ToString() + "' ";
                comb++;
            }
            if (!String.IsNullOrEmpty(txtZip.Text))
            {
                subCons += " AND ZIP.ZIPCODE= '%" + txtZip.Text + "%' ";
            }
            if (ckDel.Checked)
            {
                sql += " And DELETED=1";
            }


            Console.WriteLine(sql);
            if (comb > 0)
            {
                initTable(sql+subCons+")");
            }else
            {
                initTable(sql);
            }
            
        }
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewCustomer nc = new NewCustomer();
            nc.ShowDialog();
        }

        private void txtSurname_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void txtDNI_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void cmbReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
            cmbProv.Items.Clear();
            String cond = " Where Refregion = (Select idRegion from regions where Region = '"+ cmbReg.SelectedItem.ToString()+ "')";
            initProv(cond);
        }

        private void cmbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
            String cond= " Where idcity in(select refcity from zipcodescities z inner join states s on z.refstate= s.idstate where state= '"+cmbProv.SelectedItem.ToString()+"')";
            cmbCity.Enabled = true;
            cmbCity.Items.Clear();
            initCities(cond);
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void txtZip_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void ckDel_CheckedChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSurname.Clear();
            txtDNI.Clear();
            //cmbReg.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
            //cmbProv.SelectedIndex = -1;
            initCombos();
            txtZip.Clear();
            ckDel.Checked = false;
            initTable(" Where Deleted=0");

        }
    }
}
