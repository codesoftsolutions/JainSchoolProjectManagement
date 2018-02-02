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
            if (mySqlConnection == null)
            {
                mySqlConnection = makeConnection();
                mySqlConnection.Open();
            }
            else
            {
                if(mySqlConnection.State==System.Data.ConnectionState.Closed)
                {
                    mySqlConnection.Open();
                }
            }
            return mySqlConnection;
        }

        public Boolean insertData(string qry)
        {
            getConnection();
            MySqlCommand cmd = new MySqlCommand(qry, mySqlConnection);
            cmd.ExecuteNonQuery();
            return true;
        }
        public Boolean selectDataQuery(string qry)
        {
            getConnection();
            MySqlCommand cmd = new MySqlCommand(qry, mySqlConnection);
            cmd.ExecuteReader();
            return true;
        }

        public Boolean updateData(string qry)
        {
            getConnection();
            MySqlCommand cmd = new MySqlCommand(qry, mySqlConnection);
            return true;
        }

        public Boolean deleteData(string qry)
        {
            getConnection();
            MySqlCommand cmd = new MySqlCommand(qry, mySqlConnection);
            return true;
        }

        public void closeConnection()
        {
            if (mySqlConnection!=null&&mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                mySqlConnection.Open();
            }
        }

    }
}
