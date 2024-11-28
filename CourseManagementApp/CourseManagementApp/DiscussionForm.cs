using CourseManagementApp.Models;
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
    public partial class DiscussionForm : Form
    {
        public DiscussionForm()
        {
            InitializeComponent();
        }
        private void DiscussionsForm_Load(object sender, EventArgs e)
        {
            // Load discussions into the ListBox
            RefreshDiscussions();
        }



        private void RefreshDiscussions()
        {
            // Clear and reload the ListBox
            lstDiscussions.Items.Clear();
            var discussions = DiscussionService.GetDiscussions()
                .OrderByDescending(d => d.PostedOn) 
                .ToList();

            foreach (var discussion in discussions)
            {
                lstDiscussions.Items.Add($"[{discussion.PostedOn}] {discussion.User}: {discussion.Message}");
            }
        }

        private void btnPost_Click_1(object sender, EventArgs e)
        {
            // Get the new discussion text
            string message = txtNewDiscussion.Text.Trim();

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter a discussion message.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add the new discussion
            var newDiscussion = new Discussion
            {
                Id = DiscussionService.GetDiscussions().Count + 1,
                User = "LoggedInUser", 
                Message = message,
                PostedOn = DateTime.Now
            };
            DiscussionService.AddDiscussion(newDiscussion);

            // Clear the text box and refresh the discussions
            txtNewDiscussion.Clear();
            RefreshDiscussions();

            MessageBox.Show("Your discussion has been posted.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
