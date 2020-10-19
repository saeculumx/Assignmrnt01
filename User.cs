using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLI.Data.Login
{
    public class User
    {
        
        public string UserName { get; set; }
        public String PassWord { get; set; }
        public String UserID { get; set; }
        public User(String UN,String PW)
        {
            this.UserName = UN;
            this.PassWord = PW;
        }

    }
}
