using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSD_412_Assignment_3.Models
{

    public class Source
    {
        public string id { get; set; }
        public string name { get; set; }

    }

    public class NewsEntry {
        public Source source { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public string publishedAt { get; set; }
        public string content { get; set; }





    }
}
