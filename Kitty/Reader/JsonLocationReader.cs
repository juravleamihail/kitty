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

        public static IEnumerable<string> Cities()
        {

            // List<string> cities;
             string json = string.Empty;

            using (StreamReader r = new StreamReader("C:\\Users\\iquest\\Source\\Repos\\kitty\\kitty\\Kitty\\countriesToCities.json"))
            {

                json = r.ReadToEnd();

                dynamic array = JsonConvert.DeserializeObject(json);

                foreach (string city in array.Romania)
                {
                    yield return city;
                }
            }         

        }

    }
}
