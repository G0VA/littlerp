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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
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
