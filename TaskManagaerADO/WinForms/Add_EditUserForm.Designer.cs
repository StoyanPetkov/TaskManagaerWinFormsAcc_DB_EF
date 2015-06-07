namespace TaskManager.WinForms
{
    partial class Add_EditUserForm
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
            this.tbUsrName = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnUsrFrmCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsrName
            // 
            this.tbUsrName.Location = new System.Drawing.Point(15, 12);
            this.tbUsrName.Name = "tbUsrName";
            this.tbUsrName.Size = new System.Drawing.Size(167, 20);
            this.tbUsrName.TabIndex = 0;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(15, 46);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(167, 20);
            this.tbPass.TabIndex = 1;
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(15, 81);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(167, 20);
            this.tbFname.TabIndex = 2;
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(15, 115);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(167, 20);
            this.tbLname.TabIndex = 3;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.Color.Snow;
            this.btnSaveUser.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSaveUser.FlatAppearance.BorderSize = 2;
            this.btnSaveUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.Location = new System.Drawing.Point(15, 151);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(77, 30);
            this.btnSaveUser.TabIndex = 4;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUsrFrmCancel
            // 
            this.btnUsrFrmCancel.BackColor = System.Drawing.Color.Snow;
            this.btnUsrFrmCancel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnUsrFrmCancel.FlatAppearance.BorderSize = 2;
            this.btnUsrFrmCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUsrFrmCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrFrmCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrFrmCancel.Location = new System.Drawing.Point(105, 151);
            this.btnUsrFrmCancel.Name = "btnUsrFrmCancel";
            this.btnUsrFrmCancel.Size = new System.Drawing.Size(77, 30);
            this.btnUsrFrmCancel.TabIndex = 9;
            this.btnUsrFrmCancel.Text = "Cancel";
            this.btnUsrFrmCancel.UseVisualStyleBackColor = false;
            this.btnUsrFrmCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(194, 193);
            this.Controls.Add(this.btnUsrFrmCancel);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUsrName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.Add_EditUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsrName;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnUsrFrmCancel;
    }
}