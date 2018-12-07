namespace Avengers
{
    partial class Login
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
            this.lblU = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSelectIdioma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Location = new System.Drawing.Point(55, 80);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(29, 13);
            this.lblU.TabIndex = 0;
            this.lblU.Text = "User";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(55, 128);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(30, 13);
            this.lblP.TabIndex = 1;
            this.lblP.Text = "Pass";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(117, 77);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(117, 125);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.comboBox1.Location = new System.Drawing.Point(151, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblSelectIdioma
            // 
            this.lblSelectIdioma.AutoSize = true;
            this.lblSelectIdioma.Location = new System.Drawing.Point(45, 30);
            this.lblSelectIdioma.Name = "lblSelectIdioma";
            this.lblSelectIdioma.Size = new System.Drawing.Size(84, 13);
            this.lblSelectIdioma.TabIndex = 8;
            this.lblSelectIdioma.Text = "Select Languaje";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 210);
            this.Controls.Add(this.lblSelectIdioma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblU);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSelectIdioma;
    }
}