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

namespace Avengers.Presentacion.Orders
{
    public partial class ViewOrders : Form
    {
        private User u;
        private String idioma;
        String condicion = "SELECT ORDERS.IDORDER,CUSTOMERS.NAME,CUSTOMERS.SURNAME,USUARIO.NAME,ORDERS.DATETIME,PAYMENTMETHODS.PAYMENTMETHOD, ORDERS.TOTAL, ORDERS.PREPAID FROM ORDERS INNER JOIN CUSTOMERS ON REFCUSTOMER = IDCUSTOMER INNER JOIN USUARIO ON REFUSER = IDUSER INNER JOIN PAYMENTMETHODS ON REFPAYMENTMETHOD = IDPAYMENTMETHOD ";
        String whereCondition = " Where Orders.Deleted=";
        public ViewOrders(User u,String idioma)
        {
            this.idioma = idioma;
            this.u = u;
            InitializeComponent();
            bool checkValue = chkDeleted.Checked;
            int iValue = (checkValue) ? 1 : 0;
            initTable(condicion + whereCondition + iValue);
            initComboPayment("Where Deleted = 0");          
            if (this.idioma == "ESPAÑOL")
            {
                idioma_es();
                this.Text = "Pedidos";
            }
            else if (this.idioma == "INGLES")
            {
                idioma_en();
                this.Text = "Orders";
            }
        }

        public void idioma_es()
        {
            lblCustomers.Text = Avengers.Recursos.Espanol.lblCustomer;
            lblUser.Text = Avengers.Recursos.Espanol.lblUser;
            lblDate.Text = Avengers.Recursos.Espanol.lblDate;
            lblPay.Text = Avengers.Recursos.Espanol.lblPay;
            ckAct.Text = Avengers.Recursos.Espanol.ckAct;
            chkDeleted.Text = Avengers.Recursos.Espanol.ckDel;
            lblPrepago.Text = Avengers.Recursos.Espanol.lblPrepago;
            btnClean.Text = Avengers.Recursos.Espanol.btnClean;
            btnNew.Text = Avengers.Recursos.Espanol.btnNewUser;
            btnDelete.Text = Avengers.Recursos.Espanol.btnDeleteUser;
            btnModify.Text = Avengers.Recursos.Espanol.btnModUser;
        }
        public void idioma_en()
        {
            lblCustomers.Text = Avengers.Recursos.Ingles.lblCustomer;
            lblUser.Text = Avengers.Recursos.Ingles.lblUser;
            lblDate.Text = Avengers.Recursos.Ingles.lblDate;
            lblPay.Text = Avengers.Recursos.Ingles.lblPay;
            ckAct.Text = Avengers.Recursos.Ingles.ckAct;
            chkDeleted.Text = Avengers.Recursos.Ingles.ckDel;
            lblPrepago.Text = Avengers.Recursos.Ingles.lblPrepago;
            btnClean.Text = Avengers.Recursos.Ingles.btnClean;
            btnNew.Text = Avengers.Recursos.Ingles.btnNewUser;
            btnDelete.Text = Avengers.Recursos.Ingles.btnDeleteUser;
            btnModify.Text = Avengers.Recursos.Ingles.btnModUser;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewOrder o = new NewOrder(u,this.idioma);
            o.Show();
        }

        private void initTable(String cond)
        {
            
            dgvOrders.Columns.Clear();

            Order o = new Order();
            o.getGestor().readInDB2(cond);


            DataTable torders = o.getGestor().getOrders();
            dgvOrders.Columns.Clear();

            if (this.idioma == "ESPAÑOL")
            {
                dgvOrders.Columns.Add("IDORDER", "ID");
                dgvOrders.Columns.Add("REFCUSTOMER", "NOMBRE CLIENTE");
                dgvOrders.Columns.Add("REFCUSTOMER", "APELLIDO CLIENTE");
                dgvOrders.Columns.Add("REFUSER", "USUARIO");
                dgvOrders.Columns.Add("DATETIME", "FECHA");
                dgvOrders.Columns.Add("REFPAYMENTMETHOD", "FORMA DE PAGO");
                dgvOrders.Columns.Add("TOTAL", "TOTAL");
                dgvOrders.Columns.Add("PREPAID", "PAGADO");
            }
            else
            {
                dgvOrders.Columns.Add("IDORDER", "ID");
                dgvOrders.Columns.Add("REFCUSTOMER", "NAME CUSTOMER");
                dgvOrders.Columns.Add("REFCUSTOMER", "SURNAME CUSTOMER");
                dgvOrders.Columns.Add("REFUSER", "USER");
                dgvOrders.Columns.Add("DATETIME", "DATE");
                dgvOrders.Columns.Add("REFPAYMENTMETHOD", "PAYMENTMETHOD");
                dgvOrders.Columns.Add("TOTAL", "TOTAL");
                dgvOrders.Columns.Add("PREPAID", "PREPAID");
            }

            


            foreach (DataRow row in torders.Rows)
            {
                
                dgvOrders.Rows.Add(row["IDORDER"], row["NAME"], row["SURNAME"],row.ItemArray[3], row["DATETIME"], row["PAYMENTMETHOD"], row["TOTAL"], row["PREPAID"]);
            }
            dgvOrders.Columns["IDORDER"].Visible = false;

        }
        private void initComboPayment(String cond)
        {
            Order o = new Order();
            o.getGestor().readInDB(" PAYMENTMETHOD", "PAYMENTMETHODS", cond);
            DataTable torder = o.getGestor().getOrders();
            comboPay.Items.Clear();

            foreach (DataRow row in torder.Rows)
            {
                comboPay.Items.Add(row["PAYMENTMETHOD"]);


            }
        }
        public void filtrar()
        {
            String sql = " ";

            if (!String.IsNullOrEmpty(txtCustomer.Text))
            {
                sql+= " And refcustomer in(Select idcustomer from customers where upper(name) like '%"+txtCustomer.Text.ToUpper()+"%' or upper(surname) like '%"+txtCustomer.Text.ToUpper()+"%')";
            }
            if (!String.IsNullOrEmpty(txtUser.Text))
            {
                sql += " And refuser in(Select iduser from usuario where Upper(name) like '%"+ txtUser.Text.ToUpper()+ "%')";
            }
            if (dateOrder.Enabled==true && !String.IsNullOrEmpty(dateOrder.Text)){
                sql += " And datetime =to_date('" + dateOrder.Text + "','dd/MM/yyyy')";
            }
            if (comboPay.SelectedIndex != -1)
            {
                sql += "and refpaymentmethod In(Select idpaymentmethod from paymentmethods where paymentmethod= '" + comboPay.SelectedItem.ToString() + "')";
            }
            if (!String.IsNullOrEmpty(txtPrepaid.Text))
            {
                sql += " and prepaid='" + txtPrepaid.Text + "'";
            }

            bool checkValue = chkDeleted.Checked;
            int ivalue = (checkValue) ? 1 : 0;
            initTable(this.condicion + whereCondition + ivalue + sql);

        }

        private void txtCustomer_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void txtUser_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void dateOrder_ValueChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void dateOrder_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void ckAct_CheckedChanged(object sender, EventArgs e)
        {
            dateOrder.Enabled = ckAct.Checked;
        }

        private void comboPay_SelectedValueChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void chkDeleted_CheckedChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void txtPrepaid_KeyUp(object sender, KeyEventArgs e)
        {
            filtrar();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCustomer.Text = null;
            txtUser.Text = null;
            txtPrepaid.Text = null;
            ckAct.Checked = false;
            comboPay.SelectedIndex = -1;
            chkDeleted.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String id= dgvOrders.Rows[dgvOrders.CurrentRow.Index].Cells[0].Value.ToString();
            String sql = "Update orders set Deleted=1 where idorder=" + id;

            if (this.idioma == "ESPAÑOL")
            {
                if(MessageBox.Show("¿Quieres eliminar a este pedido?", "Eliminar Pedido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    GestorOrders.deleteOrder(sql);
                    initTable(condicion + whereCondition + 0);
                }
            }
            else
            {
                if(MessageBox.Show("Do you want Delete this Order?", "Delete Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    GestorOrders.deleteOrder(sql);
                    initTable(condicion + whereCondition + 0);
                }
            }
        }
    }
}
