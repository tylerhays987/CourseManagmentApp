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
    public partial class EnrollmentForm : Form
    {
        public EnrollmentForm()
        {
            InitializeComponent();
            LoadAvailableCourses();
        }
        private void LoadAvailableCourses()
        {
            var courses = DataService.GetCourses();
            foreach (var course in courses)
            {
                listBoxCourses.Items.Add(course.Name); 
            }
        }
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (listBoxCourses.SelectedItem != null)
            {
                string selectedCourse = listBoxCourses.SelectedItem.ToString();
                listBoxSelectedCourses.Items.Add(selectedCourse); 
                listBoxCourses.Items.Remove(selectedCourse); 
            }
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedCourses.SelectedItem != null)
            {
                string selectedCourse = listBoxSelectedCourses.SelectedItem.ToString();
                listBoxCourses.Items.Add(selectedCourse); 
                listBoxSelectedCourses.Items.Remove(selectedCourse); 
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (UserSession.IsUserLoggedIn)
            {
                
                int userId = UserSession.LoggedInUser.Id;

                
                MessageBox.Show($"User {userId} is enrolling in courses.", "Enrollment Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You must be logged in to enroll in courses.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
