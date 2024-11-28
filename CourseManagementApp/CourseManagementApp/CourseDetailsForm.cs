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
    public partial class CourseDetailsForm : Form
    {
        public CourseDetailsForm()
        {
            InitializeComponent();
        }
        private void CoursesDetailsForm_Load(object sender, EventArgs e)
        {
            // Fetch courses and bind them to the DataGridView
            var courses = CourseService.GetCourses();
            dgvCourses.DataSource = courses;

            // Adjust column display
            dgvCourses.Columns["Id"].Visible = false; // Hide ID column
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
