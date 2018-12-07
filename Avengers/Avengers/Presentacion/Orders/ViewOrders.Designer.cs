namespace Avengers.Presentacion.Orders
{
    partial class ViewOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.comboPay = new System.Windows.Forms.ComboBox();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.chkDeleted = new System.Windows.Forms.CheckBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ckAct = new System.Windows.Forms.CheckBox();
            this.txtPrepaid = new System.Windows.Forms.TextBox();
            this.lblPrepago = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(48, 52);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(77, 16);
            this.lblCustomers.TabIndex = 0;
            this.lblCustomers.Text = "Customer:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(48, 94);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 16);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(142, 51);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtCustomer.TabIndex = 2;
            this.txtCustomer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyUp);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(142, 93);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 3;
            this.txtUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyUp);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(276, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(276, 94);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(127, 16);
            this.lblPay.TabIndex = 5;
            this.lblPay.Text = "Payment Method:";
            // 
            // comboPay
            // 
            this.comboPay.FormattingEnabled = true;
            this.comboPay.Location = new System.Drawing.Point(429, 93);
            this.comboPay.Name = "comboPay";
            this.comboPay.Size = new System.Drawing.Size(121, 21);
            this.comboPay.TabIndex = 6;
            this.comboPay.SelectedValueChanged += new System.EventHandler(this.comboPay_SelectedValueChanged);
            // 
            // dateOrder
            // 
            this.dateOrder.Enabled = false;
            this.dateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOrder.Location = new System.Drawing.Point(429, 49);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(119, 20);
            this.dateOrder.TabIndex = 7;
            this.dateOrder.ValueChanged += new System.EventHandler(this.dateOrder_ValueChanged);
            this.dateOrder.BindingContextChanged += new System.EventHandler(this.dateOrder_BindingContextChanged);
            // 
            // chkDeleted
            // 
            this.chkDeleted.AutoSize = true;
            this.chkDeleted.Location = new System.Drawing.Point(645, 49);
            this.chkDeleted.Name = "chkDeleted";
            this.chkDeleted.Size = new System.Drawing.Size(63, 17);
            this.chkDeleted.TabIndex = 8;
            this.chkDeleted.Text = "Deleted";
            this.chkDeleted.UseVisualStyleBackColor = true;
            this.chkDeleted.CheckedChanged += new System.EventHandler(this.chkDeleted_CheckedChanged);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(780, 50);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 10;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(12, 143);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(982, 332);
            this.dgvOrders.TabIndex = 11;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(1024, 245);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1024, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(1024, 335);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(88, 23);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(1024, 380);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 15;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // ckAct
            // 
            this.ckAct.AutoSize = true;
            this.ckAct.Location = new System.Drawing.Point(555, 50);
            this.ckAct.Name = "ckAct";
            this.ckAct.Size = new System.Drawing.Size(65, 17);
            this.ckAct.TabIndex = 16;
            this.ckAct.Text = "Activate";
            this.ckAct.UseVisualStyleBackColor = true;
            this.ckAct.CheckedChanged += new System.EventHandler(this.ckAct_CheckedChanged);
            // 
            // txtPrepaid
            // 
            this.txtPrepaid.Location = new System.Drawing.Point(725, 93);
            this.txtPrepaid.Name = "txtPrepaid";
            this.txtPrepaid.Size = new System.Drawing.Size(100, 20);
            this.txtPrepaid.TabIndex = 17;
            this.txtPrepaid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrepaid_KeyUp);
            // 
            // lblPrepago
            // 
            this.lblPrepago.AutoSize = true;
            this.lblPrepago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrepago.Location = new System.Drawing.Point(658, 94);
            this.lblPrepago.Name = "lblPrepago";
            this.lblPrepago.Size = new System.Drawing.Size(61, 15);
            this.lblPrepago.TabIndex = 18;
            this.lblPrepago.Text = "Prepaid:";
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 485);
            this.Controls.Add(this.lblPrepago);
            this.Controls.Add(this.txtPrepaid);
            this.Controls.Add(this.ckAct);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.chkDeleted);
            this.Controls.Add(this.dateOrder);
            this.Controls.Add(this.comboPay);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewOrders";
            this.Text = "ViewOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.ComboBox comboPay;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.CheckBox chkDeleted;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnLog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox ckAct;
        private System.Windows.Forms.TextBox txtPrepaid;
        private System.Windows.Forms.Label lblPrepago;
    }
}