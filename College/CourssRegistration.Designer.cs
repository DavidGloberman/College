namespace College
{
    partial class Form_CourssRegistration
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
            textBox_StudentName = new TextBox();
            textBox_CourssName = new TextBox();
            textBox_Cycle = new TextBox();
            listBox1 = new ListBox();
            button_Registration = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox_StudentName
            // 
            textBox_StudentName.Location = new Point(88, 43);
            textBox_StudentName.Name = "textBox_StudentName";
            textBox_StudentName.Size = new Size(191, 27);
            textBox_StudentName.TabIndex = 0;
            textBox_StudentName.Text = "שם התלמיד";
            // 
            // textBox_CourssName
            // 
            textBox_CourssName.Location = new Point(88, 93);
            textBox_CourssName.Name = "textBox_CourssName";
            textBox_CourssName.Size = new Size(191, 27);
            textBox_CourssName.TabIndex = 1;
            textBox_CourssName.Text = "שם הקורס";
            // 
            // textBox_Cycle
            // 
            textBox_Cycle.Location = new Point(88, 152);
            textBox_Cycle.Name = "textBox_Cycle";
            textBox_Cycle.Size = new Size(191, 27);
            textBox_Cycle.TabIndex = 2;
            textBox_Cycle.Text = "מחזור";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(106, 234);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 164);
            listBox1.TabIndex = 3;
            // 
            // button_Registration
            // 
            button_Registration.Location = new Point(88, 431);
            button_Registration.Name = "button_Registration";
            button_Registration.Size = new Size(191, 38);
            button_Registration.TabIndex = 4;
            button_Registration.Text = "הרשמה";
            button_Registration.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(115, 191);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 5;
            label1.Text = "הקורסים שלנו";
            // 
            // Form_CourssRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 512);
            Controls.Add(label1);
            Controls.Add(button_Registration);
            Controls.Add(listBox1);
            Controls.Add(textBox_Cycle);
            Controls.Add(textBox_CourssName);
            Controls.Add(textBox_StudentName);
            Name = "Form_CourssRegistration";
            Text = "CourssRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_StudentName;
        private TextBox textBox_CourssName;
        private TextBox textBox_Cycle;
        private ListBox listBox1;
        private Button button_Registration;
        private Label label1;
    }
}