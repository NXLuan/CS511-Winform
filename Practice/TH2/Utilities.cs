using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.TH2
{
    public class FileHelper
    {
        private static string rootPath = @"../../TH2/Data/";

        public static T ReadData<T>(string file)
        {
            try
            {
                var json = File.ReadAllText(rootPath + file);
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch
            {
                return default(T);
            }
        }

        public static void WriteData<T>(T data, string file)
        {
            try
            {
                var JsonData = JsonConvert.SerializeObject(data);
                File.WriteAllText(rootPath + file, JsonData);
            }
            catch
            {
            }
        }
    }

    public static class FormatHelper
    {
        public static string MoneyVN(decimal value)
        {
            return value == 0 ? "0 đ" : String.Format("{0:#,#} đ", value);
        }

        public static string DayMonthYear(DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy");
        }
    }
}
