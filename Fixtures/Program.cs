//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FIstures
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}


using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Fixtures
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in _Fixtures())
            {
                Console.WriteLine("ID: " + item.Id);
                Console.WriteLine("Date: " + item.Date.ToString("MM/dd/yyyy"));
                Console.WriteLine("Time: " + item.Time);
                Console.WriteLine("Home_name: " + item.Home_name);
                Console.WriteLine("Away_name: " + item.Away_name);
                Console.WriteLine("Location: " + item.Location);
                Console.WriteLine("League_Id: " + item.League_id);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public class Fixtures
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public string Time { get; set; }
            public int Round { get; set; }
            public string Home_name { get; set; }
            public string Away_name { get; set; }
            public string Location { get; set; }
            public int League_id { get; set; }

        }

        private static IList<Fixtures> _Fixtures()
        {
            var demo_key = "6r94GgdPiJ5ciqdx";
            var demo_secret = "70Qx0KjZN2uD6jfdLohrFuhXem9wNm4U";
            var json = new WebClient().DownloadString($"http://livescore-api.com/api-client/fixtures/matches.json?key={demo_key}&secret={demo_secret}&page=2");

            JObject obj = JObject.Parse(json);

            IList<JToken> results = obj["data"]["fixtures"].Children().ToList();
            IList<Fixtures> _fixture = new List<Fixtures>();

            foreach (JToken result in results)
            {
                Fixtures datej = result.ToObject<Fixtures>();
                _fixture.Add(datej);
            }
            return _fixture;
        }
    }
}

