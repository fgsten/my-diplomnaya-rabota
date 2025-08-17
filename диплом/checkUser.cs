using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace диплом
{
    public  class checkUser
    {
        public string Longi {  get; set; }

        public bool IsAdmin { get; }

        public string Status => IsAdmin ? "Admin" : "User";

        public checkUser(string longi, bool isAdmin)
        {
            Longi = longi.Trim();
            IsAdmin = isAdmin;
        }
    }
}
