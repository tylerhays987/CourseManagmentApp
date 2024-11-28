using CourseManagementApp.Services;


namespace CourseManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!UserSession.IsUserLoggedIn)
            {
                using (var loginForm = new LoginForm())
                {
                    loginForm.ShowDialog();

                    if (!UserSession.IsUserLoggedIn)
                    {
                        MessageBox.Show("You must log in to use the application.", "Access Denied",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close(); 
                    }
                }
            }
        }
        public void UpdateUserStatus(string userName)
        {
            toolStripStatusLabelUser.Text = $"Logged in as: {userName}";
        }
        private void LoginUser(string userName)
        {
            // Simulate login logic
            bool loginSuccessful = !string.IsNullOrEmpty(userName);

            if (loginSuccessful)
            {
                UpdateUserStatus(userName); 
                MessageBox.Show($"Welcome, {userName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotificationsForm notificationsForm = new NotificationsForm();
            notificationsForm.ShowDialog();
        }

        private void enrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!UserSession.IsUserLoggedIn)
            {
                MessageBox.Show("Please log in to access enrollment.", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            EnrollmentForm enrollmentForm = new EnrollmentForm();
            enrollmentForm.ShowDialog(); 
        }

        private void discussionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiscussionForm discussionForm = new DiscussionForm();
            discussionForm.ShowDialog();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseDetailsForm coursesForm = new CourseDetailsForm();
            coursesForm.ShowDialog();
        }
    }
}
