using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avengers.Presentacion.Products;
using Avengers.Presentacion.Orders;
using Avengers.Dominio;

namespace Avengers.Presentacion
{
    public partial class Menu : Form
    {
        private ViewUsers u1;
        private ViewCustomer c1;
        private ViewOrders o1;
        private ViewProduct p1;
        private User u;

        public Menu(User u)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.u = u;
            lblUser.Text = "                 " +u.getNombre();
        }


        private void mostrarBtn()
        {
            users.Visible = true;
            users.Enabled = true;
            customers.Visible = true;
            customers.Enabled = true;
            products.Visible = true;
            products.Enabled = true;

            btnOrders.Location = new Point(0, 180);
        }

        private void ocultarBtn()
        {
            users.Visible = false;
            users.Enabled = false;
            customers.Visible = false;
            customers.Enabled = false;
            products.Visible = false;
            products.Enabled = false;

            btnOrders.Location = new Point(0, 80);
        }

        private void users_Click(object sender, EventArgs e)
        {

            if (!tabControl.TabPages.ContainsKey("u1"))
            {
                u1 = new ViewUsers();
                tabControl.Visible = true;
                u1.MdiParent = this;
                u1.WindowState = FormWindowState.Normal;
                u1.FormBorderStyle = FormBorderStyle.None;
                u1.TopLevel = false;
                u1.Dock = DockStyle.Fill;
                u1.Show();

                TabPage tpu = new TabPage("Users");
                tpu.Tag = u1;
                tpu.Name = "u1";
                tpu.Parent = tabControl;
                tabControl.SelectedTab = tpu;
                u1.Tag = tpu;
            }
            else
            {
                int n = tabControl.TabPages.IndexOfKey("u1");
                tabControl.SelectTab(n);
            }
             
        }
 
        private void tabControl_SelectedIndexChanged(object sender,
                                           EventArgs e)
        {
            if ((tabControl.SelectedTab != null) &&
                (tabControl.SelectedTab.Tag != null))
                (tabControl.SelectedTab.Tag as Form).Select();
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
            if (!tabControl.TabPages.ContainsKey("o1"))
            {
                o1 = new ViewOrders(this.u);
                ocultarBtn();
                tabControl.Visible = true;
                o1.MdiParent = this;
                o1.WindowState = FormWindowState.Normal;
                o1.FormBorderStyle = FormBorderStyle.None;
                o1.TopLevel = false;
                o1.Dock = DockStyle.Fill;
                o1.Show();

                TabPage tp = new TabPage("Orders");
                tp.Tag = o1;
                tp.Name = "o1";
                tp.Parent = tabControl;
                tabControl.SelectedTab = tp;
                o1.Tag = tp;
            }
            else
            {
                ocultarBtn();
                int n = tabControl.TabPages.IndexOfKey("o1");
                tabControl.SelectTab(n);
            }
        
        }

        private void customers_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.ContainsKey("c1"))
            {
                c1 = new ViewCustomer();
                tabControl.Visible = true;
                c1.MdiParent = this;
                c1.WindowState = FormWindowState.Normal;
                c1.FormBorderStyle = FormBorderStyle.None;
                c1.TopLevel = false;
                c1.Dock = DockStyle.Fill;
                c1.Show();

                TabPage tp = new TabPage("Customers");
                tp.Tag = c1;
                tp.Name = "c1";
                tp.Parent = tabControl;
                tabControl.SelectedTab = tp;
                c1.Tag = tp;
            }
            else
            {
                int n = tabControl.TabPages.IndexOfKey("c1");
                tabControl.SelectTab(n);
            }
            
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount > 0)
            {
                if (tabControl.SelectedTab.Name.Equals("u1"))
                {
                    u1.Dispose();
                }
                if (tabControl.SelectedTab.Name.Equals("o1"))
                {
                    o1.Dispose();
                }
                if (tabControl.SelectedTab.Name.Equals("c1"))
                {
                    c1.Dispose();
                }
                if (tabControl.SelectedTab.Name.Equals("p1"))
                {
                    p1.Dispose();
                }

                tabControl.TabPages.Remove(tabControl.SelectedTab);
                
                if (tabControl.TabCount == 0)
                {
                    tabControl.Visible = false;
                }
                else
                {
                    int resta = tabControl.TabCount - 1;
                    tabControl.SelectTab(resta);
                }                   
            }
            else
            {
                tabControl.Visible = false;
            }

        }

        private void products_Click(object sender, EventArgs e)
        {
            if (!tabControl.TabPages.ContainsKey("p1"))
            {
                p1 = new ViewProduct();
                tabControl.Visible = true;
                p1.MdiParent = this;
                p1.WindowState = FormWindowState.Normal;
                p1.FormBorderStyle = FormBorderStyle.None;
                p1.TopLevel = false;
                p1.Dock = DockStyle.Fill;
                p1.Show();

                TabPage tp = new TabPage("Products");
                tp.Tag = p1;
                tp.Name = "p1";
                tp.Parent = tabControl;
                tabControl.SelectedTab = tp;
                p1.Tag = tp;
            }
            else
            {
                int n = tabControl.TabPages.IndexOfKey("p1");
                tabControl.SelectTab(n);
            }
        }
    }
}
