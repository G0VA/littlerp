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
            initRole(" where deleted = 0");
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
            bool correct = true;
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                correct = false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                correct = false;
            }
            if (string.IsNullOrEmpty(txtRepPass.Text))
            {
                correct = false;
            }
            if (string.IsNullOrEmpty(cmbRol.Text))
            {
                correct = false;
            }
            if (!txtPassword.Text.Equals(txtRepPass.Text))
            {
                correct = false;
            }
            if (GestorUsers.existsUser(txtUser.Text))
            {
                correct = false;
            }
            return correct;
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
            if (string.IsNullOrEmpty(cmbRol.Text))
            {
                error += "\t - The field \"Role\" can't be empty. \n";
            }
            if (GestorUsers.existsUser(txtUser.Text))
            {
                error += "\t - This user already exists. \n";
            }
            if (!txtPassword.Text.Equals(txtRepPass.Text))
            {
                error += "\t - Passwords do not match.";
            }
            return error;
        }

        public String insertSql()
        {
            String sql = "insert into usuario values (null,'" + txtUser.Text.ToUpper() + "','" + GestorUsers.GetMD5(txtPassword.Text) + "',";
            sql += "0," + refRol + ")";
            return sql;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkAdd())
            {
                String sql = insertSql();
                GestorUsers.insertUser(sql);
                Console.WriteLine(GestorUsers.GetMD5(txtPassword.Text));
                Dispose();
            }
            else
            {
                MessageBox.Show(errorDialog());
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            refRol = Convert.ToInt16(GestorUsers.getData("idRol", "rol", "upper(name) = '" + cmbRol.SelectedItem.ToString().ToUpper() + "'"));
        }

        private void clean()
        {
            txtUser.Clear();
            txtPassword.Clear();
            txtRepPass.Clear();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (checkAdd())
            {
                String sql = insertSql();
                GestorUsers.insertUser(sql);
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