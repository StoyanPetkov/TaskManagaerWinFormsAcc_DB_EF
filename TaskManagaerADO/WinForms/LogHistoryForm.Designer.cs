namespace TaskManager.WinForms
{
    partial class LogHistoryForm
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
            this.LogHistoryDataGrid = new System.Windows.Forms.DataGridView();
            this.TimeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Userid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Taskid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tasksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.LogTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFinished = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTasks = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblSelectFilter = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSelectFilter = new System.Windows.Forms.ComboBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblCurrenty = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogHistoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogHistoryDataGrid
            // 
            this.LogHistoryDataGrid.AllowUserToAddRows = false;
            this.LogHistoryDataGrid.AllowUserToDeleteRows = false;
            this.LogHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogHistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeId,
            this.Userid,
            this.Taskid,
            this.LogTime,
            this.Date,
            this.IsFinished});
            this.LogHistoryDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogHistoryDataGrid.Location = new System.Drawing.Point(0, 151);
            this.LogHistoryDataGrid.Name = "LogHistoryDataGrid";
            this.LogHistoryDataGrid.ReadOnly = true;
            this.LogHistoryDataGrid.RowHeadersVisible = false;
            this.LogHistoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LogHistoryDataGrid.Size = new System.Drawing.Size(425, 192);
            this.LogHistoryDataGrid.TabIndex = 0;
            // 
            // TimeId
            // 
            this.TimeId.DataPropertyName = "Id";
            this.TimeId.HeaderText = "ID";
            this.TimeId.Name = "TimeId";
            this.TimeId.ReadOnly = true;
            this.TimeId.Visible = false;
            // 
            // Userid
            // 
            this.Userid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Userid.DataPropertyName = "UserId";
            this.Userid.DataSource = this.userBindingSource1;
            this.Userid.DisplayMember = "UserName";
            this.Userid.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Userid.HeaderText = "Logged by";
            this.Userid.MinimumWidth = 65;
            this.Userid.Name = "Userid";
            this.Userid.ReadOnly = true;
            this.Userid.ValueMember = "UserId";
            this.Userid.Width = 65;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(TMLib.Entities.User);
            // 
            // Taskid
            // 
            this.Taskid.DataPropertyName = "TaskId";
            this.Taskid.DataSource = this.tasksBindingSource1;
            this.Taskid.DisplayMember = "Title";
            this.Taskid.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Taskid.HeaderText = "Title";
            this.Taskid.Name = "Taskid";
            this.Taskid.ReadOnly = true;
            this.Taskid.ValueMember = "TaskId";
            // 
            // tasksBindingSource1
            // 
            this.tasksBindingSource1.DataSource = typeof(TMLib.Entities.Tasks);
            // 
            // LogTime
            // 
            this.LogTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LogTime.DataPropertyName = "LogTime";
            this.LogTime.HeaderText = "Logged time";
            this.LogTime.MinimumWidth = 50;
            this.LogTime.Name = "LogTime";
            this.LogTime.ReadOnly = true;
            this.LogTime.Width = 90;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Logged on";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // IsFinished
            // 
            this.IsFinished.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IsFinished.DataPropertyName = "IsFinished";
            this.IsFinished.HeaderText = "Finished";
            this.IsFinished.MinimumWidth = 60;
            this.IsFinished.Name = "IsFinished";
            this.IsFinished.ReadOnly = true;
            this.IsFinished.Width = 60;
            // 
            // cbTasks
            // 
            this.cbTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Location = new System.Drawing.Point(121, 8);
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.Size = new System.Drawing.Size(146, 21);
            this.cbTasks.TabIndex = 1;
            this.cbTasks.SelectedIndexChanged += new System.EventHandler(this.cbTasks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select task:";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Snow;
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnShow.FlatAppearance.BorderSize = 2;
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(302, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(96, 32);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblSelectFilter
            // 
            this.lblSelectFilter.AutoSize = true;
            this.lblSelectFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFilter.Location = new System.Drawing.Point(6, 31);
            this.lblSelectFilter.Name = "lblSelectFilter";
            this.lblSelectFilter.Size = new System.Drawing.Size(81, 16);
            this.lblSelectFilter.TabIndex = 6;
            this.lblSelectFilter.Text = "Select first";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Snow;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(302, 106);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSelectFilter);
            this.groupBox1.Controls.Add(this.lblSummary);
            this.groupBox1.Controls.Add(this.lblCurrenty);
            this.groupBox1.Controls.Add(this.lblSelectFilter);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 102);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // cbSelectFilter
            // 
            this.cbSelectFilter.FormattingEnabled = true;
            this.cbSelectFilter.Location = new System.Drawing.Point(100, 28);
            this.cbSelectFilter.Name = "cbSelectFilter";
            this.cbSelectFilter.Size = new System.Drawing.Size(121, 23);
            this.cbSelectFilter.TabIndex = 8;
//            this.cbSelectFilter.SelectedIndexChanged += new System.EventHandler(this.cbSelectFilter_SelectedIndexChanged);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(97, 70);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(16, 16);
            this.lblSummary.TabIndex = 10;
            this.lblSummary.Text = "0";
            // 
            // lblCurrenty
            // 
            this.lblCurrenty.AutoSize = true;
            this.lblCurrenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrenty.Location = new System.Drawing.Point(6, 70);
            this.lblCurrenty.Name = "lblCurrenty";
            this.lblCurrenty.Size = new System.Drawing.Size(76, 16);
            this.lblCurrenty.TabIndex = 9;
            this.lblCurrenty.Text = "Summary:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Snow;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(302, 58);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 32);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // LogHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(425, 343);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTasks);
            this.Controls.Add(this.LogHistoryDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LogHistoryForm";
            this.Text = "Time spent history";
            ((System.ComponentModel.ISupportInitialize)(this.LogHistoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LogHistoryDataGrid;
        private System.Windows.Forms.ComboBox cbTasks;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblSelectFilter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.BindingSource tasksBindingSource1;
        private System.Windows.Forms.ComboBox cbSelectFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeId;
        private System.Windows.Forms.DataGridViewComboBoxColumn Userid;
        private System.Windows.Forms.DataGridViewComboBoxColumn Taskid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsFinished;
        private System.Windows.Forms.Label lblCurrenty;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnReset;
    }
}