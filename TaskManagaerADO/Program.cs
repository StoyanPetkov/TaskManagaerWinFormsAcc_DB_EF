using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager;
using TaskManager.WinForms;

namespace TaskManagaerADO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm logIn=new LoginForm();

            if (logIn.ShowDialog()==DialogResult.OK)
	        {
		         Application.Run(new MainForm());
	        }
            
        }
    }
}
