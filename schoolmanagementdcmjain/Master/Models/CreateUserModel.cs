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
        private string password { get; set; }
        private string name { get; set; }
        private int userRollType { get; set; }
        private string designation { get; set; }
        private string isApproved { get; set; }


    }
}
