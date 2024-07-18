using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private void button_Payments_Click(object sender, EventArgs e)
        {
            var newForm = new Form_Payments();
            this.Hide();
            newForm.Show();

        }
        
        private void button_StudentRegistration_Click(object sender, EventArgs e)
        {
            var newForm = new Form_StudentRegistration();
            this.Hide();
            newForm.Show();
        }

        private void button_RegistrationCourse_Click(object sender, EventArgs e)
        {
            var newForm = new Form_CourssRegistration();
            this.Hide();
            newForm.Show();
        }

    }
}
