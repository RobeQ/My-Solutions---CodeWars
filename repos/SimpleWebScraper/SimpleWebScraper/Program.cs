using SimpleWebScraper.Builders;
using SimpleWebScraper.Data;
using SimpleWebScraper.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {           
            try
            {
                Console.WriteLine("Please enter which city you would like to scrape information from:");
                var otomotoCity = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Please enter the CraigsList category that you would like to scrape:");
                var otomotoCategoryName = Console.ReadLine() ?? string.Empty;

                using (WebClient client = new WebClient())
                {
                    //string content = client.DownloadString($"http://www.otomoto.pl/{otomotoCategoryName}/{otomotoCity.Replace(" ", string.Empty)}/");
                    //https://www.otomoto.pl/osobowe/zlotoryja/

                    //var content = "Some fluff data <a href=\"http://domain.com\" data-id=\"someId\" class=\"result-title hdrlnk\">some text</a> more fluff data";
                    //.WithRegex(@"<a href=\""(.*?)\"" data-id=\""(.*?)\"" class=\""result-title hdrlnk\"">(.*?)</a>")

                    var content = client.DownloadString($"http://www.otomoto.pl/{otomotoCategoryName}/{otomotoCity.Replace(" ", string.Empty)}/");

                    ScrapeCriteria scrapeCriteria = new ScrapeCriteriaBuilder()
                        .WithData(content)
                        .WithRegex(@"<a data-ad-id=\""(.*?)\"" class=\""(.*?)\"" data-ninja-extradata=\""(.*?)\"" href=\""(.*?)\"" title=\""(.*?)\"">(.*?)</a>")
                        .WithRegexOption(RegexOptions.ExplicitCapture)
                        .WithPart(new ScrapeCriteriaPartBuilder()
                            .WithRegex(@">(.*?)</a>")
                            .WithRegexOption(RegexOptions.Singleline)
                            .Build())
                        .WithPart(new ScrapeCriteriaPartBuilder()
                            .WithRegex(@"href=\""(.*?)\""")
                            .WithRegexOption(RegexOptions.Singleline)
                            .Build())
                        .Build();

                    Scraper scraper = new Scraper();

                    var scrapedElements = scraper.Scrape(scrapeCriteria);

                    if (scrapedElements.Any())
                    {
                        foreach (var scrapedElement in scrapedElements) Console.WriteLine(scrapedElement);
                    }
                    else
                    {
                        Console.WriteLine("There were no matches for the specified scrape criteria");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
