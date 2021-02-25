using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class User
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public DateTime Dob { get; set; }
        public int mobileNo { get; set; }

        public int Login(String UserName, String Password)
        {
            if (UserName == "onkar" && Password == "ok")
            {
                return 1;
            }
            else if(UserName == "srushti" && Password == "sru")
            {
                return 1;
            }
            else if (UserName == "hii" && Password == "bye")
            {
                return 1;
            }
            else if (UserName == "a" && Password == "a")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
