namespace College
{
    partial class Form_StudentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_StudentRegistration));
            textBox_Name = new TextBox();
            textBox_Phone = new TextBox();
            textBox_Gmail = new TextBox();
            textBox_Address = new TextBox();
            button_Registration = new Button();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            resources.ApplyResources(textBox_Name, "textBox_Name");
            textBox_Name.Name = "textBox_Name";
            // 
            // textBox_Phone
            // 
            resources.ApplyResources(textBox_Phone, "textBox_Phone");
            textBox_Phone.Name = "textBox_Phone";
            // 
            // textBox_Gmail
            // 
            resources.ApplyResources(textBox_Gmail, "textBox_Gmail");
            textBox_Gmail.Name = "textBox_Gmail";
            // 
            // textBox_Address
            // 
            resources.ApplyResources(textBox_Address, "textBox_Address");
            textBox_Address.Name = "textBox_Address";
            // 
            // button_Registration
            // 
            resources.ApplyResources(button_Registration, "button_Registration");
            button_Registration.Name = "button_Registration";
            button_Registration.UseVisualStyleBackColor = true;
            button_Registration.Click += button_Registration_Click;
            // 
            // Form_StudentRegistration
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Registration);
            Controls.Add(textBox_Address);
            Controls.Add(textBox_Gmail);
            Controls.Add(textBox_Phone);
            Controls.Add(textBox_Name);
            Name = "Form_StudentRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Name;
        private TextBox textBox_Phone;
        private TextBox textBox_Gmail;
        private TextBox textBox_Address;
        private Button button_Registration;
    }
}
