using CourseManagementApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseManagementApp.Models;

namespace CourseManagementApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Simulated authentication logic
            var authenticatedUser = AuthenticateUser(username, password);
            if (authenticatedUser != null)
            {
                UserSession.Login(authenticatedUser); // Store user session
                MessageBox.Show($"Welcome, {authenticatedUser.Username}!", "Login Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private User AuthenticateUser(string username, string password)
        {
            var users = new List<User>
        {
            new User { Id = 1, Username = "student1", Role = "Student" },
            new User { Id = 2, Username = "instructor1", Role = "Instructor" }
        };

            return users.FirstOrDefault(u => u.Username == username && password == "password123");
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
