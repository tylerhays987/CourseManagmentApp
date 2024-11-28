namespace CourseManagementApp
{
    partial class EnrollmentForm
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
            label1 = new Label();
            listBoxCourses = new ListBox();
            label2 = new Label();
            listBoxSelectedCourses = new ListBox();
            btnAddCourse = new Button();
            btnRemoveCourse = new Button();
            btnEnroll = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Available Courses";
            // 
            // listBoxCourses
            // 
            listBoxCourses.FormattingEnabled = true;
            listBoxCourses.ItemHeight = 15;
            listBoxCourses.Location = new Point(12, 83);
            listBoxCourses.Name = "listBoxCourses";
            listBoxCourses.Size = new Size(120, 94);
            listBoxCourses.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 55);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Selected Courses";
            // 
            // listBoxSelectedCourses
            // 
            listBoxSelectedCourses.FormattingEnabled = true;
            listBoxSelectedCourses.ItemHeight = 15;
            listBoxSelectedCourses.Location = new Point(268, 83);
            listBoxSelectedCourses.Name = "listBoxSelectedCourses";
            listBoxSelectedCourses.Size = new Size(120, 94);
            listBoxSelectedCourses.TabIndex = 3;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(151, 83);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(86, 23);
            btnAddCourse.TabIndex = 4;
            btnAddCourse.Text = "Add Course";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // btnRemoveCourse
            // 
            btnRemoveCourse.Location = new Point(156, 120);
            btnRemoveCourse.Name = "btnRemoveCourse";
            btnRemoveCourse.Size = new Size(75, 23);
            btnRemoveCourse.TabIndex = 5;
            btnRemoveCourse.Text = "Remove Course";
            btnRemoveCourse.UseVisualStyleBackColor = true;
            btnRemoveCourse.Click += btnRemoveCourse_Click;
            // 
            // btnEnroll
            // 
            btnEnroll.Location = new Point(151, 393);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(75, 23);
            btnEnroll.TabIndex = 6;
            btnEnroll.Text = "Enroll";
            btnEnroll.UseVisualStyleBackColor = true;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(37, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EnrollmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnEnroll);
            Controls.Add(btnRemoveCourse);
            Controls.Add(btnAddCourse);
            Controls.Add(listBoxSelectedCourses);
            Controls.Add(label2);
            Controls.Add(listBoxCourses);
            Controls.Add(label1);
            Name = "EnrollmentForm";
            Text = "EnrollmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxCourses;
        private Label label2;
        private ListBox listBoxSelectedCourses;
        private Button btnAddCourse;
        private Button btnRemoveCourse;
        private Button btnEnroll;
        private Button btnCancel;
    }
}