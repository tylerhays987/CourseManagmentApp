using System;
using System.Windows.Forms;
using CourseManagementApp.Services;

namespace CourseManagementApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            using (var loginForm = new LoginForm())
            {
                loginForm.ShowDialog();

                
                if (UserSession.IsUserLoggedIn)
                {
                    Application.Run(new Form1());
                }
                else
                {
                    
                    MessageBox.Show("You must log in to access the application.", "Access Denied",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}