using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CSD_412_Assignment_3.Models;
using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;
using NewsApp_by_Group_D.Models;
using CSD_412_Assignment_3.Controllers;
using NewsApp_by_Group_D.Controllers;

namespace CSD_412_Assignment_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /*
        private List<NewsEntry> parseJson(string json)
       // private string parseJson(string json)
        {

            string startPattern = "^[\\w\\W]+:\\[";
            string endPattern = "\\]\\}$";

            json = Regex.Replace(json, startPattern, "");
            json = Regex.Replace(json, endPattern, "");
            json = Regex.Replace(json, "},{", "},,{");
           // return json;
            
            string[] articles = Regex.Split(json, "},,{");
            List<NewsEntry> NewsEntries = new List<NewsEntry>();
            foreach(string s in articles)
            { NewsEntries.Add(JsonSerializer.Deserialize<NewsEntry>(s)); }

            return NewsEntries;
        }
        */




        NewsAPIParse parse1 = new NewsAPIParse();



        public IActionResult Index(){
           // List<NewsEntry>


            var url = "https://newsapi.org/v2/top-headlines?country=us&apiKey=1085fdb5600240acbd2b45cc9d32361d";
            var json = new WebClient().DownloadString(url);


            //  Console.WriteLine(json);

              return View(parse1);
          // return new ContentResult { Content = parseJson(json) };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
