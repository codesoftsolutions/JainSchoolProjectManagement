using MySql.Data.MySqlClient;
using schoolmanagementdcmjain.Credentials.Models;
using schoolmanagementdcmjain.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmanagementdcmjain.Credentials.Database
{
    class GetLoginDetail
    {
        public MySqlDataReader getLoginDetails(LoginDetail loginDetail)
        {
            Connection connection = new Connection();
            MySqlConnection mySqlConnection = connection.getConnection();
            string qry = "select * from create_user where user_name='" + loginDetail.userName + "'" +
                " and password='" + loginDetail.password + "'";
            return connection.selectDataQuery(qry);
        }
    }
}
