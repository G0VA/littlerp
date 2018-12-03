using System;
using System.Data;
using System.Windows.Forms;
using Avengers.Dominio;
using Avengers.Dominio.Gestores;

namespace Avengers.Presentacion.Users
{
    public partial class NewUser : Form
    {
        private int refRol;

        public NewUser()
        {
            InitializeComponent();
            initRole("");
        }

        public void initRole(String condition)
        {
            User u = new User();
            u.gestor().readInDB("NAME", "ROL", condition);
            DataTable tRole = u.gestor().getUsers();
            cmbRol.Items.Clear();
            
            foreach (DataRow row in tRole.Rows)
            {
                cmbRol.Items.Add(row["NAME"]);
            }
        }

        private bool checkAdd()
        {
            return !(string.IsNullOrEmpty(txtUser.Text) && string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrEmpty(txtRepPass.Text)) && !GestorUsers.existsUser(txtUser.Text) && txtPassword.Text.Equals(txtRepPass.Text);
        }

        private String errorDialog()
        {
            String error = "Some Errors have been found: \n";

            if (string.IsNullOrEmpty(txtUser.Text))
            {
                error += "\t - The field \"User\" can't be empty. \n";
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                error += "\t - The field \"Password\" can't be empty. \n";
            }
            if (string.IsNullOrEmpty(txtRepPass.Text))
            {
                error += "\t - The field \"Repeat Password\" can't be empty. \n";
            }            
            if (GestorUsers.existsUser(txtUser.Text))
            {
                error += "\t - This user already exists.";
            }
            if (!txtPassword.Text.Equals(txtRepPass.Text))
            {
                Console.WriteLine(txtPassword.Text);
                Console.WriteLine(txtRepPass.Text);
                error += "\t - The passwords don't match.";
            }
            return error;
        }

        public String insertSql()
        {
            String sql = "insert into usuario values (null,'" + txtUser.Text.ToUpper() + "','" + GestorUsers.GetMD5(txtPassword.Text.ToUpper()) + "',";
            sql += "0," + this.refRol + ")";
            return sql;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkAdd())
            {
                String sql = insertSql();
                GestorUsers.insertUser(sql);
                Dispose();
            }
            else
            {
                MessageBox.Show(errorDialog());
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string condition = "refrol = (select idrol from rol where name = '" + cmbRol.SelectedItem.ToString().ToUpper() + "')";
            refRol = Convert.ToInt16(GestorUsers.getData("refRol", "usuario", condition));
        }

        private void clean()
        {
            txtUser.Clear();
            txtPassword.Clear();
            txtRepPass.Clear();
            initRole("");
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (checkAdd())
            {
                String sql = insertSql();
                GestorCustomers.insertCustomer(sql);
                clean();
            }
            else
            {
                MessageBox.Show(errorDialog());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            NewRole nr = new NewRole();
            nr.ShowDialog();
        }
    }
}