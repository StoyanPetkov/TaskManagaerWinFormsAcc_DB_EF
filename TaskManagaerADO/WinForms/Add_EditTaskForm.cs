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
using TMLib.Entities;
using TMLib.Repository;

namespace TaskManager.WinForms
{
    public partial class Add_EditTaskForm : Form
    {
        private Tasks task;
        TaskRepository taskRepo = new TaskRepository();
        UserRepository userRepo = new UserRepository();

        public Add_EditTaskForm(Tasks task)
        {
            InitializeComponent();

            this.task = task;
            this.task.Title = tbTitle.Text;
            this.task.Description = tbDescription.Text;
            UserManagmentForm frm = new UserManagmentForm();
            List<User> userList = userRepo.GetAll();
            foreach (var usr in userList)
            {
                lbAssignedTo.Items.Add(usr.UserName);
            }
            this.task.CreatedBy = AuthenticateService.LoggedUser.UserId;
            this.task.Assignedto = lbAssignedTo.SelectedIndex;
            this.task.IsFinished = false;

            btnSaveTask.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnTskFrmCancel.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
        }

        public Add_EditTaskForm(Tasks task, bool editMode)
        {
            InitializeComponent();

            if (editMode == true)
            {
                this.task = task;
                tbTitle.Text = this.task.Title;
                tbDescription.Text = this.task.Description;
                tbEsstimatedTime.Text = this.task.EstimatedTime.ToString();
                UserManagmentForm frm = new UserManagmentForm();
                List<User> userList = userRepo.GetAll();
                foreach (var usr in userList)
                {
                    lbAssignedTo.Items.Add(usr.UserName);
                }
                this.task.Assignedto = lbAssignedTo.SelectedIndex;

                btnSaveTask.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
                btnTskFrmCancel.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            }
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTitle.Text == "")
                {
                    MessageBox.Show("Please input title.");
                    return;
                }
                if (tbDescription.Text == "")
                {
                    MessageBox.Show("Please input description.");
                    return;
                }
                if (tbEsstimatedTime.Text == "")
                {
                    MessageBox.Show("Please input some time.");
                    return;
                }
                if (lbAssignedTo.SelectedIndex <= -1)
                {
                    MessageBox.Show("Please select user for assigning");
                    return;
                }
                else
                {
                    int id = 0;
                    string username = lbAssignedTo.Text;
                    UserManagmentForm frm = new UserManagmentForm();
                    List<User> userList = userRepo.GetAll();
                    foreach (var usr in userList)
                    {
                        if (usr.UserName == username)
                        {
                            id = usr.UserId;
                        }
                    }
                    task.Title = tbTitle.Text;
                    task.Description = tbDescription.Text;
                    task.EstimatedTime = int.Parse(tbEsstimatedTime.Text);
                    task.Assignedto = id;
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbAssignedTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAssignedTo.Show();
        }

        private void btnTskFrmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_EditTaskForm_Load(object sender, EventArgs e)
        {
            SendMessage(tbTitle.Handle, EM_SETCUEBANNER, 0, "Title");
            SendMessage(tbEsstimatedTime.Handle, EM_SETCUEBANNER, 0, "Estimated time");
            SendMessage(tbDescription.Handle, EM_SETCUEBANNER, 0, "Description");
        }

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
    }
}
