using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Country
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in _Country())
            {
                Console.WriteLine("ID: "+item.Id);
                Console.WriteLine("home_name: "+item.Home_name);
                Console.WriteLine("score: "+item.Score);
                Console.WriteLine("ht_score: "+item.Ht_score);
                Console.WriteLine("ft_score: "+item.Ft_score);
                Console.WriteLine("et_score: "+item.Et_score);
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public class Country
        {
        public int Id { get; set; }
        public string Home_name { get; set; }
        public string Score { get; set; }
        public string Ht_score { get; set; }
        public string Ft_score { get; set; }
        public string Et_score { get; set; }

        }

    private static IList<Country> _Country()
        {
            var demo_key = "6r94GgdPiJ5ciqdx";
            var demo_secret = "70Qx0KjZN2uD6jfdLohrFuhXem9wNm4U";
            var json = new WebClient().DownloadString($"http://livescore-api.com/api-client/scores/live.json?key={demo_key}&secret={demo_secret}&country=47");

            JObject liveSearch = JObject.Parse(json);

            IList<JToken> results = liveSearch["data"]["match"].Children().ToList();

            IList<Country> _country = new List<Country>();

            foreach (JToken result in results)
            {
                Country clientResult = result.ToObject<Country>();
                _country.Add(clientResult);
            }
            return _country;
        }
    }
}
