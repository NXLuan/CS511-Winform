using Practice.TH1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Practice.TH1
{
    public static class DataService
    {
        private static string _jsonDataPath = @"../../TH1/data.json";

        public static User User { get; set; }

        public static void ReadData()
        {
            try
            {
                var JSON = File.ReadAllText(_jsonDataPath);
                User = JsonConvert.DeserializeObject<User>(JSON);
            }
            catch (Exception e)
            {
            }
        }

        public static void WriteData()
        {
            try
            {
                var JsonData = JsonConvert.SerializeObject(User);
                File.WriteAllText(_jsonDataPath, JsonData);
            }
            catch
            {
            }
        }
    }
}
