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
            public static string connectionString = "Server=localhost;Database=jainschool;Uid=root;Pwd=root";
        }

        public class ConstantStrings
        {
            public static string user_pwd_not_empty = "Username and Password Can't be empty";
            public static string confirmation = "Confirmation";
        }
    }
}
