namespace TaskManager.WinForms
{
    partial class Add_EditTaskForm
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
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbEsstimatedTime = new System.Windows.Forms.TextBox();
            this.lbAssignedTo = new System.Windows.Forms.ListBox();
            this.btnTskFrmCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.BackColor = System.Drawing.Color.Snow;
            this.btnSaveTask.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSaveTask.FlatAppearance.BorderSize = 2;
            this.btnSaveTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSaveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTask.Location = new System.Drawing.Point(12, 182);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(67, 32);
            this.btnSaveTask.TabIndex = 0;
            this.btnSaveTask.Text = "Save";
            this.btnSaveTask.UseVisualStyleBackColor = false;
            this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(12, 12);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(150, 20);
            this.tbTitle.TabIndex = 1;
//            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 48);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(150, 20);
            this.tbDescription.TabIndex = 3;
            // 
            // tbEsstimatedTime
            // 
            this.tbEsstimatedTime.Location = new System.Drawing.Point(12, 84);
            this.tbEsstimatedTime.Name = "tbEsstimatedTime";
            this.tbEsstimatedTime.Size = new System.Drawing.Size(150, 20);
            this.tbEsstimatedTime.TabIndex = 5;
//            this.tbEsstimatedTime.TextChanged += new System.EventHandler(this.tbEsstimatedTime_TextChanged);
            // 
            // lbAssignedTo
            // 
            this.lbAssignedTo.FormattingEnabled = true;
            this.lbAssignedTo.Location = new System.Drawing.Point(12, 121);
            this.lbAssignedTo.Name = "lbAssignedTo";
            this.lbAssignedTo.Size = new System.Drawing.Size(150, 43);
            this.lbAssignedTo.TabIndex = 9;
            this.lbAssignedTo.SelectedIndexChanged += new System.EventHandler(this.lbAssignedTo_SelectedIndexChanged);
            // 
            // btnTskFrmCancel
            // 
            this.btnTskFrmCancel.BackColor = System.Drawing.Color.Snow;
            this.btnTskFrmCancel.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnTskFrmCancel.FlatAppearance.BorderSize = 2;
            this.btnTskFrmCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTskFrmCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTskFrmCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTskFrmCancel.Location = new System.Drawing.Point(95, 182);
            this.btnTskFrmCancel.Name = "btnTskFrmCancel";
            this.btnTskFrmCancel.Size = new System.Drawing.Size(67, 32);
            this.btnTskFrmCancel.TabIndex = 10;
            this.btnTskFrmCancel.Text = "Cancel";
            this.btnTskFrmCancel.UseVisualStyleBackColor = false;
            this.btnTskFrmCancel.Click += new System.EventHandler(this.btnTskFrmCancel_Click);
            // 
            // Add_EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(182, 226);
            this.Controls.Add(this.btnTskFrmCancel);
            this.Controls.Add(this.lbAssignedTo);
            this.Controls.Add(this.tbEsstimatedTime);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnSaveTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_EditTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.Add_EditTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbEsstimatedTime;
        public System.Windows.Forms.ListBox lbAssignedTo;
        private System.Windows.Forms.Button btnTskFrmCancel;
    }
}