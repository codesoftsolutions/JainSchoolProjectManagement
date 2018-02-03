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

namespace schoolmanagementdcmjain.Master
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void createuserbutton_Click(object sender, EventArgs e)
        {
            CreateUserModel createUser = new CreateUserModel();
            createUser._id = "";
            createUser.userName = username.Text;
            createUser.password = password.Text;
            createUser.name = name.Text;
            createUser.designation = designation.Text;
            Connection connection = new Connection();
            MySqlConnection mySqlConnection = connection.getConnection();

        }
    }
}
