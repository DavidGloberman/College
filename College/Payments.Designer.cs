namespace College
{
    partial class Form_Payments
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
            button_Payments = new Button();
            textBox_Payments = new TextBox();
            textBox_CourssName = new TextBox();
            textBox_StudentName = new TextBox();
            SuspendLayout();
            // 
            // button_Payments
            // 
            button_Payments.Location = new Point(93, 246);
            button_Payments.Name = "button_Payments";
            button_Payments.Size = new Size(191, 38);
            button_Payments.TabIndex = 8;
            button_Payments.Text = "תשלום";
            button_Payments.UseVisualStyleBackColor = true;
            // 
            // textBox_Payments
            // 
            textBox_Payments.Location = new Point(93, 154);
            textBox_Payments.Name = "textBox_Payments";
            textBox_Payments.Size = new Size(191, 27);
            textBox_Payments.TabIndex = 7;
            textBox_Payments.Text = "סכום";
            // 
            // textBox_CourssName
            // 
            textBox_CourssName.Location = new Point(93, 95);
            textBox_CourssName.Name = "textBox_CourssName";
            textBox_CourssName.Size = new Size(191, 27);
            textBox_CourssName.TabIndex = 6;
            textBox_CourssName.Text = "שם הקורס";
            // 
            // textBox_StudentName
            // 
            textBox_StudentName.Location = new Point(93, 45);
            textBox_StudentName.Name = "textBox_StudentName";
            textBox_StudentName.Size = new Size(191, 27);
            textBox_StudentName.TabIndex = 5;
            textBox_StudentName.Text = "שם התלמיד";
            // 
            // Form_Payments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 450);
            Controls.Add(button_Payments);
            Controls.Add(textBox_Payments);
            Controls.Add(textBox_CourssName);
            Controls.Add(textBox_StudentName);
            Name = "Form_Payments";
            Text = "Payments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Payments;
        private TextBox textBox_Payments;
        private TextBox textBox_CourssName;
        private TextBox textBox_StudentName;
    }
}