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
        public MySqlDataReader getLoginDetailsWithStoredProcedure(LoginDetail loginDetail, string procedureName)
        {
            Connection connection = new Connection();
            using (MySqlCommand cmd = new MySqlCommand(procedureName, connection.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usernameGet", loginDetail.userName);
                cmd.Parameters.AddWithValue("@passwordGet", loginDetail.password);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            };
        }
    }
}
