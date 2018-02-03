using System;
using System.Windows.Forms;
using schoolmanagementdcmjain.Master.Models;
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

        private string getId()
        {
            return new User().getIdOfUser();
        }

        private void createuserbutton_Click(object sender, EventArgs e)
        {
            CreateUserModel createUser = new CreateUserModel();
            createUser._id = getId();
            if (createUser._id == Utility.Constants.emptyString)
            {
                MessageBox.Show(Utility.Constants.somethingWrong);
                return;
            }
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
            if (user.createUser(createUser))
            {
                DialogResult result = MessageBox.Show(Utility.Constants.userCreated, Master.Utility.Constants.confirmation, MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(Utility.Constants.somethingWrong, Master.Utility.Constants.confirmation, MessageBoxButtons.OK);
            }
        }
    }
}
