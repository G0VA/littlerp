using Avengers.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avengers.Presentacion.Users
{
    public partial class NewRole : Form
    {
        public NewRole()
        {
            InitializeComponent();
            initListBox(" where deleted = 0");
        }

        private void initListBox(String condition)
        {

            User u = new User();
            u.gestor().readPermits(condition);

            DataTable tPermits = u.gestor().getUsers();

            lbxPermissionList.DataSource = tPermits;
            lbxPermissionList.DisplayMember = "Name";
            lbxPermissionList.ValueMember = "NAME";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            while (lbxSelectedPerm.Items.Count > 0)
            {
                lbxPermissionList.Items.Add(lbxSelectedPerm.Items[0]);
                lbxSelectedPerm.Items.Remove(lbxSelectedPerm.Items[0]);
            }
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            lbxSelectedPerm.Items.Add(lbxPermissionList.SelectedItem);
            lbxPermissionList.Items.Remove(lbxPermissionList.SelectedItem);
        }

        private void btnRemoveOne_Click(object sender, EventArgs e)
        {
            while (lbxSelectedPerm.SelectedIndices.Count > 0)
            {
                lbxPermissionList.Items.Add(lbxSelectedPerm.SelectedItems[0]);
                lbxSelectedPerm.Items.Remove(lbxSelectedPerm.SelectedItems[0]);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            while (lbxPermissionList.Items.Count > 0)
            {
                lbxSelectedPerm.Items.Add(lbxPermissionList.Items[0]);
                lbxPermissionList.Items.Remove(lbxPermissionList.Items[0]);
            }
        }
    }
}