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
using TMLib.Entities;
using TMLib.Repository;

namespace TaskManager.WinForms
{
    public partial class Add_EditUserForm : Form
    {
        private User user;

        public Add_EditUserForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.user.UserName = tbUsrName.Text;
            this.user.Password = tbPass.Text;
            this.user.FirstName = tbFname.Text;
            this.user.LastName = tbLname.Text;
            btnSaveUser.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnUsrFrmCancel.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
        }

        public Add_EditUserForm(User user,bool editMode)
        {
            InitializeComponent();
            if (editMode == true)
            {
                this.user = user;
                tbUsrName.Text = this.user.UserName;
                tbPass.Text = this.user.Password;
                tbFname.Text = this.user.FirstName;
                tbLname.Text = this.user.LastName;
                btnSaveUser.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
                btnUsrFrmCancel.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbUsrName.Text == "")
            {
                MessageBox.Show("Please input username.");
                return;
            }
            if (tbPass.Text == "")
            {
                MessageBox.Show("Please input password.");
                return;
            }
            if (tbFname.Text == "")
            {
                MessageBox.Show("Please input first name.");
                return;
            }
            if (tbLname.Text == "")
            {
                MessageBox.Show("Please input username.");
                return;
            }
            else
            {
                user.UserName = tbUsrName.Text;
                user.Password = tbPass.Text;
                user.FirstName = tbFname.Text;
                user.LastName = tbLname.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        private void Add_EditUserForm_Load(object sender, EventArgs e)
        {
            SendMessage(tbFname.Handle, EM_SETCUEBANNER, 0, "first name");
            SendMessage(tbLname.Handle, EM_SETCUEBANNER, 0, "last name");
            SendMessage(tbPass.Handle, EM_SETCUEBANNER, 0, "password");
            SendMessage(tbUsrName.Handle, EM_SETCUEBANNER, 0, "username");
        }
    }
}
