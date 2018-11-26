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
            initTable();
        }

        private void initTable()
        {
            Customer c = new Customer();
            c.gestor().readCustomers();

            DataTable tcustomers = c.gestor().getCustomers();
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
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
           //evento al soltar tecla
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewCustomer nc = new NewCustomer();
            nc.ShowDialog();
        }
    }
}
