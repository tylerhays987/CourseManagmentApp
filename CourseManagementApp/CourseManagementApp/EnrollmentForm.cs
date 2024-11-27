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
                listBoxCourses.Items.Add(course.Name); // Display course name
            }
        }
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (listBoxCourses.SelectedItem != null)
            {
                string selectedCourse = listBoxCourses.SelectedItem.ToString();
                listBoxSelectedCourses.Items.Add(selectedCourse); // Add to selected courses
                listBoxCourses.Items.Remove(selectedCourse); // Remove from available courses
            }
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedCourses.SelectedItem != null)
            {
                string selectedCourse = listBoxSelectedCourses.SelectedItem.ToString();
                listBoxCourses.Items.Add(selectedCourse); // Add back to available courses
                listBoxSelectedCourses.Items.Remove(selectedCourse); // Remove from selected courses
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedCourses.Items.Count > 0)
            {
                List<string> enrolledCourses = listBoxSelectedCourses.Items.Cast<string>().ToList();

                // Save the enrolled courses (using DataService or custom logic)
                int userId = LoggedInUser.Id; // Assume you have a way to get the logged-in user's ID
                foreach (var courseName in enrolledCourses)
                {
                    var course = DataService.GetCourses().FirstOrDefault(c => c.Name == courseName);
                    if (course != null)
                    {
                        DataService.EnrollUserInCourse(userId, course.CourseId);
                    }
                }

                MessageBox.Show("You have successfully enrolled in the selected courses.",
                    "Enrollment Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close(); // Close the form
            }
            else
            {
                MessageBox.Show("Please select at least one course to enroll in.",
                    "No Courses Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
