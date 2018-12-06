using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper.Data
{
    class ScrapeCriteria
    {
        public ScrapeCriteria()
        {
            Part = new List<ScrapeCriteriaPart>();
        }

        public string Data { get; set; }
        public string Regex { get; set; }
        public RegexOptions RegexOption { get; set; }
        public List<ScrapeCriteriaPart> Part { get; set; }
    }
}
