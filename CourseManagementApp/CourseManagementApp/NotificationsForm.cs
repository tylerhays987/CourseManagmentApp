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
    public partial class NotificationsForm : Form
    {
        public NotificationsForm()
        {
            InitializeComponent();
            InitializeNotifications();
        }

        private void InitializeNotifications()
        {
            this.Text = "Notifications";
            this.Size = new System.Drawing.Size(400, 300);

            // Create a ListView to display notifications
            ListView notificationsListView = new ListView
            {
                Dock = DockStyle.Fill,
                View = View.Details,
                FullRowSelect = true
            };

            // Add a single column to display notifications
            notificationsListView.Columns.Add("Notification", -2, HorizontalAlignment.Left);

            // Sample notifications
            List<string> notifications = new List<string>
            {
                "Quiz grade updated",
                "New post on SODV2101",
                "Assignment due date approaching",
                "New message from Timothy Hawks",
                "Project 'Group Research' submission deadline approaching",
                "Grade updated for 'Final Exam in Data Structures'",
                "New announcement: Join the course webinar tomorrow",
                "SODV2101 Discussion topic created: 'Database Optimization Tips'",
                "Message from Professor Smith: Office hours updated",
                "Reminder: Submit your 'Data Structures' homework by 11:59 PM",
                "You have a new peer review for 'Web Development Group Project'",
                "Quiz 'Java Fundamentals' now available – Check your portal",
            };

            // Populate the ListView with notifications
            foreach (string notification in notifications)
            {
                notificationsListView.Items.Add(new ListViewItem(notification));
            }

            // Add the ListView to the form
            this.Controls.Add(notificationsListView);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Closes the NotificationsForm
        }
    }
}