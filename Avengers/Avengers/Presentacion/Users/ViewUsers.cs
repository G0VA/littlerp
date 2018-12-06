using Avengers.Dominio;
using Avengers.Dominio.Gestores;
using Avengers.Presentacion.Users;
using System;
using System.Data;
using System.Windows.Forms;

namespace Avengers.Presentacion
{
    public partial class ViewUsers : Form
    {
        private string idioma;

        public ViewUsers(String idioma)
        {
            this.idioma = idioma;
            InitializeComponent();
            initTable("where us.deleted = 0");            
            if (this.idioma == "ESPAÑOL")
            {
                idioma_es();
            }
            else if (this.idioma == "INGLES")
            {
                idioma_en();
            }
        }

        public void idioma_es()
        {
            lblName.Text = Recursos.Espanol.lblName;
            ckDel.Text = Recursos.Espanol.ckDel;
            btnClean.Text = Recursos.Espanol.btnClean;
            btnNewUser.Text = Recursos.Espanol.btnNewUser;
            btnDeleteUser.Text = Recursos.Espanol.btnDeleteUser;
            btnModUser.Text = Recursos.Espanol.btnModUser;
            lblRol.Text = Recursos.Espanol.lblRol;
        }
        public void idioma_en()
        {
            lblName.Text = Recursos.Ingles.lblName;
            ckDel.Text = Recursos.Ingles.ckDel;
            btnClean.Text = Recursos.Ingles.btnClean;
            btnNewUser.Text = Recursos.Ingles.btnNewUser;
            btnDeleteUser.Text = Recursos.Ingles.btnDeleteUser;
            btnModUser.Text = Recursos.Ingles.btnModUser;
            lblRol.Text = Recursos.Ingles.lblRol;
        }
        private void initTable(String condition)
        {
            dgvUsers.Columns.Clear();

            User u = new User();
            u.gestor().readUsersRoles(condition);

            DataTable tUsers = u.gestor().getUsers();
            dgvUsers.Columns.Clear();
            if (this.idioma == "ESPAÑOL")
            {
                dgvUsers.Columns.Add("NAME", "NOMBRE");
                dgvUsers.Columns.Add("ROLE", "ROL");
            }
            else
            {
                dgvUsers.Columns.Add("NAME", "NAME");
                dgvUsers.Columns.Add("ROLE", "ROLE");
            }
            

            foreach (DataRow row in tUsers.Rows)
            {
                dgvUsers.Rows.Add(row["NAME"], row["ROLE"]);
            }
        }

        public void filtrar()
        {
            String sql = "where 1=1";

            if (!String.IsNullOrEmpty(txtName.Text))
            {
                sql += " and Upper(us.name) like '%" + txtName.Text.ToUpper() + "%'";
            }
            if (!String.IsNullOrEmpty(txtRole.Text))
            {
                sql += " and upper(ro.name) like '%" + txtRole.Text.ToUpper() + "%'";
            }
            if (!ckDel.Checked)
            {
                sql += " and us.deleted = 0";
            }
            initTable(sql);
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser(this.idioma);
            nu.ShowDialog();
            if (nu.IsDisposed)
            {
                initTable("where us.deleted = 0");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtRole.Clear();
            ckDel.Checked = false;
            initTable("where us.deleted = 0");
        }

        private void ckDel_CheckedChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void txtName_KeyUp_1(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void txtRole_KeyUp_1(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String usuario = dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[0].Value.ToString();
            if(this.idioma == "ESPAÑOL")
            {
                if (MessageBox.Show("¿Estas seguro de eliminar el usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String sql = "update usuario set deleted=1 where upper(name) ='" + usuario.ToUpper() + "'";
                    GestorUsers.delUser(sql);
                    initTable(" where us.deleted = 0");
                }
            }
            else
            {
                if (MessageBox.Show("Do yo want to delete this user?", "Delete User", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String sql = "update usuario set deleted=1 where upper(name) ='" + usuario.ToUpper() + "'";
                    GestorUsers.delUser(sql);
                    initTable(" where us.deleted = 0");
                }
            }
                
        }

        private void btnModUser_Click(object sender, EventArgs e)
        {
            string usuario = dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[0].Value.ToString();
            ModUser mu = new ModUser(usuario,this.idioma);
            mu.ShowDialog();
            if (mu.IsDisposed)
            {
                initTable(" where us.deleted =0");
            }
        }
    }
}