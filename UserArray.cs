using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLI.Data.Login
{
    public class UserArray
    {
        private List<User> Users;
        private List<string> UserNameArray;
        private List<string> PasswordArray;
        private List<String> IdList;
        public UserArray()
        {
            Users = new List<User>();
         UserNameArray = new List<string>();
         PasswordArray = new List<string>();
        IdList = new List<String>();
    }
        public String error { get; set; }
        public void addUser(User user)
        {
            Users.Add(user);
            UserNameArray.Add(user.UserName);
            PasswordArray.Add(user.PassWord);
            String a = Guid.NewGuid().ToString();
            user.UserID = a;
            IdList.Add(a);
        }
        public int Count()
        {
            return Users.Count;
        }
        public IList<User> getUserArray()
        {
            return Users;
        }
        public User getUser(int index)
        {
            return Users[index];
        }
        public User getUserByUser(User user)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (user.UserName.Equals(Users[i].UserName))
                {
                    return Users[i];
                }
            }
            Console.WriteLine("UserNotFound");
            return null;
        }
        public String getError()
        {
            return error;
        }
        public String getId(int index)
        {
            return Users[index].UserID;
        }
        public void addUserExisting(User user)
        {
            Users.Add(user);

        }
        public void reg(String UserName, String Password)
        {
            if (UserName != "" || Password != "")
            {
                User user = new User(UserName, Password);
                addUser(user);
                UserNameArray.Add(user.UserName);
                PasswordArray.Add(user.PassWord);
                IdList.Add(user.UserID);
            }
            else
            {
                error = "Not supported Username/Password";
            }
        }
        public Boolean LoginVerify(String UserName, String Password)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].UserName.Equals(UserName))
                {
                    a = i+1;
                    break;
                }
                else
                {
                    error = "No Match UserName/PassWord Found.";
                    break;
                }
            }
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].PassWord.Equals(Password))
                {
                    b = i+1;
                    break;
                }
                else
                {
                    error = "No Match UserName/PassWord Found.";
                    break;
                }
            }
            if (a == b || a != 0 || b != 0)
            {
                return true;
            }
            else
            {
                error = "";
                error = "PassWord does not match UserName";
                return false; 
            }
        }
    }
}
