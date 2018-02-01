using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmanagementdcmjain.Utility
{
    public class Constants
    {
        public  class DatabaseConnection
        {
            public static string connectionString = "Server=localhost;Database=school;Uid=root;Pwd=root";

            public static string getConnectionString()
            {
                return connectionString;
            }
        }
    }
}
