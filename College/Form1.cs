using System.Data.SqlClient;
using System.Security.Policy;
using static College.Configuration.Connection;

namespace College
{
    public partial class Form_StudentRegistration : Form
    {
        public Form_StudentRegistration()
        {
            InitializeComponent();
        }

        private void button_Registration_Click(object sender, EventArgs e)
        {
            string Name = textBox_Name.Text;
            string Phone = textBox_Phone.Text;
            string Gmail = textBox_Gmail.Text;
            string Address = textBox_Address.Text;

            string quary = @"
                use College2;
                insert into [Student details] (Name, Phone, Gmail, Address, AccountBalance)
                values (
                    @Name,
                    @Phone,
                    @Gmail,
                    @Address,
                    0
                    );";

            using (SqlConnection conn = new(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new(quary, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Gmail", Gmail);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("נוספת בהצלחה לרשימת התלמידים שלנו");
                    this.Close();
                }
            }
        }
    }
}
