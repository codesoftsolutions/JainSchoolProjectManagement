using MySql.Data.MySqlClient;
using schoolmanagementdcmjain.Database;
using schoolmanagementdcmjain.Master.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmanagementdcmjain.Master.Database
{
    class User
    {
        public bool createUser(CreateUserModel createUserModel)
        {
            try
            {
                Connection connection = new Connection();
                MySqlConnection mySqlConnection = connection.getConnection();
                string qry = "insert into create_user values('" + createUserModel._id + "','" + createUserModel.userName + "','" +
                    createUserModel.password + "','" + createUserModel.name + "'," + createUserModel.userRollType + ",'" + createUserModel.designation + "',"
                    + createUserModel.isApproved + ")";
                connection.insertData(qry);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
