using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmanagementdcmjain.Credentials.Utility
{
    class Constants
    {
        public static string emptyString = "";
        public static string user_pwd_not_empty = "Username and Password Can't be empty";
        public static string confirmation = "Confirmation";
        public static string loginSuccessfully = "User has been Login Successfully";
        public static string unAuthorizedAccess = "Unauthorized Access";
        public static string somethingWrong = "Something went wrong please try again later";
        public static string wrongUserNameAndPassword = "You have entered wrong username and password";
    }

    class StoredProcedure
    {
        public static string master_create_user = "master_user_login";
    }
}
