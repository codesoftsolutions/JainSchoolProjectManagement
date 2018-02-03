using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using schoolmanagementdcmjain.Database;

namespace schoolmanagementdcmjain
{
    public partial class loginpanel : Form
    {
        public loginpanel()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userName.Text) || String.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show(Utility.Constants.ConstantStrings.user_pwd_not_empty, Utility.Constants.ConstantStrings.confirmation, MessageBoxButtons.OK);
            }
            else
            {
                string userNameGet = userName.Text;
                string paswordGet = password.Text;
                Connection connection = new Connection();
                MySqlConnection mySqlConnection = connection.getConnection();
                if (mySqlConnection != null)
                {
                    MessageBox.Show(Utility.Constants.ConstantStrings.confirmation, Utility.Constants.ConstantStrings.confirmation, MessageBoxButtons.OK);
                }
                
                mainpanel mp = new mainpanel();
                mp.Show();
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
