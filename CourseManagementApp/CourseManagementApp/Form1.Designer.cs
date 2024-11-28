namespace CourseManagementApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            notificationsToolStripMenuItem = new ToolStripMenuItem();
            enrollmentToolStripMenuItem = new ToolStripMenuItem();
            discussionsToolStripMenuItem = new ToolStripMenuItem();
            toolStripStatusLabelUser = new StatusStrip();
            panelContent = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { coursesToolStripMenuItem, notificationsToolStripMenuItem, enrollmentToolStripMenuItem, discussionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(61, 20);
            coursesToolStripMenuItem.Text = "Courses";
            coursesToolStripMenuItem.Click += coursesToolStripMenuItem_Click;
            // 
            // notificationsToolStripMenuItem
            // 
            notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            notificationsToolStripMenuItem.Size = new Size(87, 20);
            notificationsToolStripMenuItem.Text = "Notifications";
            notificationsToolStripMenuItem.Click += notificationsToolStripMenuItem_Click;
            // 
            // enrollmentToolStripMenuItem
            // 
            enrollmentToolStripMenuItem.Name = "enrollmentToolStripMenuItem";
            enrollmentToolStripMenuItem.Size = new Size(77, 20);
            enrollmentToolStripMenuItem.Text = "Enrollment";
            enrollmentToolStripMenuItem.Click += enrollmentToolStripMenuItem_Click;
            // 
            // discussionsToolStripMenuItem
            // 
            discussionsToolStripMenuItem.Name = "discussionsToolStripMenuItem";
            discussionsToolStripMenuItem.Size = new Size(80, 20);
            discussionsToolStripMenuItem.Text = "Discussions";
            discussionsToolStripMenuItem.Click += discussionsToolStripMenuItem_Click;
            // 
            // toolStripStatusLabelUser
            // 
            toolStripStatusLabelUser.Location = new Point(0, 428);
            toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            toolStripStatusLabelUser.Size = new Size(800, 22);
            toolStripStatusLabelUser.TabIndex = 1;
            toolStripStatusLabelUser.Text = "Logged in as: Guest";
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 24);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(800, 404);
            panelContent.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            Controls.Add(toolStripStatusLabelUser);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem notificationsToolStripMenuItem;
        private ToolStripMenuItem enrollmentToolStripMenuItem;
        private ToolStripMenuItem discussionsToolStripMenuItem;
        private StatusStrip toolStripStatusLabelUser;
        private Panel panelContent;
    }
}
