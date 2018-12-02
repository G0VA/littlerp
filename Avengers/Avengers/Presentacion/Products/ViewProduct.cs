using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avengers.Dominio;
using Avengers.Dominio.Gestores;
using Avengers.Presentacion.Orders;

namespace Avengers.Presentacion.Products
{
    public partial class ViewProduct : Form
    {
        NewOrder observer = null;
        public ViewProduct()
        {
            InitializeComponent();
            initTable("Where Deleted = 0");
            initComboEditorial("Where Deleted = 0");
            initComboGender("Where Deleted = 0");
        }
        public ViewProduct(NewOrder newOrder)
        {
            this.observer = newOrder;
            InitializeComponent();
            initTable("Where Deleted = 0");
            initComboEditorial("Where Deleted = 0");
            initComboGender("Where Deleted = 0");
        }

        private void initComboEditorial(String cond)
        {
            Product p = new Product();
            p.getGestor().readInProductV3(cond, "EDITORIAL", "EDITORIAL");
            DataTable tproduct = p.getGestor().getProducts();
            comboEditorial.Items.Clear();
            foreach (DataRow row in tproduct.Rows)
            {
                comboEditorial.Items.Add(row["EDITORIAL"]);

            }
        }
        private void initComboGender(String cond)
        {
            Product p = new Product();
            p.getGestor().readInProductV3(cond, "GENDER", "GENDER");
            DataTable tproduct = p.getGestor().getProducts();
            comboGender.Items.Clear();
            foreach (DataRow row in tproduct.Rows)
            {

                comboGender.Items.Add(row["GENDER"]);

            }
        }
        private void initTable(String cond)
        {
            dgvProduct.Columns.Clear();

            Product p = new Product();
            p.getGestor().readProducts(cond);


            DataTable tproducts = p.getGestor().getProducts();
            dgvProduct.Columns.Clear();

            //dgvCustomers.DataSource = tcustomers;


            dgvProduct.Columns.Add("IDPRODUCT", "ID");
            dgvProduct.Columns.Add("GENDER", "GENDER");
            dgvProduct.Columns.Add("EDITORIAL", "EDITORIAL");
            dgvProduct.Columns.Add("PRICE", "PRICE €");
            dgvProduct.Columns.Add("NAME", "NAME");
            dgvProduct.Columns.Add("DESCRIPTION", "DESCRIPTION");
            dgvProduct.Columns.Add("STOCK", "STOCK");


            foreach (DataRow row in tproducts.Rows)
            {
                dgvProduct.Rows.Add(row["IDPRODUCT"], row["GENDER"], row["EDITORIAL"], row["PRICE"], row["NAME"], row["DESCRIPTION"], row["STOCK"]);
            }
            dgvProduct.Columns["IDPRODUCT"].Visible = false;

        }
        public void filtrar()
        {
            String sql = "Where 1=1";
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                sql += " And Upper(Name) like '%" + txtName.Text.ToUpper() + "%' ";
            }

            if (comboEditorial.SelectedIndex != -1)
            {
                sql += " And Upper(Editorial) = Upper('" + comboEditorial.SelectedItem.ToString() + "')";
            }
            if (comboGender.SelectedIndex != -1)
            {
                sql += " And Upper(Gender) = Upper('" + comboGender.SelectedItem.ToString() + "')";
            }
            if (chckDelete.Checked)
            {
                sql += " And deleted = 1";
            }
            if (!chckDelete.Checked)
            {
                sql += " And deleted = 0";
            }
            if (rbtnAscend.Checked)
            {
                sql += " ORDER BY PRICE ASC";
            }
            if (rbtnDescend.Checked)
            {
                sql += " ORDER BY PRICE DESC";
            }
            initTable(sql);
        }



        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void comboEditorial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filtrar();
        }

        private void comboGender_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filtrar();
        }

        private void rbtnDescend_CheckedChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void rbtnAscend_CheckedChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewProduct np = new NewProduct();
            np.ShowDialog();
            if (np.IsDisposed)
            {
                initTable("Where Deleted = 0");
                comboEditorial.Items.Clear();
                comboGender.Items.Clear();
                initComboEditorial("Where Deleted = 0");
                initComboGender("Where Deleted = 0");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            
            txtName.Text = "";
            comboGender.Items.Clear();
            comboEditorial.Items.Clear();
            initComboGender("Where Deleted = 0");
            initComboEditorial("Where Deleted = 0");
            if (chckDelete.Checked) {
                chckDelete.Checked = false;
            }
            this.groupBox1.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) =>
            {
                rbtnAscend.Checked = false;
                rbtnDescend.Checked = false;
            });
            initTable("Where Deleted = 0");
        }

        

        private void chckDelete_CheckedChanged(object sender, EventArgs e)
        {
            filtrar();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            String valor = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[0].Value.ToString();
            if (!GestorProducts.existProductOrders(valor))
            {
                if (MessageBox.Show("Do yo Want Delete this Product ?", "Delete Product", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String sql = "update products set Deleted=1 where idproduct =" + valor;
                    GestorProducts.deleteProduct(sql);
                    initTable(" Where Deleted=0");
                }

            }
            else
            {
                MessageBox.Show("This Product is in Orders in DB");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyProduct mp = new ModifyProduct();
            
            String id = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[0].Value.ToString();
            String gender = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[1].Value.ToString();
            String editorial = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[2].Value.ToString();
            String precio = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[3].Value.ToString();
            String name = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[4].Value.ToString();
            String description = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[5].Value.ToString();
            String stock = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[6].Value.ToString();
            
            if (!GestorProducts.existProductOrders(id))
            {
                
                mp.id = id;
                mp.comboGender.SelectedItem = gender;
                mp.comboEditorial.SelectedItem = editorial;
                mp.txtPrice.Text = precio;
                mp.txtName.Text = name;
                mp.txtDescription.Text = description;
                mp.txtStock.Text = stock;
                mp.ShowDialog();

            }
            else
            {
                MessageBox.Show("This Product is in Orders in DB");
            }
            if (mp.IsDisposed)
            {
                initTable("Where Deleted = 0");
                comboEditorial.Items.Clear();
                comboGender.Items.Clear();
                initComboEditorial("Where Deleted = 0");
                initComboGender("Where Deleted = 0");
            }


        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = (dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[0].Value.ToString()==null)?"": dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[0].Value.ToString();
            String gender =( dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[1].Value.ToString() == null)?"": dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[1].Value.ToString();
            String editorial =( dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[2].Value.ToString() == null)?"": dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[2].Value.ToString();
            String precio = (dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[3].Value.ToString() == null)?"": dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[3].Value.ToString();
            String name = (dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[4].Value.ToString() == null)?"": dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[4].Value.ToString();
            String description = (dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[5].Value.ToString() == null)?"": dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[5].Value.ToString();
            String stock = (dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[6].Value.ToString() == null)?"": dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[6].Value.ToString();

            DtoProduct dtoProduct = new DtoProduct(id, gender, editorial, precio, name, description, stock);

            if (observer != null)
            {
                observer.updateProduct(dtoProduct);
                Dispose();
            }
        }
    }
}
