namespace Avengers.Presentacion
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.products = new Bunifu.Framework.UI.BunifuFlatButton();
            this.customers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.users = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOrders = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSys = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.btnCloseTab = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 372);
            this.panel1.TabIndex = 0;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblUser);
            this.bunifuGradientPanel1.Controls.Add(this.products);
            this.bunifuGradientPanel1.Controls.Add(this.customers);
            this.bunifuGradientPanel1.Controls.Add(this.users);
            this.bunifuGradientPanel1.Controls.Add(this.btnOrders);
            this.bunifuGradientPanel1.Controls.Add(this.btnExit);
            this.bunifuGradientPanel1.Controls.Add(this.btnSys);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.MediumBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(177, 372);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.Activecolor = System.Drawing.Color.Transparent;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblUser.BorderRadius = 0;
            this.lblUser.ButtonText = "";
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUser.DisabledColor = System.Drawing.Color.Gray;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser.Iconcolor = System.Drawing.Color.Transparent;
            this.lblUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("lblUser.Iconimage")));
            this.lblUser.Iconimage_right = null;
            this.lblUser.Iconimage_right_Selected = null;
            this.lblUser.Iconimage_Selected = null;
            this.lblUser.IconMarginLeft = 0;
            this.lblUser.IconMarginRight = 0;
            this.lblUser.IconRightVisible = true;
            this.lblUser.IconRightZoom = 0D;
            this.lblUser.IconVisible = false;
            this.lblUser.IconZoom = 90D;
            this.lblUser.IsTab = false;
            this.lblUser.Location = new System.Drawing.Point(0, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Normalcolor = System.Drawing.Color.Transparent;
            this.lblUser.OnHovercolor = System.Drawing.Color.Transparent;
            this.lblUser.OnHoverTextColor = System.Drawing.Color.White;
            this.lblUser.selected = false;
            this.lblUser.Size = new System.Drawing.Size(177, 48);
            this.lblUser.TabIndex = 6;
            this.lblUser.TabStop = false;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUser.Textcolor = System.Drawing.Color.White;
            this.lblUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // products
            // 
            this.products.Activecolor = System.Drawing.Color.Transparent;
            this.products.BackColor = System.Drawing.Color.Transparent;
            this.products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.products.BorderRadius = 0;
            this.products.ButtonText = "       Products";
            this.products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.products.DisabledColor = System.Drawing.Color.Gray;
            this.products.Enabled = false;
            this.products.ForeColor = System.Drawing.SystemColors.ControlText;
            this.products.Iconcolor = System.Drawing.Color.Transparent;
            this.products.Iconimage = ((System.Drawing.Image)(resources.GetObject("products.Iconimage")));
            this.products.Iconimage_right = null;
            this.products.Iconimage_right_Selected = null;
            this.products.Iconimage_Selected = null;
            this.products.IconMarginLeft = 0;
            this.products.IconMarginRight = 0;
            this.products.IconRightVisible = true;
            this.products.IconRightZoom = 0D;
            this.products.IconVisible = false;
            this.products.IconZoom = 90D;
            this.products.IsTab = false;
            this.products.Location = new System.Drawing.Point(0, 140);
            this.products.Name = "products";
            this.products.Normalcolor = System.Drawing.Color.Transparent;
            this.products.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.products.OnHoverTextColor = System.Drawing.Color.White;
            this.products.selected = false;
            this.products.Size = new System.Drawing.Size(177, 19);
            this.products.TabIndex = 5;
            this.products.Text = "       Products";
            this.products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.products.Textcolor = System.Drawing.Color.White;
            this.products.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.Visible = false;
            this.products.Click += new System.EventHandler(this.products_Click);
            // 
            // customers
            // 
            this.customers.Activecolor = System.Drawing.Color.Transparent;
            this.customers.BackColor = System.Drawing.Color.Transparent;
            this.customers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customers.BorderRadius = 0;
            this.customers.ButtonText = "       Customers";
            this.customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customers.DisabledColor = System.Drawing.Color.Gray;
            this.customers.Enabled = false;
            this.customers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customers.Iconcolor = System.Drawing.Color.Transparent;
            this.customers.Iconimage = ((System.Drawing.Image)(resources.GetObject("customers.Iconimage")));
            this.customers.Iconimage_right = null;
            this.customers.Iconimage_right_Selected = null;
            this.customers.Iconimage_Selected = null;
            this.customers.IconMarginLeft = 0;
            this.customers.IconMarginRight = 0;
            this.customers.IconRightVisible = true;
            this.customers.IconRightZoom = 0D;
            this.customers.IconVisible = false;
            this.customers.IconZoom = 90D;
            this.customers.IsTab = false;
            this.customers.Location = new System.Drawing.Point(0, 115);
            this.customers.Name = "customers";
            this.customers.Normalcolor = System.Drawing.Color.Transparent;
            this.customers.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.customers.OnHoverTextColor = System.Drawing.Color.White;
            this.customers.selected = false;
            this.customers.Size = new System.Drawing.Size(177, 19);
            this.customers.TabIndex = 4;
            this.customers.Text = "       Customers";
            this.customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customers.Textcolor = System.Drawing.Color.White;
            this.customers.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers.Visible = false;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // users
            // 
            this.users.Activecolor = System.Drawing.Color.Transparent;
            this.users.BackColor = System.Drawing.Color.Transparent;
            this.users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.users.BorderRadius = 0;
            this.users.ButtonText = "       Users";
            this.users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users.DisabledColor = System.Drawing.Color.Gray;
            this.users.Enabled = false;
            this.users.ForeColor = System.Drawing.SystemColors.ControlText;
            this.users.Iconcolor = System.Drawing.Color.Transparent;
            this.users.Iconimage = ((System.Drawing.Image)(resources.GetObject("users.Iconimage")));
            this.users.Iconimage_right = null;
            this.users.Iconimage_right_Selected = null;
            this.users.Iconimage_Selected = null;
            this.users.IconMarginLeft = 0;
            this.users.IconMarginRight = 0;
            this.users.IconRightVisible = true;
            this.users.IconRightZoom = 0D;
            this.users.IconVisible = false;
            this.users.IconZoom = 90D;
            this.users.IsTab = false;
            this.users.Location = new System.Drawing.Point(0, 90);
            this.users.Name = "users";
            this.users.Normalcolor = System.Drawing.Color.Transparent;
            this.users.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.users.OnHoverTextColor = System.Drawing.Color.White;
            this.users.selected = false;
            this.users.Size = new System.Drawing.Size(177, 19);
            this.users.TabIndex = 3;
            this.users.Text = "       Users";
            this.users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.users.Textcolor = System.Drawing.Color.White;
            this.users.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users.Visible = false;
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Activecolor = System.Drawing.Color.Transparent;
            this.btnOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrders.BorderRadius = 0;
            this.btnOrders.ButtonText = "Orders";
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.DisabledColor = System.Drawing.Color.Gray;
            this.btnOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrders.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOrders.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOrders.Iconimage")));
            this.btnOrders.Iconimage_right = null;
            this.btnOrders.Iconimage_right_Selected = null;
            this.btnOrders.Iconimage_Selected = null;
            this.btnOrders.IconMarginLeft = 0;
            this.btnOrders.IconMarginRight = 0;
            this.btnOrders.IconRightVisible = true;
            this.btnOrders.IconRightZoom = 0D;
            this.btnOrders.IconVisible = false;
            this.btnOrders.IconZoom = 90D;
            this.btnOrders.IsTab = false;
            this.btnOrders.Location = new System.Drawing.Point(0, 80);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Normalcolor = System.Drawing.Color.Transparent;
            this.btnOrders.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnOrders.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOrders.selected = false;
            this.btnOrders.Size = new System.Drawing.Size(206, 30);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Textcolor = System.Drawing.Color.White;
            this.btnOrders.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "                Exit";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit.Iconimage")));
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = false;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(0, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExit.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(177, 48);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "                Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSys
            // 
            this.btnSys.Activecolor = System.Drawing.Color.Transparent;
            this.btnSys.BackColor = System.Drawing.Color.Transparent;
            this.btnSys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSys.BorderRadius = 0;
            this.btnSys.ButtonText = "System";
            this.btnSys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSys.DisabledColor = System.Drawing.Color.Gray;
            this.btnSys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSys.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSys.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSys.Iconimage")));
            this.btnSys.Iconimage_right = null;
            this.btnSys.Iconimage_right_Selected = null;
            this.btnSys.Iconimage_Selected = null;
            this.btnSys.IconMarginLeft = 0;
            this.btnSys.IconMarginRight = 0;
            this.btnSys.IconRightVisible = true;
            this.btnSys.IconRightZoom = 0D;
            this.btnSys.IconVisible = false;
            this.btnSys.IconZoom = 90D;
            this.btnSys.IsTab = false;
            this.btnSys.Location = new System.Drawing.Point(0, 55);
            this.btnSys.Name = "btnSys";
            this.btnSys.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSys.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnSys.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSys.selected = false;
            this.btnSys.Size = new System.Drawing.Size(177, 30);
            this.btnSys.TabIndex = 0;
            this.btnSys.Text = "System";
            this.btnSys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSys.Textcolor = System.Drawing.Color.White;
            this.btnSys.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSys.Click += new System.EventHandler(this.btnSys_Click);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(177, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(524, 25);
            this.tabControl.TabIndex = 2;
            this.tabControl.Visible = false;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.AccessibleDescription = "btnCloseTab";
            this.btnCloseTab.AccessibleName = "btnCloseTab";
            this.btnCloseTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseTab.ForeColor = System.Drawing.Color.Red;
            this.btnCloseTab.Location = new System.Drawing.Point(650, 25);
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.Size = new System.Drawing.Size(51, 347);
            this.btnCloseTab.TabIndex = 4;
            this.btnCloseTab.Text = "Close";
            this.btnCloseTab.UseVisualStyleBackColor = true;
            this.btnCloseTab.Click += new System.EventHandler(this.btnCloseTab_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 372);
            this.Controls.Add(this.btnCloseTab);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSys;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton users;
        private Bunifu.Framework.UI.BunifuFlatButton btnOrders;
        private Bunifu.Framework.UI.BunifuFlatButton products;
        private Bunifu.Framework.UI.BunifuFlatButton customers;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnCloseTab;
        private Bunifu.Framework.UI.BunifuFlatButton lblUser;
    }
}