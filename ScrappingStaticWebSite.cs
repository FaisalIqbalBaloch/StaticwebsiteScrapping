using HtmlAgilityPack;
using System;
using System.IO;
using CsvHelper;
using System.Globalization;
namespace Scraping
{
    internal class Program
    {
        public static void ScrappinggStaticWebsite()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://twitter.com/i/api/1.1/jot/ces/p2");
            var description = doc.DocumentNode.SelectNodes("/html/body/div/div[2]/div[2]/p").First().InnerText;
            Console.WriteLine(description);


            using (var writer = new StreamWriter("pokemon-products.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(description);
            }
        }

    }
}





