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
                        this.Close(); // Exit the application
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
                UpdateUserStatus(userName); // Update the StatusStrip
                MessageBox.Show($"Welcome, {userName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
