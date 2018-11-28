namespace Avengers.Presentacion.Users
{
    partial class NewRole
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
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveOne = new System.Windows.Forms.Button();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.lblSelectedPerm = new System.Windows.Forms.Label();
            this.lblPermList = new System.Windows.Forms.Label();
            this.lbxPermissionList = new System.Windows.Forms.ListBox();
            this.lbxSelectedPerm = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(196, 39);
            this.txtRoleName.MaxLength = 30;
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(205, 20);
            this.txtRoleName.TabIndex = 13;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleName.Location = new System.Drawing.Point(84, 40);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(80, 16);
            this.lblRoleName.TabIndex = 12;
            this.lblRoleName.Text = "Role Name:";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(280, 423);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(84, 32);
            this.btnCreate.TabIndex = 38;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(156, 423);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 32);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(245, 160);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(43, 30);
            this.btnAddAll.TabIndex = 39;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(245, 300);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(43, 28);
            this.btnRemoveAll.TabIndex = 40;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            // 
            // btnRemoveOne
            // 
            this.btnRemoveOne.Location = new System.Drawing.Point(245, 252);
            this.btnRemoveOne.Name = "btnRemoveOne";
            this.btnRemoveOne.Size = new System.Drawing.Size(43, 29);
            this.btnRemoveOne.TabIndex = 41;
            this.btnRemoveOne.Text = "<";
            this.btnRemoveOne.UseVisualStyleBackColor = true;
            // 
            // btnAddOne
            // 
            this.btnAddOne.Location = new System.Drawing.Point(245, 205);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(43, 30);
            this.btnAddOne.TabIndex = 42;
            this.btnAddOne.Text = ">";
            this.btnAddOne.UseVisualStyleBackColor = true;
            // 
            // lblSelectedPerm
            // 
            this.lblSelectedPerm.AutoSize = true;
            this.lblSelectedPerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedPerm.Location = new System.Drawing.Point(321, 91);
            this.lblSelectedPerm.Name = "lblSelectedPerm";
            this.lblSelectedPerm.Size = new System.Drawing.Size(142, 16);
            this.lblSelectedPerm.TabIndex = 43;
            this.lblSelectedPerm.Text = "Selected Permissions:";
            // 
            // lblPermList
            // 
            this.lblPermList.AutoSize = true;
            this.lblPermList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermList.Location = new System.Drawing.Point(84, 91);
            this.lblPermList.Name = "lblPermList";
            this.lblPermList.Size = new System.Drawing.Size(108, 16);
            this.lblPermList.TabIndex = 44;
            this.lblPermList.Text = "Permissions List:";
            // 
            // lbxPermissionList
            // 
            this.lbxPermissionList.FormattingEnabled = true;
            this.lbxPermissionList.Location = new System.Drawing.Point(56, 119);
            this.lbxPermissionList.Name = "lbxPermissionList";
            this.lbxPermissionList.Size = new System.Drawing.Size(170, 264);
            this.lbxPermissionList.TabIndex = 45;
            // 
            // lbxSelectedPerm
            // 
            this.lbxSelectedPerm.FormattingEnabled = true;
            this.lbxSelectedPerm.Location = new System.Drawing.Point(308, 119);
            this.lbxSelectedPerm.Name = "lbxSelectedPerm";
            this.lbxSelectedPerm.Size = new System.Drawing.Size(170, 264);
            this.lbxSelectedPerm.TabIndex = 46;
            // 
            // NewRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 491);
            this.Controls.Add(this.lbxSelectedPerm);
            this.Controls.Add(this.lbxPermissionList);
            this.Controls.Add(this.lblPermList);
            this.Controls.Add(this.lblSelectedPerm);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.btnRemoveOne);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.lblRoleName);
            this.Name = "NewRole";
            this.Text = "NewRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemoveOne;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Label lblSelectedPerm;
        private System.Windows.Forms.Label lblPermList;
        private System.Windows.Forms.ListBox lbxPermissionList;
        private System.Windows.Forms.ListBox lbxSelectedPerm;
    }
}