using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmanagementdcmjain.Utility
{
    public class Constants
    {
        public class DatabaseConnection
        {
            private static string server="localhost";
            private static string database = "jainschool";
            private static string userId = "root";
            private static string password = "root";
            public static string connectionString = "Server="+ server + ";"+"Database="+database+";"+"Uid="+userId+";"+"Pwd="+password+"";
        }

        public class ConstantStrings
        {
            public static string user_pwd_not_empty = "Username and Password Can't be empty";
            public static string confirmation = "Confirmation";
        }
    }
}
