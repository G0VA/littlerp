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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
               
        }

        private void mostrarBtn()
        {
            users.Visible = true;
            users.Enabled = true;
            customers.Visible = true;
            customers.Enabled = true;
            products.Visible = true;
            products.Enabled = true;

            btnOrders.Location = new Point(0, 160);
        }

        private void ocultarBtn()
        {
            users.Visible = false;
            users.Enabled = false;
            customers.Visible = false;
            customers.Enabled = false;
            products.Visible = false;
            products.Enabled = false;

            btnOrders.Location = new Point(0, 60);
        }

        private void users_Click(object sender, EventArgs e)
        {
            Users u1 = new Users();
            u1.MdiParent = this;
            u1.WindowState = FormWindowState.Maximized;
            u1.Show();

        }

        private void btnSys_Click(object sender, EventArgs e)
        {
            mostrarBtn();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ocultarBtn();
        }
    }
}
