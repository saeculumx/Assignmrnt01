using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLI.Data.Login
{
    public class Security
    {
        public static Boolean islogin = false;
        public void changeLogin()
        {
            if (islogin)
            {
                islogin = false;
            }
            else
            {
                islogin = true;
            }
        }
        public Boolean getLoginStatus()
        {
            return islogin;
        }
    }
}
