using Avengers.Dominio;
using Avengers.Presentacion.Users;
using System;
using System.Data;
using System.Windows.Forms;

namespace Avengers.Presentacion
{
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
            initTable(" Where Deleted = 0");
        }

        private void initTable(String condition)
        {
            dgvUsers.Columns.Clear();

            User u = new User();
            u.gestor().readUsers(condition);


            DataTable tUsers = u.gestor().getUsers();
            dgvUsers.Columns.Clear();

            //dgvCustomers.DataSource = tcustomers;

            dgvUsers.Columns.Add("IDUSER", "ID");
            dgvUsers.Columns.Add("NAME", "NAME");
            dgvUsers.Columns.Add("REFROL", "ROLE");


            foreach (DataRow row in tUsers.Rows)
            {
                dgvUsers.Rows.Add(row["IDUSER"], row["NAME"], row["REFROL"]);
            }

        }

        public void filtrar()
        {
            String sql = " Where 1=1";

            if (!String.IsNullOrEmpty(txtName.Text))
            {
                sql += " And Upper(Name) like '%" + txtName.Text.ToUpper() + "%' ";
            }
            if (!String.IsNullOrEmpty(txtRole.Text))
            {
                sql += " And upper(Surname) like '%" + txtRole.Text.ToUpper() + "%'";
            }

            initTable(sql);
        }
        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser();
            nu.ShowDialog();
        }

    }
}
