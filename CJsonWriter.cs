using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
namespace BLI.Data.Login
{
    public class CJsonWriter
    {
        public CJsonWriter()
        { }
        public void WriteUserJson(string username,String password , String Userid)
        {
            try
            {
                StreamReader reader = File.OpenText("User.json");
                JsonTextReader jsonTextReader = new JsonTextReader(reader);
                JObject jsonObject = (JObject)JToken.ReadFrom(jsonTextReader);
                jsonObject["username"] = username;
                jsonObject["password"] = password;
                jsonObject["userid"] = Userid;
                reader.Close();
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObject, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("User.json", output);
            }
            catch
            {
                Exception e;
            }
        }
    }
}
