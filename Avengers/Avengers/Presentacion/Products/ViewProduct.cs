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
        ModOrder observerMod = null;
        private String idioma;
        public ViewProduct(String idioma)
        {
            this.idioma = idioma;
            InitializeComponent();
            initTable("Where Deleted = 0");
            initComboEditorial("Where Deleted = 0");
            initComboGender("Where Deleted = 0");          
            if (this.idioma == "ESPAÑOL")
            {
                idioma_es();
                this.Text = "Productos";
            }
            else if (this.idioma == "INGLES")
            {
                idioma_en();
                this.Text = "Products";
            }
        }

        public ViewProduct(NewOrder newOrder, String idioma)
        {
            this.idioma = idioma;
            this.observer = newOrder;
            InitializeComponent();
            initTable("Where Deleted = 0");
            initComboEditorial("Where Deleted = 0");
            initComboGender("Where Deleted = 0");          
            if (this.idioma == "ESPAÑOL")
            {
                idioma_es();
                this.Text = "Productos";
            }
            else if (this.idioma == "INGLES")
            {
                idioma_en();
                this.Text = "Products";
            }
        }
        public ViewProduct(ModOrder modOrder, String idioma)
        {
            this.idioma = idioma;
            this.observerMod = modOrder;
            InitializeComponent();
            initTable("Where Deleted = 0");
            initComboEditorial("Where Deleted = 0");
            initComboGender("Where Deleted = 0");
            if (this.idioma == "ESPAÑOL")
            {
                idioma_es();
                this.Text = "Productos";
            }
            else if (this.idioma == "INGLES")
            {
                idioma_en();
                this.Text = "Products";
            }
        }
        public void idioma_es()
        {
            label1.Text = Avengers.Recursos.Espanol.lblName;
            label2.Text = Avengers.Recursos.Espanol.label2;
            label3.Text = Avengers.Recursos.Espanol.label3;
            label4.Text = Avengers.Recursos.Espanol.label4;
            rbtnAscend.Text = Avengers.Recursos.Espanol.rbtnAscend;
            rbtnDescend.Text = Avengers.Recursos.Espanol.rbtnDescend;
            chckDelete.Text = Avengers.Recursos.Espanol.ckDel;
            btnClean.Text = Avengers.Recursos.Espanol.btnClean;
            btnAdd.Text = Avengers.Recursos.Espanol.btnNewUser;
            btnDelete.Text = Avengers.Recursos.Espanol.btnDeleteUser;
            btnModify.Text = Avengers.Recursos.Espanol.btnModUser;
        }
        public void idioma_en()
        {
            label1.Text = Avengers.Recursos.Ingles.lblName;
            label2.Text = Avengers.Recursos.Ingles.label2;
            label3.Text = Avengers.Recursos.Ingles.label3;
            label4.Text = Avengers.Recursos.Ingles.label4;
            rbtnAscend.Text = Avengers.Recursos.Ingles.rbtnAscend;
            rbtnDescend.Text = Avengers.Recursos.Ingles.rbtnDescend;
            chckDelete.Text = Avengers.Recursos.Ingles.ckDel;
            btnClean.Text = Avengers.Recursos.Ingles.btnClean;
            btnAdd.Text = Avengers.Recursos.Ingles.btnNewUser;
            btnDelete.Text = Avengers.Recursos.Ingles.btnDeleteUser;
            btnModify.Text = Avengers.Recursos.Ingles.btnModUser;
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

            if (this.idioma == "ESPAÑOL")
            {
                dgvProduct.Columns.Add("IDPRODUCT", "ID");
                dgvProduct.Columns.Add("GENDER", "GENERO");
                dgvProduct.Columns.Add("EDITORIAL", "EDITORIAL");
                dgvProduct.Columns.Add("PRICE", "PRECIO €");
                dgvProduct.Columns.Add("NAME", "NOMBRE");
                dgvProduct.Columns.Add("DESCRIPTION", "DESCRIPCIÓN");
                dgvProduct.Columns.Add("STOCK", "STOCK");
            }
            else
            {
                dgvProduct.Columns.Add("IDPRODUCT", "ID");
                dgvProduct.Columns.Add("GENDER", "GENDER");
                dgvProduct.Columns.Add("EDITORIAL", "EDITORIAL");
                dgvProduct.Columns.Add("PRICE", "PRICE €");
                dgvProduct.Columns.Add("NAME", "NAME");
                dgvProduct.Columns.Add("DESCRIPTION", "DESCRIPTION");
                dgvProduct.Columns.Add("STOCK", "STOCK");
            }
            


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
            NewProduct np = new NewProduct(this.idioma);
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
            try
            {
                String valor = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[0].Value.ToString();
                if (!GestorProducts.existProductOrders(valor))
                {
                    if (this.idioma == "ESPAÑOL")
                    {
                        if (MessageBox.Show("¿Quieres eliminar este producto?", "Eliminar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            String sql = "update products set Deleted=1 where idproduct =" + valor;
                            GestorProducts.deleteProduct(sql);
                            initTable(" Where Deleted=0");
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Do yo Want Delete this Product ?", "Delete Product", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            String sql = "update products set Deleted=1 where idproduct =" + valor;
                            GestorProducts.deleteProduct(sql);
                            initTable(" Where Deleted=0");
                        }
                    }
                    

                }
                else
                {
                    if (this.idioma == "ESPAÑOL")
                    {
                        MessageBox.Show("Este producto está en pedidos en DB");
                    }
                    else
                    {
                        MessageBox.Show("This Product is in Orders in DB");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                if (this.idioma == "ESPAÑOL")
                {
                    MessageBox.Show("No hay ninguna fila seleccionada");
                }
                else
                {
                    MessageBox.Show("Unselected any row");
                }
                
            }
        }
            
       

    private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                ModifyProduct mp = new ModifyProduct(this.idioma);

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
                    if (this.idioma == "ESPAÑOL")
                    {
                        MessageBox.Show("Este producto está en pedidos en DB");
                    }
                    else
                    {
                        MessageBox.Show("This Product is in Orders in DB");
                    }
                    
                }
                if (mp.IsDisposed)
                {
                    initTable("Where Deleted = 0");
                    comboEditorial.Items.Clear();
                    comboGender.Items.Clear();
                    initComboEditorial("Where Deleted = 0");
                    initComboGender("Where Deleted = 0");
                }
            }catch(Exception ex)
            {
                if (this.idioma == "ESPAÑOL")
                {
                    MessageBox.Show("No hay ninguna fila seleccionada");
                }
                else
                {
                    MessageBox.Show("Unselected any row");
                }
                    
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
            if (observerMod != null)
            {
                observerMod.updateProduct(dtoProduct);
                Dispose();
            }

        }


    }
}
