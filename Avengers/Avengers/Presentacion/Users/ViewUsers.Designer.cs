namespace Avengers.Presentacion
{
    partial class ViewUsers
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.ckDel = new System.Windows.Forms.CheckBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnModUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(61, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(367, 42);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(45, 16);
            this.lblRol.TabIndex = 5;
            this.lblRol.Text = "Role:";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(418, 42);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(188, 20);
            this.txtRole.TabIndex = 4;
            // 
            // ckDel
            // 
            this.ckDel.AutoSize = true;
            this.ckDel.Location = new System.Drawing.Point(660, 43);
            this.ckDel.Name = "ckDel";
            this.ckDel.Size = new System.Drawing.Size(63, 17);
            this.ckDel.TabIndex = 15;
            this.ckDel.Text = "Deleted";
            this.ckDel.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(795, 410);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 27);
            this.btnLog.TabIndex = 24;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnModUser
            // 
            this.btnModUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModUser.Location = new System.Drawing.Point(795, 369);
            this.btnModUser.Name = "btnModUser";
            this.btnModUser.Size = new System.Drawing.Size(75, 23);
            this.btnModUser.TabIndex = 23;
            this.btnModUser.Text = "Modify";
            this.btnModUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(795, 328);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 22;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.Location = new System.Drawing.Point(795, 286);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnNewUser.TabIndex = 21;
            this.btnNewUser.Text = "New";
            this.btnNewUser.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(36, 103);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(687, 399);
            this.dgvUsers.TabIndex = 25;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(795, 39);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 26;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 545);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnModUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.ckDel);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "ViewUsers";
            this.Text = "ViewUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.CheckBox ckDel;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnModUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnClean;
    }
}