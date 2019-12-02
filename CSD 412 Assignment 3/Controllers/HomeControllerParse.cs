using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NewsApp_by_Group_D.Controllers
{
    class Article
    {

        public string id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public int totalResults { get; set; }
        public string urlToImage { get; set; }
        public string publishedAt { get; set; }
        public string content { get; set; }

        public override string ToString()
        {
            string s = "";

            s += $"Sourse id:{id}\nSourse name: {name}\narticle aouthor:{author}\narticle title: {title}\narticle description: {description}\narticle url: {url}\n published at {publishedAt}\ncontent: {content}";

            return s;
        }
    }
    class NewsAPIParse
    {
        public NewsAPIParse(){

            }
        static void Parse()
        {


            Console.WriteLine("==================================================");

            string jsonText = "";

            WebClient client = new WebClient();
            try
            {
                Stream stream = client.OpenRead("https://newsapi.org/v2/top-headlines?country=us&apiKey=1085fdb5600240acbd2b45cc9d32361d");
                using (StreamReader reader = new StreamReader(stream))
                {
                    jsonText = reader.ReadToEnd();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("A network error occurred.  " + ex.Message);
                Console.WriteLine("Unable to continue.");
                return;
            }

            JObject newsJO = JObject.Parse(jsonText);
            var articlesJA = newsJO["articles"].Children().ToList();

            var articles = new List<Article>();
            foreach (var item in articlesJA)
            {
                articles.Add(item.ToObject<Article>());
            }


            foreach (Article article in articles)
            {

                Console.WriteLine(article);
            }


            Console.ReadLine();
        }
    }
}
