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

        // Load courses into the available courses ListBox
        private void LoadAvailableCourses()
        {
            var courses = CourseService.GetCourses(); 
            foreach (var course in courses)
            {
                listBoxCourses.Items.Add(course.Name);
            }
        }

        // Add a course to the selected courses ListBox
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (listBoxCourses.SelectedItem != null)
            {
                string selectedCourse = listBoxCourses.SelectedItem.ToString();
                listBoxSelectedCourses.Items.Add(selectedCourse);
                listBoxCourses.Items.Remove(selectedCourse);
            }
        }

        // Remove a course from the selected courses ListBox
        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedCourses.SelectedItem != null)
            {
                string selectedCourse = listBoxSelectedCourses.SelectedItem.ToString();
                listBoxCourses.Items.Add(selectedCourse);
                listBoxSelectedCourses.Items.Remove(selectedCourse);
            }
        }

        // Enroll in selected courses
        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (UserSession.IsUserLoggedIn)
            {
                int userId = UserSession.LoggedInUser.Id;

                if (listBoxSelectedCourses.Items.Count > 0)
                {
                    var enrolledCourses = string.Join(", ", listBoxSelectedCourses.Items.Cast<string>());
                    MessageBox.Show($"User {userId} has enrolled in: {enrolledCourses}.", "Enrollment Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No courses selected for enrollment.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("You must be logged in to enroll in courses.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel and close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
