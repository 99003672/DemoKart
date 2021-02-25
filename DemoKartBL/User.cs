using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class User
    {
       
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public DateTime Dob { get; set; }
            public int MobileNo { get; set; }

            public int Login(String UserName, String Password)
            {
                if (UserName == "shrishti" && Password == "shri")
                {
                    return 1;
                }
                else if (UserName == "onkar" && Password == "ok")
                {
                    return 1;
                }
                else if (UserName == "shri" && Password == "shub")
                {
                    return 1;
                }
                else if (UserName == "adya" && Password == "appu")
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

