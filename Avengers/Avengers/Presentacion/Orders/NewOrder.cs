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
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
           
        }
        public void CreateScroll()
        {
            // Set the Multiline property to true.
            tbxAmount.Multiline = true;
            // Add vertical scroll bars to the TextBox control.
            tbxAmount.ScrollBars = ScrollBars.Vertical;
            // Allow the TAB key to be entered in the TextBox control.
            tbxAmount.AcceptsReturn = true;
            // Allow the TAB key to be entered in the TextBox control.
            tbxAmount.AcceptsTab = true;
            // Set WordWrap to true to allow text to wrap to the next line.
            tbxAmount.WordWrap = true;
            // Set the default text of the control.
            tbxAmount.Text = "0";

        }
    }
}
