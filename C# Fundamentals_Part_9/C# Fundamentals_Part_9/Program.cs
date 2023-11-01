//C# Fundamentals_Part_9
//05:37:46 – Creating and Adding References to Assemblies

using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppliaction2 { 
    public class Scrape //Web scraper
    {
        public string ScrapeWebpage(string url) 
        {
            return GetWebpage(url);
        }

        public string ScrapeWebpage(string url, string filepath) 
        {
            string reply = GetWebpage(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebpage(string url)
        {
            WebClient client = GetClient();
            return client.DownloadString(url);
        }

        private static HttpClient GetClient()
        {
            return new HttpClient();
        }
    }
}


