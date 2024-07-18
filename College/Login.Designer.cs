namespace College
{
    partial class Form_Login
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
            button_AddCourse = new Button();
            button_StudentRegistration = new Button();
            button_RegistrationCourse = new Button();
            button_AddCycle = new Button();
            button_Payments = new Button();
            button_AddLecturers = new Button();
            button_AddLecturersSubject = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_AddCourse
            // 
            button_AddCourse.Location = new Point(269, 99);
            button_AddCourse.Name = "button_AddCourse";
            button_AddCourse.Size = new Size(114, 51);
            button_AddCourse.TabIndex = 0;
            button_AddCourse.Text = "הוספת קורס חדש";
            button_AddCourse.UseVisualStyleBackColor = true;
            // 
            // button_StudentRegistration
            // 
            button_StudentRegistration.Location = new Point(71, 99);
            button_StudentRegistration.Name = "button_StudentRegistration";
            button_StudentRegistration.Size = new Size(114, 72);
            button_StudentRegistration.TabIndex = 1;
            button_StudentRegistration.Text = "רישום תלמיד למכללה";
            button_StudentRegistration.UseVisualStyleBackColor = true;
            button_StudentRegistration.Click += button_StudentRegistration_Click;
            // 
            // button_RegistrationCourse
            // 
            button_RegistrationCourse.Location = new Point(71, 212);
            button_RegistrationCourse.Name = "button_RegistrationCourse";
            button_RegistrationCourse.Size = new Size(114, 72);
            button_RegistrationCourse.TabIndex = 3;
            button_RegistrationCourse.Text = "הרשמה לקורס";
            button_RegistrationCourse.UseVisualStyleBackColor = true;
            button_RegistrationCourse.Click += button_RegistrationCourse_Click;
            // 
            // button_AddCycle
            // 
            button_AddCycle.Location = new Point(269, 184);
            button_AddCycle.Name = "button_AddCycle";
            button_AddCycle.Size = new Size(114, 51);
            button_AddCycle.TabIndex = 2;
            button_AddCycle.Text = "הוספת מחזור חדש";
            button_AddCycle.UseVisualStyleBackColor = true;
            // 
            // button_Payments
            // 
            button_Payments.Location = new Point(71, 324);
            button_Payments.Name = "button_Payments";
            button_Payments.Size = new Size(114, 72);
            button_Payments.TabIndex = 5;
            button_Payments.Text = "תשלום";
            button_Payments.UseVisualStyleBackColor = true;
            button_Payments.Click += button_Payments_Click;
            // 
            // button_AddLecturers
            // 
            button_AddLecturers.Location = new Point(269, 267);
            button_AddLecturers.Name = "button_AddLecturers";
            button_AddLecturers.Size = new Size(114, 51);
            button_AddLecturers.TabIndex = 4;
            button_AddLecturers.Text = "הוספת מרצה חדש";
            button_AddLecturers.UseVisualStyleBackColor = true;
            // 
            // button_AddLecturersSubject
            // 
            button_AddLecturersSubject.Location = new Point(269, 345);
            button_AddLecturersSubject.Name = "button_AddLecturersSubject";
            button_AddLecturersSubject.Size = new Size(114, 51);
            button_AddLecturersSubject.TabIndex = 6;
            button_AddLecturersSubject.Text = "הוספת מרצה ונושא לקורס";
            button_AddLecturersSubject.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.Location = new Point(71, 28);
            label1.Name = "label1";
            label1.Size = new Size(319, 40);
            label1.TabIndex = 7;
            label1.Text = "ברוכים הבאים למכללה";
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(label1);
            Controls.Add(button_AddLecturersSubject);
            Controls.Add(button_Payments);
            Controls.Add(button_AddLecturers);
            Controls.Add(button_RegistrationCourse);
            Controls.Add(button_AddCycle);
            Controls.Add(button_StudentRegistration);
            Controls.Add(button_AddCourse);
            Name = "Form_Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button button_AddCourse;
        private Button button_StudentRegistration;
        private Button button_RegistrationCourse;
        private Button button_AddCycle;
        private Button button_Payments;
        private Button button_AddLecturers;
        private Button button_AddLecturersSubject;
        private Label label1;
    }
}
