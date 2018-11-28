namespace Avengers.Presentacion.Users
{
    partial class ModUser
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
            this.btnCreateRole = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtRepPass = new System.Windows.Forms.TextBox();
            this.lblRepPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateRole
            // 
            this.btnCreateRole.Location = new System.Drawing.Point(283, 174);
            this.btnCreateRole.Name = "btnCreateRole";
            this.btnCreateRole.Size = new System.Drawing.Size(105, 25);
            this.btnCreateRole.TabIndex = 37;
            this.btnCreateRole.Text = "Create Role";
            this.btnCreateRole.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(241, 244);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(84, 32);
            this.btnChange.TabIndex = 36;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(124, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 32);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(114, 177);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(143, 21);
            this.cmbRol.TabIndex = 33;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(42, 178);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(40, 16);
            this.lblRole.TabIndex = 32;
            this.lblRole.Text = "Role:";
            // 
            // txtRepPass
            // 
            this.txtRepPass.Location = new System.Drawing.Point(183, 131);
            this.txtRepPass.MaxLength = 30;
            this.txtRepPass.Name = "txtRepPass";
            this.txtRepPass.Size = new System.Drawing.Size(205, 20);
            this.txtRepPass.TabIndex = 31;
            // 
            // lblRepPass
            // 
            this.lblRepPass.AutoSize = true;
            this.lblRepPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepPass.Location = new System.Drawing.Point(42, 131);
            this.lblRepPass.Name = "lblRepPass";
            this.lblRepPass.Size = new System.Drawing.Size(119, 16);
            this.lblRepPass.TabIndex = 30;
            this.lblRepPass.Text = "Repeat Password:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(183, 91);
            this.txtNewPass.MaxLength = 30;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(205, 20);
            this.txtNewPass.TabIndex = 29;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(42, 91);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(101, 16);
            this.lblNewPass.TabIndex = 28;
            this.lblNewPass.Text = "New Password:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(183, 51);
            this.txtOldPass.MaxLength = 30;
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(205, 20);
            this.txtOldPass.TabIndex = 27;
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPass.Location = new System.Drawing.Point(42, 51);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(95, 16);
            this.lblOldPass.TabIndex = 26;
            this.lblOldPass.Text = "Old Password:";
            // 
            // ModUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.btnCreateRole);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtRepPass);
            this.Controls.Add(this.lblRepPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.lblOldPass);
            this.Name = "ModUser";
            this.Text = "ModUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRole;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRepPass;
        private System.Windows.Forms.Label lblRepPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label lblOldPass;
    }
}