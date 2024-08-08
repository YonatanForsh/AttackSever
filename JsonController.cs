using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace AttackServer
{
    internal class JsonController
    {
        public static List<Missile> ReadJson(string JsonPath)
        {
            string text = File.ReadAllText(JsonPath);
            List<Missile> MIssileList = JsonSerializer.Deserialize< List < Missile >>(text);
            return MIssileList;
        }
    }
}
