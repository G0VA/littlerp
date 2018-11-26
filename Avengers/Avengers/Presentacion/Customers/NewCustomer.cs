using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avengers.Presentacion
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        /*
         * Metodo para comprobar si  estan rellenos los campos obligatorios
         */
        private bool checkAdd()
        {
            return !(string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtSurname.Text) && string.IsNullOrEmpty(txtDNI.Text)) && checkDNI();
        }

        /*
         * Metodo para comprobar si el DNI cumple con el formato correcto
         */
        private bool checkDNI()
        {
            Regex regex = new Regex("[0-9]{8,8}[A-Za-z]");
            return regex.IsMatch(txtDNI.Text);
        }
        /*
         * Metodo para comprobar si el email cumple el formato correcto
         */
         private bool checkEmail()
        {
            Regex regex = new Regex("^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$");
            return regex.IsMatch(txtEmail.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool email = true;
            if (!String.IsNullOrEmpty(txtEmail.Text)&& !checkEmail())
            {
                email = false;
            }
            if (checkAdd() && email)
            {
                MessageBox.Show("Dentro");
            }else if (!email)
            {
                MessageBox.Show("Error Email");
            }else
            {
                MessageBox.Show("Error General");
            }
        }
    }
}
