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
            this.usuario = usuario.ToUpper();
            oldPass = GestorUsers.getData("password", "usuario", "upper(name) = '" + usuario + "'");
            InitializeComponent();
            initRole("");
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do yo want to update this user's info?", "Update User", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
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
            if (!GestorUsers.GetMD5(txtOldPass.Text).Equals(oldPass))
            {
                error += "\t - The old password is wrong.";
            }
            if (txtNewPass.Text.Equals(txtRepPass))
            {
                error += "\t - The new passwords don't match";
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
            return oldPass.Equals(GestorUsers.GetMD5(txtOldPass.Text)) && txtNewPass.Text.Equals(txtRepPass.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string condition = "refrol = (select idrol from rol where name = '" + cmbRol.SelectedItem.ToString().ToUpper() + "')";
            refRol = Convert.ToInt16(GestorUsers.getData("refRol", "usuario", condition));
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            NewRole nr = new NewRole();
            nr.ShowDialog();
        }
    }
}