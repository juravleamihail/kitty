using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kitty.Reader
{
    public static class JsonLocationReader
    {
        //private static List<Location> locations;

        public static string ReadJsonFile()

        {

            string json = string.Empty;

            using (StreamReader r = new StreamReader("C:\\Users\\iquest\\Source\\Repos\\kitty\\kitty\\Kitty\\countriesToCities.json"))

            {

                json = r.ReadToEnd();

                dynamic array = JsonConvert.DeserializeObject(json);

            }

            return json;

        }

        public static string[] SplitCities(string input)
        {
            string[] result = null;

            char[] delimiterChars = { ' ', '"', '{', '}', ',', '/', '\\', '.', ':', '[', ']', '\t' };
            result = input.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
          

            return result;
        }
    }
}
