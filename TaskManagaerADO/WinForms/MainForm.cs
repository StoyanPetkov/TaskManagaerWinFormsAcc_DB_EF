using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMLib.Entities;
using TaskManager.Service;

namespace TaskManager.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Hello " + AuthenticateService.LoggedUser.UserName;
        }

        private void CreateMdiChild(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void usersManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMdiChild(new UserManagmentForm());
        }

        private void manageTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMdiChild(new TaskManagerForm());
        }

        private void manageTasksTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateMdiChild(new LogHistoryForm());
        }
    }
}
