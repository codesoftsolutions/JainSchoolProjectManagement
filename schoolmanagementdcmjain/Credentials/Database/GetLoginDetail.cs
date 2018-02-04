using MySql.Data.MySqlClient;
using schoolmanagementdcmjain.Credentials.Models;
using schoolmanagementdcmjain.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmanagementdcmjain.Credentials.Database
{
    class GetLoginDetail
    {
        //we can use either query inside our code
        public MySqlDataReader getLoginDetails(LoginDetail loginDetail)
        {
            Connection connection = new Connection();
            connection.getConnection();
            string qry = "select * from create_user where user_name='" + loginDetail.userName + "'" +
                " and password='" + loginDetail.password + "'";
            return connection.selectDataQuery(qry);
        }

        //we can use storedprocedure so that query is made on server side and focus on our business logic
        public MySqlDataReader getLoginDetailsWithStoredProcedure(LoginDetail loginDetail, string procedureName)
        {
            using (MySqlCommand cmd = new MySqlCommand(procedureName, new Connection().getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usernameGet", loginDetail.userName);
                cmd.Parameters.AddWithValue("@passwordGet", loginDetail.password);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            };
        }
    }
}
