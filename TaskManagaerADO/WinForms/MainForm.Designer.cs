namespace TaskManager.WinForms
{
    partial class MainForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Users = new System.Windows.Forms.MenuStrip();
            this.tsmUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.usersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTasksTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Users
            // 
            this.Users.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsers,
            this.tasksToolStripMenuItem,
            this.logTimeToolStripMenuItem});
            this.Users.Location = new System.Drawing.Point(0, 0);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(589, 24);
            this.Users.TabIndex = 6;
            this.Users.Text = "ms";
            // 
            // tsmUsers
            // 
            this.tsmUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersManagementToolStripMenuItem});
            this.tsmUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmUsers.Name = "tsmUsers";
            this.tsmUsers.Size = new System.Drawing.Size(47, 20);
            this.tsmUsers.Text = "Users";
            // 
            // usersManagementToolStripMenuItem
            // 
            this.usersManagementToolStripMenuItem.Name = "usersManagementToolStripMenuItem";
            this.usersManagementToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.usersManagementToolStripMenuItem.Text = "User\'s management";
            this.usersManagementToolStripMenuItem.Click += new System.EventHandler(this.usersManagementToolStripMenuItem_Click);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTaskToolStripMenuItem});
            this.tasksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.tasksToolStripMenuItem.Text = "Tasks";
            // 
            // manageTaskToolStripMenuItem
            // 
            this.manageTaskToolStripMenuItem.Name = "manageTaskToolStripMenuItem";
            this.manageTaskToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.manageTaskToolStripMenuItem.Text = "Task manager";
            this.manageTaskToolStripMenuItem.Click += new System.EventHandler(this.manageTaskToolStripMenuItem_Click);
            // 
            // logTimeToolStripMenuItem
            // 
            this.logTimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTasksTimeToolStripMenuItem});
            this.logTimeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTimeToolStripMenuItem.Name = "logTimeToolStripMenuItem";
            this.logTimeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.logTimeToolStripMenuItem.Text = "Log time";
            // 
            // manageTasksTimeToolStripMenuItem
            // 
            this.manageTasksTimeToolStripMenuItem.Name = "manageTasksTimeToolStripMenuItem";
            this.manageTasksTimeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.manageTasksTimeToolStripMenuItem.Text = "Manage task\'s time";
            this.manageTasksTimeToolStripMenuItem.Click += new System.EventHandler(this.manageTasksTimeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(589, 457);
            this.Controls.Add(this.Users);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Users.ResumeLayout(false);
            this.Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip Users;
        private System.Windows.Forms.ToolStripMenuItem tsmUsers;
        private System.Windows.Forms.ToolStripMenuItem usersManagementToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTasksTimeToolStripMenuItem;
    }
}