using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient3
{
    class Program
    {
        static void Main(string[] args)
        {
                foreach (var score in Livescore())
                {
                    Console.WriteLine("ID: "+score.Id);
                    Console.WriteLine("home_name: "+score.home_name);
                    Console.WriteLine("away_name: "+score.away_name);
                    Console.WriteLine("score: "+score.score);
                    Console.WriteLine("time: "+score.time);
                    Console.WriteLine("ht_score: "+score.ht_score);
                    Console.WriteLine("ft_score: "+score.ft_score);
                    Console.WriteLine("Status: "+ score.status);
                Console.WriteLine(score.time);
                    Console.WriteLine();
                }
            Console.ReadLine();
        }

        public class Client
        {
            public int Id { get; set; }
            public string home_name { get; set; }
            public string away_name { get; set; }
            public string score { get; set; }
            public string ht_score { get; set; }
            public string ft_score { get; set; }
            public string et_score { get; set; }
            [JsonProperty("time")]
            public string time { get; set; }
            //public string time { get { return time; } set { this.time = value; } }
            public string league_id { get; set; }
            public string status { get; set; }
            public string added { get; set; }
            public string last_changed { get; set; }
            public string home_id { get; set; }
            public string away_id { get; set; }
            public string evevts { get; set; }
            public string league_name { get; set; }
        }

       public static IList<Client> Livescore()
        {
            var demo_key = "6r94GgdPiJ5ciqdx";
            var demo_secret = "70Qx0KjZN2uD6jfdLohrFuhXem9wNm4U";
            var json = new WebClient().DownloadString($"http://livescore-api.com/api-client/scores/live.json?key={demo_key}&secret={demo_secret}");

            //Client post = JsonConvert.DeserializeObject<Client>(json);

            JObject liveSearch = JObject.Parse(json);

            IList<JToken> results = liveSearch["data"]["match"].Children().ToList();
            //IList<JToken> resultsContry = liveSearch["data"]["country"].Children().ToList();

            IList<Client> _client = new List<Client>();

            foreach (JToken result in results)
            {
                Client clientResult = result.ToObject<Client>();
                _client.Add(clientResult);
            }
            return _client;
        }

    }
}
