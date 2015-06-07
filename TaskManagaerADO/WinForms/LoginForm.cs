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

namespace TaskManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnLogIn.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnExit.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            AuthenticateService.AuthenticateUser(tbUsrName.Text, tbPass.Text);

            if (AuthenticateService.LoggedUser != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SendMessage(tbUsrName.Handle, EM_SETCUEBANNER, 0, "Username");
            SendMessage(tbPass.Handle, EM_SETCUEBANNER, 0, "Password");
        }

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

    }
}
