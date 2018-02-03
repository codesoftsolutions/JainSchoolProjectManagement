using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolmanagementdcmjain.Master.Models
{
    class CreateUserModel
    {
        public string _id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public int userRollType { get; set; }
        public string designation { get; set; }
        public int isApproved { get; set; }


    }
}
