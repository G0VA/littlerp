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
using Avengers.Utils;
using Avengers.Dominio;
using Avengers.Persistencia;

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
            return !(string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtSurname.Text) && string.IsNullOrEmpty(txtDNI.Text)) && Utils.check.checkDNI(txtDNI.Text);
        }

        private String errorDialog()
        {
            String error = " Se han encontrado los Siguientes Errores: \n";

            if (string.IsNullOrEmpty(txtName.Text))
            {
                error += " -";
            }

            return error;
        }

        public bool existCustomer()
        {
            bool exist = false;
            ConnectOracle search = new ConnectOracle();
            int resp = Convert.ToInt16(search.DLookUp("count(*)", "customers", "UPPER(DNI)= '" + txtDNI.Text.ToUpper() + "' AND DELETED=0"));
            if (resp > 0)
            {
                exist = true;
            }
            return exist;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            bool email = true;
            if (!String.IsNullOrEmpty(txtEmail.Text)&& !Utils.check.checkEmail(txtEmail.Text))
            {
                email = false;
            }
            if (checkAdd() && email)
            {
                if (!existCustomer())
                {
                    MessageBox.Show("Dentro");
                }else
                {
                    MessageBox.Show("Existe DNI");
                }
                
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
