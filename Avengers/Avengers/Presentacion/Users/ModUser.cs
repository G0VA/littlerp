using Avengers.Dominio;
using Avengers.Dominio.Gestores;
using System;
using System.Data;
using System.Windows.Forms;

namespace Avengers.Presentacion.Users
{
    public partial class ModUser : Form
    {
        private string oldPass;
        private int refRol;
        private string usuario;

        public ModUser(string usuario)
        {
            this.usuario = usuario;
            oldPass = GestorUsers.getData("password", "usuario", "upper(name) = '" + usuario.ToUpper() + "'");
            InitializeComponent();
            lblUsuario.Text = usuario;
            initRole(" where deleted = 0");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do yo want to update this user's info?", "Update User", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Console.WriteLine(refRol);
                Console.WriteLine(usuario);
                Console.WriteLine(oldPass);
                Console.WriteLine(GestorUsers.GetMD5(txtOldPass.Text.ToString()));

                if (checkUpdate())
                {
                    String sql = updateSql();
                    GestorUsers.setData(sql);
                    Dispose();
                }
                else
                {
                    MessageBox.Show(errorDialog());
                }
            }
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

        private String errorDialog()
        {
            String error = " Some Errors have been found: \n";
            if (string.IsNullOrEmpty(txtOldPass.Text))
            {
                error += "\t - The field \"Old Password\" can't be empty. \n";
            }
            if (string.IsNullOrEmpty(txtNewPass.Text))
            {
                error += "\t - The field \"New Password\" can't be empty. \n";
            }
            if (string.IsNullOrEmpty(txtRepPass.Text))
            {
                error += "\t - The field \"Repeat Password\" can't be empty. \n";
            }
            if (string.IsNullOrEmpty(cmbRol.Text))
            {
                error += "\t - The field \"Role\" can't be empty. \n";
            }
            if (!GestorUsers.GetMD5(txtOldPass.Text).Equals(oldPass))
            {
                error += "\t - The old password is wrong. \n";
            }
            if (!txtNewPass.Text.Equals(txtRepPass))
            {
                error += "\t - New passwords don't match";
            }
            
            return error;
        }

        public String updateSql()
        {
            String sql = "update usuario set password = '" + GestorUsers.GetMD5(txtNewPass.Text) + "', ";
            sql += "refrol = " + refRol;
            sql += " where upper(name) = '" + usuario + "'";
            return sql;
        }

        private bool checkUpdate()
        {
            bool correct = true;
            if (string.IsNullOrEmpty(txtOldPass.Text))
            {
                correct = false;
            }
            if (string.IsNullOrEmpty(txtNewPass.Text))
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
            if (!txtNewPass.Text.Equals(txtRepPass.Text))
            {
                correct = false;
            }
            if (!oldPass.Equals(GestorUsers.GetMD5(txtOldPass.Text)))
            {
                correct = false;
            }
            return correct;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            refRol = Convert.ToInt16(GestorUsers.getData("idRol", "rol", "upper(name) = '" + cmbRol.SelectedItem.ToString().ToUpper() + "'"));
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            NewRole nr = new NewRole();
            nr.ShowDialog();
        }
    }
}