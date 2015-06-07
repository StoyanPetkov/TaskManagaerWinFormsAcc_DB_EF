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
using TaskManager.WinForms;
using TMLib.Entities;
using TMLib.Repository;

namespace TaskManager.WinForms
{
    public partial class TaskManagerForm : Form
    {
        UserRepository userRepo = new UserRepository();
        TaskRepository taskRepo = new TaskRepository();
        TimeSpentRepository tSpentRepo = new TimeSpentRepository();

        private bool editMode = false;
        private TimeSpent tSpent = new TimeSpent { LogTime=0, Userid = AuthenticateService.LoggedUser.UserId};

        public TaskManagerForm()
        {
            InitializeComponent();
            RefreshItem();
        }

        public void RefreshItem()
        {
            bindingSource1.DataSource = taskRepo.GetAll();
            taskDataGrid.DataSource = bindingSource1;

            DataGridViewComboBoxColumn columnCreatedBy = 
                (DataGridViewComboBoxColumn)taskDataGrid.Columns[5];
            columnCreatedBy.DataSource = userRepo.GetAll();

            DataGridViewComboBoxColumn columnAssignedTo = 
                (DataGridViewComboBoxColumn)taskDataGrid.Columns[6];
            columnAssignedTo.DataSource = userRepo.GetAll();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tasks task = new Tasks();
            Add_EditTaskForm taskForm = new Add_EditTaskForm(task);
            if (taskForm.ShowDialog() == DialogResult.OK)
            {
                taskRepo.Save(task);
                RefreshItem();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tasks task = (Tasks)bindingSource1.Current;
            editMode = true;
            Add_EditTaskForm edit_form = new Add_EditTaskForm(task, editMode);

            if (edit_form.ShowDialog() == DialogResult.OK)
            {
                taskRepo.Save(task);
                RefreshItem();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tasks task = (Tasks)bindingSource1.Current;
            DialogResult result = MessageBox.Show("Deleting...\n" + "\nTitle: "
                + task.Title + "\nDescription: " + task.Description + "\nEstimated time: " + task.EstimatedTime.ToString() +
                "\n Created on: " + task.Createdon.ToString() + "\nCreated by: " + task.CreatedBy.ToString() + "\nAssigned to: "
                 + task.Assignedto.ToString(), "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                taskRepo.Delete(task);
                RefreshItem();
            }
            else
            {
                return;
            }
        }

        private bool CheckTask(Tasks task)
        {
            bool result = false;
            if (task.IsFinished == true)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        private void finishATaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tasks task = (Tasks)bindingSource1.Current;

            if (CheckTask(task) == false)
            {
                MessageBox.Show("This task is already finished");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Task: " + task.Title, "Finishing task",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    task.IsFinished = true;
                    tSpent.LogTime = 0;
                    tSpentRepo.Insert(task,tSpent);
                    taskRepo.Save(task);
                    RefreshItem();
                }
                else
                {
                    return;
                }
            }
        }

        private void logTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tasks task = (Tasks)bindingSource1.Current;
            this.tSpent = new TimeSpent();
            if (task.IsFinished == false)
            {
                LoggingTime logTimeForm = new LoggingTime(task,tSpent);
                if (logTimeForm.ShowDialog() == DialogResult.OK)
                {
                    tSpentRepo.Insert(task,tSpent);
                    RefreshItem();
                }
            }
            else
            {
                MessageBox.Show("Task is finished.");
                return;
            }
        }
    }
}
