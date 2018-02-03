using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using schoolmanagementdcmjain.Master.Models;
using MySql.Data.MySqlClient;
using schoolmanagementdcmjain.Database;
using schoolmanagementdcmjain.Utility;
using schoolmanagementdcmjain.Master.Database;

namespace schoolmanagementdcmjain.Master
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
            usertype.SelectedIndex = 0;
        }

        private void createuserbutton_Click(object sender, EventArgs e)
        {
            CreateUserModel createUser = new CreateUserModel();
            createUser._id = "";
            createUser.userName = username.Text;
            createUser.password = passwordGet.Text;
            createUser.name = name.Text;
            createUser.designation = designation.Text;
            switch (usertype.SelectedIndex)
            {
                case (int)Constants.UserTypes.Accountant:
                    createUser.userRollType = (int)Constants.UserTypes.Accountant;
                    break;
                case (int)Constants.UserTypes.Clerk:
                    createUser.userRollType = (int)Constants.UserTypes.Clerk;
                    break;
                case (int)Constants.UserTypes.Teacher:
                    createUser.userRollType = (int)Constants.UserTypes.Teacher;
                    break;
                case (int)Constants.UserTypes.Admin:
                    createUser.userRollType = (int)Constants.UserTypes.Admin;
                    break;
                case (int)Constants.UserTypes.Librarian:
                    createUser.userRollType = (int)Constants.UserTypes.Librarian;
                    break;
                case (int)Constants.UserTypes.Laboratory:
                    createUser.userRollType = (int)Constants.UserTypes.Laboratory;
                    break;
            }
            if (yesRadioButton.Checked)
            {
                createUser.isApproved = (int)Constants.UserTypeApproved.Yes;
            }
            else
            {
                createUser.isApproved = (int)Constants.UserTypeApproved.No;
            }
            User user = new User();
            if(user.createUser(createUser))
            {
                MessageBox.Show(Constansts.Constants.userCreated);
            }
            else
            {
                MessageBox.Show(Constansts.Constants.somethingWrong);
            }
        }
    }
}
