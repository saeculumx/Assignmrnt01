using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text.Json;
namespace BLI.Data.Login
{
    public class CJsonReader
    {
        private UserPackage UserPackage = new UserPackage();
        string username;
        string password;
        string id;
        private readonly string jsonFileName = "User.json";
        public CJsonReader()
        { 
         
        }
        public void read()
        {
            if (!File.Exists(jsonFileName))
            {
                update();
            }
            String json = File.ReadAllText(jsonFileName);
            UserPackage = System.Text.Json.JsonSerializer.Deserialize<UserPackage>(json);
        }
        public User getUserJson()
        {
            User user = new User(UserPackage.username,UserPackage.password);
            return user;

        }
        public void update()
        { 
            String json = System.Text.Json.JsonSerializer.Serialize(UserPackage,new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText(jsonFileName, json);
        }
        public  User GetUser()
        {
            try
            {
                StreamReader reader = File.OpenText("User.json");
                JsonTextReader jsonTextReader = new JsonTextReader(reader);
                JObject jsonObject = (JObject)JToken.ReadFrom(jsonTextReader);
                string username = jsonObject["username"].ToString();
                String password = jsonObject["password"].ToString();
                String userId = jsonObject["userid"].ToString();
                reader.Close();
                User user = new User(username, password);
                user.UserID = userId;
                return user ;
            }
            catch
            {
                Exception e;
                return null;
            }
        }
    }
}
