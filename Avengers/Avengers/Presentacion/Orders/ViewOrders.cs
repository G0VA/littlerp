using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avengers.Presentacion.Orders
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewOrder o = new NewOrder();
            o.Show();
        }
    }
}
