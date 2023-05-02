using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj_SftApps.DB
{
    public class User
    {
       public string userName { get; set; }
       public string password { get; set; }

        public User (string name, string pass)
        {
            userName = name;
            password = pass;
        }
    }
}
