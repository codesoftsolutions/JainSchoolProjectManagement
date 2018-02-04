using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using schoolmanagementdcmjain.Database;
using System.Threading;
using schoolmanagementdcmjain.Credentials.Models;
using schoolmanagementdcmjain.Credentials.Database;

namespace schoolmanagementdcmjain
{
    public partial class loginpanel : Form
    {
        Thread openMainPanelThread;
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
                MessageBox.Show(Credentials.Utility.Constants.user_pwd_not_empty, Credentials.Utility.Constants.confirmation, MessageBoxButtons.OK);
            }
            else
            {
                LoginDetail loginDetail = new LoginDetail();
                loginDetail.userName = userName.Text;
                loginDetail.password = password.Text;
                GetLoginDetail getLoginDetail = new GetLoginDetail();
                MySqlDataReader mySqlDataReader;
                mySqlDataReader = getLoginDetail.getLoginDetailsWithStoredProcedure(loginDetail, Credentials.Utility.StoredProcedure.master_create_user);
                if (mySqlDataReader.Read())
                {
                    switch(mySqlDataReader.GetInt32("isApproved"))
                    {
                        case (int)Utility.Constants.UserTypeApproved.Yes:
                            MessageBox.Show(Credentials.Utility.Constants.loginSuccessfully, Credentials.Utility.Constants.confirmation, MessageBoxButtons.OK);
                            openMainPanelThread = new Thread(openMainPanel);
                            openMainPanelThread.SetApartmentState(ApartmentState.STA);
                            openMainPanelThread.Start();
                            this.Close();
                            break;
                        case (int)Utility.Constants.UserTypeApproved.No:
                            MessageBox.Show(Credentials.Utility.Constants.unAuthorizedAccess, Credentials.Utility.Constants.confirmation, MessageBoxButtons.OK);
                            break;
                    }
                    
                }
                else
                {
                    MessageBox.Show(Credentials.Utility.Constants.wrongUserNameAndPassword, Credentials.Utility.Constants.confirmation, MessageBoxButtons.OK);
                }

            }


        }

        private void openMainPanel()
        {
            Application.Run(new mainpanel());
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
