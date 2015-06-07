using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Service;
using TMLib.Entities;
using TMLib.Repository;

namespace TaskManager.WinForms
{
    public partial class LogHistoryForm : Form
    {
        TaskRepository taskRepo = new TaskRepository();
        TimeSpentRepository tSpentRepo = new TimeSpentRepository();
        UserRepository userRepo = new UserRepository();
        int id = 0;
        int[] arr = { 1, 5, 25, 75, 150 };

        public LogHistoryForm()
        {
            InitializeComponent();
            List<Tasks> taskList = new List<Tasks>();
            taskList = taskRepo.GetAll();
            foreach (var task in taskList)
            {
                cbTasks.Items.Add(task.Title);
            }
            for (int i = 0; i < 5; i++)
            {
                cbSelectFilter.Items.Add(Convert.ToString(arr[i]));
            }
            lblCurrenty.Visible = false;
            lblSummary.Visible = false;
        }

        //private void cbSelectFilter_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        //        (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void cbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = cbTasks.Text;

            List<Tasks> taskList = new List<Tasks>();
            taskList = taskRepo.GetAll();
            foreach (var task in taskList)
            {
                if (task.Title == choice)
                {
                    id = task.TaskId;
                }
            }
            lblCurrenty.Visible = true;
            if (tSpentRepo.GetAllTimeSpentById(id).Count.ToString() != null)
            {
                lblSummary.Text = tSpentRepo.GetAllTimeSpentById(id).Count.ToString();
            }
            else
            {
                lblSummary.Text = Convert.ToString(0);
            }
            lblSummary.Visible = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTasks.SelectedIndex != -1)
                {
                    if (cbSelectFilter.Text != "")
                    {
                        refreshSubItem();
                    }
                    else
                    {
                        refreshSubItem();
                    }
                }
                else if (cbTasks.SelectedIndex == -1)
                {
                    MessageBox.Show("Select a task !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshSubItem()
        {
            DataGridViewComboBoxColumn username = (DataGridViewComboBoxColumn)LogHistoryDataGrid.Columns[1];
            username.DataSource = userRepo.GetAll();
            DataGridViewComboBoxColumn title = (DataGridViewComboBoxColumn)LogHistoryDataGrid.Columns[2];
            title.DataSource = taskRepo.GetAll();

            int count = tSpentRepo.GetAllTimeSpentById(id).Count;
            if (cbSelectFilter.SelectedIndex != -1 || cbSelectFilter.Text != "")
            {
                if (Convert.ToInt32(cbSelectFilter.Text) <= count)
                {
                    count = Convert.ToInt32(cbSelectFilter.Text);
                }
                else
                {
                    MessageBox.Show("Reduce input number !");
                }
            }
            if (count > 100)
            {
                count = 100;
            }

            List<TimeSpent> tList = new List<TimeSpent>();
            tList = tSpentRepo.GetAllTimeSpentById(id);

            List<TimeSpent> subList = tList.GetRange(0, count);

            bindingSource1.DataSource = subList;
            LogHistoryDataGrid.DataSource = bindingSource1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.cbSelectFilter.SelectedIndex = -1;
            this.cbSelectFilter.Text = "";
            this.cbTasks.SelectedIndex = -1;
            this.lblSummary.Visible = false;
            this.lblCurrenty.Visible = false;
            this.lblSummary.Text = "";
            LogHistoryDataGrid.Rows.Clear();
        }
    }
}
