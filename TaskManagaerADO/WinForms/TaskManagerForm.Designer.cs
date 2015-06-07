namespace TaskManager.WinForms
{
    partial class TaskManagerForm
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
            this.taskDataGrid = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishATaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Createdby = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AssignedTo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Createdon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFinished = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // taskDataGrid
            // 
            this.taskDataGrid.AllowUserToAddRows = false;
            this.taskDataGrid.AllowUserToDeleteRows = false;
            this.taskDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Description,
            this.EstimatedTime,
            this.Createdby,
            this.AssignedTo,
            this.Createdon,
            this.TaskId,
            this.IsFinished});
            this.taskDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskDataGrid.Location = new System.Drawing.Point(0, 24);
            this.taskDataGrid.Name = "taskDataGrid";
            this.taskDataGrid.ReadOnly = true;
            this.taskDataGrid.RowHeadersVisible = false;
            this.taskDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taskDataGrid.Size = new System.Drawing.Size(556, 287);
            this.taskDataGrid.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.logTimeToolStripMenuItem,
            this.finishATaskToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // logTimeToolStripMenuItem
            // 
            this.logTimeToolStripMenuItem.Name = "logTimeToolStripMenuItem";
            this.logTimeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.logTimeToolStripMenuItem.Text = "Log time";
            this.logTimeToolStripMenuItem.Click += new System.EventHandler(this.logTimeToolStripMenuItem_Click);
            // 
            // finishATaskToolStripMenuItem
            // 
            this.finishATaskToolStripMenuItem.Name = "finishATaskToolStripMenuItem";
            this.finishATaskToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.finishATaskToolStripMenuItem.Text = "Finish a task";
            this.finishATaskToolStripMenuItem.Click += new System.EventHandler(this.finishATaskToolStripMenuItem_Click);
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataSource = typeof(TMLib.Entities.User);
            // 
            // userBindingSource3
            // 
            this.userBindingSource3.DataSource = typeof(TMLib.Entities.User);
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 50;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 50;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 70;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 70;
            // 
            // EstimatedTime
            // 
            this.EstimatedTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.EstimatedTime.DataPropertyName = "EstimatedTime";
            this.EstimatedTime.HeaderText = "Estimated time";
            this.EstimatedTime.MinimumWidth = 65;
            this.EstimatedTime.Name = "EstimatedTime";
            this.EstimatedTime.ReadOnly = true;
            this.EstimatedTime.Width = 65;
            // 
            // Createdby
            // 
            this.Createdby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Createdby.DataPropertyName = "CreatedBy";
            this.Createdby.DataSource = this.userBindingSource2;
            this.Createdby.DisplayMember = "UserName";
            this.Createdby.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Createdby.HeaderText = "Created by";
            this.Createdby.MinimumWidth = 60;
            this.Createdby.Name = "Createdby";
            this.Createdby.ReadOnly = true;
            this.Createdby.ValueMember = "UserId";
            this.Createdby.Width = 60;
            // 
            // AssignedTo
            // 
            this.AssignedTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AssignedTo.DataPropertyName = "AssignedTo";
            this.AssignedTo.DataSource = this.userBindingSource3;
            this.AssignedTo.DisplayMember = "UserName";
            this.AssignedTo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.AssignedTo.HeaderText = "Assigned to";
            this.AssignedTo.MinimumWidth = 60;
            this.AssignedTo.Name = "AssignedTo";
            this.AssignedTo.ReadOnly = true;
            this.AssignedTo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AssignedTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AssignedTo.ValueMember = "UserId";
            this.AssignedTo.Width = 80;
            // 
            // Createdon
            // 
            this.Createdon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Createdon.DataPropertyName = "Createdon";
            this.Createdon.HeaderText = "Created on";
            this.Createdon.MinimumWidth = 120;
            this.Createdon.Name = "Createdon";
            this.Createdon.ReadOnly = true;
            this.Createdon.Width = 120;
            // 
            // TaskId
            // 
            this.TaskId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TaskId.DataPropertyName = "TaskId";
            this.TaskId.HeaderText = "TaskID";
            this.TaskId.MinimumWidth = 80;
            this.TaskId.Name = "TaskId";
            this.TaskId.ReadOnly = true;
            this.TaskId.Visible = false;
            this.TaskId.Width = 80;
            // 
            // IsFinished
            // 
            this.IsFinished.DataPropertyName = "IsFinished";
            this.IsFinished.HeaderText = "Finished";
            this.IsFinished.Name = "IsFinished";
            this.IsFinished.ReadOnly = true;
            this.IsFinished.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsFinished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TaskManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(556, 311);
            this.Controls.Add(this.taskDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Task Manager";
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView taskDataGrid;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.ToolStripMenuItem finishATaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logTimeToolStripMenuItem;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.BindingSource userBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedTime;
        private System.Windows.Forms.DataGridViewComboBoxColumn Createdby;
        private System.Windows.Forms.DataGridViewComboBoxColumn AssignedTo;
        private System.Windows.Forms.BindingSource userBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Createdon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsFinished;
    }
}