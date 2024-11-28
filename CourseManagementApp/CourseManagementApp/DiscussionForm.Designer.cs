namespace CourseManagementApp
{
    partial class DiscussionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstDiscussions = new ListBox();
            txtNewDiscussion = new TextBox();
            btnPost = new Button();
            SuspendLayout();
            // 
            // lstDiscussions
            // 
            lstDiscussions.Dock = DockStyle.Top;
            lstDiscussions.FormattingEnabled = true;
            lstDiscussions.ItemHeight = 15;
            lstDiscussions.Location = new Point(0, 0);
            lstDiscussions.Name = "lstDiscussions";
            lstDiscussions.Size = new Size(800, 94);
            lstDiscussions.TabIndex = 0;
            // 
            // txtNewDiscussion
            // 
            txtNewDiscussion.Dock = DockStyle.Bottom;
            txtNewDiscussion.Location = new Point(0, 350);
            txtNewDiscussion.Multiline = true;
            txtNewDiscussion.Name = "txtNewDiscussion";
            txtNewDiscussion.Size = new Size(800, 100);
            txtNewDiscussion.TabIndex = 1;
            // 
            // btnPost
            // 
            btnPost.Dock = DockStyle.Bottom;
            btnPost.Location = new Point(0, 327);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(800, 23);
            btnPost.TabIndex = 2;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click_1;
            // 
            // DiscussionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPost);
            Controls.Add(txtNewDiscussion);
            Controls.Add(lstDiscussions);
            Name = "DiscussionForm";
            Text = "DiscussionForm";
            Load += DiscussionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDiscussions;
        private TextBox txtNewDiscussion;
        private Button btnPost;
    }
}