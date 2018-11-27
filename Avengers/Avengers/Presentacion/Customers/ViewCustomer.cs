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
        }

        private void initTable(String cond)
        {
            dgvCustomer.Columns.Clear();
         
            Customer c = new Customer();
            c.gestor().readCustomers(cond);

            
            DataTable tcustomers = c.gestor().getCustomers();
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

        public void filtrar()
        {
            String sql = " Where 1=1";

            if (!String.IsNullOrEmpty(txtName.Text))
            {
                sql += " And Upper(Name) like '%" + txtName.Text.ToUpper() + "%' ";
            }
            initTable(sql);
        }
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("ping");
            filtrar();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewCustomer nc = new NewCustomer();
            nc.ShowDialog();
        }
    }
}
