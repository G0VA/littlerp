namespace Avengers.Presentacion.Orders
{
    partial class ModOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModOrder));
            this.lblPayMethod = new System.Windows.Forms.Label();
            this.cmbPay = new System.Windows.Forms.ComboBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnFindCust = new System.Windows.Forms.Button();
            this.btnFindProd = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.dgvModOrder = new System.Windows.Forms.DataGridView();
            this.txtPrepaid = new System.Windows.Forms.TextBox();
            this.lblPrepaid = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblPricesale = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNumeroOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.AutoSize = true;
            this.lblPayMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayMethod.Location = new System.Drawing.Point(607, 40);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(119, 16);
            this.lblPayMethod.TabIndex = 46;
            this.lblPayMethod.Text = "PaymentMethod";
            // 
            // cmbPay
            // 
            this.cmbPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPay.FormattingEnabled = true;
            this.cmbPay.Location = new System.Drawing.Point(732, 38);
            this.cmbPay.Name = "cmbPay";
            this.cmbPay.Size = new System.Drawing.Size(143, 21);
            this.cmbPay.TabIndex = 45;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(636, 84);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(47, 20);
            this.nudAmount.TabIndex = 44;
            // 
            // btnFindCust
            // 
            this.btnFindCust.Image = ((System.Drawing.Image)(resources.GetObject("btnFindCust.Image")));
            this.btnFindCust.Location = new System.Drawing.Point(539, 25);
            this.btnFindCust.Name = "btnFindCust";
            this.btnFindCust.Size = new System.Drawing.Size(54, 45);
            this.btnFindCust.TabIndex = 43;
            this.btnFindCust.UseVisualStyleBackColor = true;
            this.btnFindCust.Click += new System.EventHandler(this.btnFindCust_Click);
            // 
            // btnFindProd
            // 
            this.btnFindProd.Image = ((System.Drawing.Image)(resources.GetObject("btnFindProd.Image")));
            this.btnFindProd.Location = new System.Drawing.Point(286, 71);
            this.btnFindProd.Name = "btnFindProd";
            this.btnFindProd.Size = new System.Drawing.Size(54, 43);
            this.btnFindProd.TabIndex = 42;
            this.btnFindProd.UseVisualStyleBackColor = true;
            this.btnFindProd.Click += new System.EventHandler(this.btnFindProd_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(761, 421);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(81, 20);
            this.txtTotal.TabIndex = 41;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(758, 402);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 16);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "Total:";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(807, 458);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 39;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(688, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(748, 207);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 37;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(748, 157);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 36;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dgvModOrder
            // 
            this.dgvModOrder.AllowUserToAddRows = false;
            this.dgvModOrder.AllowUserToDeleteRows = false;
            this.dgvModOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModOrder.Location = new System.Drawing.Point(12, 121);
            this.dgvModOrder.Name = "dgvModOrder";
            this.dgvModOrder.RowHeadersVisible = false;
            this.dgvModOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModOrder.Size = new System.Drawing.Size(714, 276);
            this.dgvModOrder.TabIndex = 35;
            // 
            // txtPrepaid
            // 
            this.txtPrepaid.Location = new System.Drawing.Point(807, 84);
            this.txtPrepaid.Name = "txtPrepaid";
            this.txtPrepaid.Size = new System.Drawing.Size(68, 20);
            this.txtPrepaid.TabIndex = 34;
            // 
            // lblPrepaid
            // 
            this.lblPrepaid.AutoSize = true;
            this.lblPrepaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrepaid.Location = new System.Drawing.Point(720, 87);
            this.lblPrepaid.Name = "lblPrepaid";
            this.lblPrepaid.Size = new System.Drawing.Size(67, 16);
            this.lblPrepaid.TabIndex = 33;
            this.lblPrepaid.Text = "Prepaid:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(554, 87);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(63, 16);
            this.lblAmount.TabIndex = 32;
            this.lblAmount.Text = "Amount:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(430, 87);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 31;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(321, 40);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(198, 20);
            this.txtCustomer.TabIndex = 30;
            // 
            // lblPricesale
            // 
            this.lblPricesale.AutoSize = true;
            this.lblPricesale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricesale.Location = new System.Drawing.Point(346, 88);
            this.lblPricesale.Name = "lblPricesale";
            this.lblPricesale.Size = new System.Drawing.Size(78, 16);
            this.lblPricesale.TabIndex = 29;
            this.lblPricesale.Text = "Pricesale:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(238, 40);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(77, 16);
            this.lblCustomer.TabIndex = 28;
            this.lblCustomer.Text = "Customer:";
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(99, 39);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 20);
            this.date.TabIndex = 27;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(99, 88);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(181, 20);
            this.txtProduct.TabIndex = 26;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(28, 88);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(65, 16);
            this.lblProduct.TabIndex = 25;
            this.lblProduct.Text = "Product:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(28, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 16);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date:";
            // 
            // lblNumeroOrder
            // 
            this.lblNumeroOrder.AutoSize = true;
            this.lblNumeroOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOrder.Location = new System.Drawing.Point(28, 9);
            this.lblNumeroOrder.Name = "lblNumeroOrder";
            this.lblNumeroOrder.Size = new System.Drawing.Size(58, 16);
            this.lblNumeroOrder.TabIndex = 47;
            this.lblNumeroOrder.Text = "Order x";
            // 
            // ModOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 501);
            this.Controls.Add(this.lblNumeroOrder);
            this.Controls.Add(this.lblPayMethod);
            this.Controls.Add(this.cmbPay);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.btnFindCust);
            this.Controls.Add(this.btnFindProd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dgvModOrder);
            this.Controls.Add(this.txtPrepaid);
            this.Controls.Add(this.lblPrepaid);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblPricesale);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblDate);
            this.Name = "ModOrder";
            this.Text = "ModOrder";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayMethod;
        private System.Windows.Forms.ComboBox cmbPay;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnFindCust;
        private System.Windows.Forms.Button btnFindProd;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtPrepaid;
        private System.Windows.Forms.Label lblPrepaid;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPricesale;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumeroOrder;
        public System.Windows.Forms.TextBox txtCustomer;
        public System.Windows.Forms.DataGridView dgvModOrder;
    }
}