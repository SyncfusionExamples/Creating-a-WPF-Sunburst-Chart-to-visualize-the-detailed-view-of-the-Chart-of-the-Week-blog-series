using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartOfTheWeekData
{
    public class ArticleModel
    {
        public string? Platform { get; set; }
        public double Count { get; set; }
        public string? Icon { get; set; }
        public string? Category { get; set; }
        public string? Name { get; set; }
        public string? URL { get; set; }

        // Chart ItemSource
        public ArticleModel(string platform, double count , string category)
        {
            Platform = platform;
            Count = count;
            Category = category;
        }

        // ListView ItemSource
        public ArticleModel(string platform,string icon, string category, string name, string url)
        {
            Platform = platform;
            Icon = icon;
            Category = category;
            Name = name;
            URL = url;
        }
    }
}