using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace schoolmanagementdcmjain.Database
{
    class Connection
    {
        MySqlConnection mySqlConnection = null;
        public MySqlConnection makeConnection()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(Utility.Constants.DatabaseConnection.connectionString);
            return mySqlConnection;
        }

        public MySqlConnection getConnection()
        {
            MySqlConnection mySqlConnection = makeConnection();
            if (mySqlConnection == null)
            {
               mySqlConnection.Open();
            }
            return mySqlConnection;
        }

    }
}
