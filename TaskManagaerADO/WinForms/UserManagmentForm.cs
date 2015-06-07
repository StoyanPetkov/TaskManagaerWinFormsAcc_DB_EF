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
using TMLib.Repository;

namespace TaskManager.WinForms
{
    public partial class UserManagmentForm : Form
    {
        private bool editMode = false;
        UserRepository userRepo = new UserRepository();

        public UserManagmentForm()
        {
            InitializeComponent();
            RefreshItems();
        }

        private void RefreshItems()
        {
            usrDataGrid.Rows.Clear();
            bindingSource1.DataSource = userRepo.GetAll();
            usrDataGrid.DataSource = bindingSource1;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User();
            Add_EditUserForm addForm = new Add_EditUserForm(user);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                userRepo.Save(user);
                RefreshItems();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User u = (User)bindingSource1.Current;
            editMode = true;
            Add_EditUserForm editForm = new Add_EditUserForm(u, editMode);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                userRepo.Save(u);
                RefreshItems();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = (User)bindingSource1.Current;
            DialogResult result = MessageBox.Show("Deleting... \nUsername: "
                + user.UserName + "\nFirst name: " + user.FirstName + "\nLast name: " + user.LastName,
                "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                userRepo.Delete(user);
                RefreshItems();
            }
            else
            {
                return;
            }
        }
    }
}
