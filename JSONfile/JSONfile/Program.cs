using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JSONfile
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadJson();

            Console.ReadLine();

        }

        public static void LoadJson()
        {
            string newitems;

            using (StreamReader r = new StreamReader("../../AdminSettings.json"))
            {
                var json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<AdminSettings>(json);

                items.onstage = "Hello World";

                newitems = JsonConvert.SerializeObject(items, Formatting.Indented);
            }

            //FileStream stream = new FileStream("../../AdminSettings.json", FileMode.OpenOrCreate);
            using (StreamWriter writer = new StreamWriter("../../AdminSettings.json", false, Encoding.UTF8))
            {

                writer.Write(newitems);
            }
        }
    


        public class AdminSettings
        {
            public string current_season { get; set; }
            public SeasonProductions season_productions { get; set; }
            public RecentDefinition recent_definition { get; set; }
            public string onstage { get; set; }
        }

        public class SeasonProductions
        {
            public string fall { get; set; }
            public string winter { get; set; }
            public string spring { get; set; }
        }

        public class RecentDefinition
        {
            public string span { get; set; }
            public string date { get; set; }
        }

    }


}
