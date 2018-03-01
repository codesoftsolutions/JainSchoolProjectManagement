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
            public static string emptyString = "";
        }

        public enum UserTypes
        {
            Accountant=0,Clerk=1,Teacher=2,Admin=3,Librarian=4,Laboratory=5
        }

        public enum UserTypeApproved
        {
            Yes=1,No=0
        }
    }
}
