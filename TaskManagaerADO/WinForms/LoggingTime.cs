using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Service;
using TaskManager.WinForms;
using TMLib.Entities;
using TMLib.Repository;

namespace TaskManager.WinForms
{
    public partial class LoggingTime : Form
    {
        public TimeSpent tSpent = new TimeSpent();
        
        public LoggingTime(Tasks task,TimeSpent tSpent)
        {
            InitializeComponent();
            this.tSpent = tSpent;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnSave.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            tSpent.Taskid = task.TaskId;
            tSpent.Userid = AuthenticateService.LoggedUser.UserId;
            tbCurrentTS.Text = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tSpent.LogTime = Convert.ToInt32(tbCurrentTS.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void LoggingTime_Load(object sender, EventArgs e)
        {
            SendMessage(tbCurrentTS.Handle, EM_SETCUEBANNER, 0, "input time in hrs");
        }

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        //private void btnFinishTask_Click(object sender, EventArgs e)
        //{
        //    Tasks task = (Tasks)bindingSource1.Current;
        //    DialogResult result = MessageBox.Show("Task: " + task.Title, "Finishing task",
        //        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (result == DialogResult.Yes)
        //    {
        //        TasksRepository taskRepo = new TasksRepository("tasks.txt");
        //        task.IsFinished = true;
        //        taskRepo.Save(task);
        //        RefreshItem();
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}
    }
}
