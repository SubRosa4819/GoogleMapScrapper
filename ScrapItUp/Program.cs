using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ScrapItUp
{
    class Program
    {
        static IWebDriver driver;

        static public void startBrowser()
        {
            var options = new ChromeOptions();
            //options.AddArguments("headless");

            driver = new ChromeDriver("C:\\Users\\33670\\Documents\\GitHub\\GoogleMapScrapper\\ScrapItUp\\", options); // path à changer
        }

        static public void scrapIt(listCommerceModel resultlist)
        {
            
            driver.Url = $"https://www.google.com/search?q={resultlist.query.type}+{resultlist.query.localisation}";
        }

        static public void closeBrowser()
        {
            driver.Close();
        }
        static void getQuery(QueryModel query)
        {
            Console.WriteLine("Hello user: {0} que puis-je scrapper pour vous?", Environment.UserName);
            Console.WriteLine("Type de commerce : ");
            query.type = Console.ReadLine();
            Console.WriteLine("Localisation : ");
            query.localisation = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            listCommerceModel resultList = new listCommerceModel();
            getQuery(resultList.query);
            startBrowser();
            scrapIt(resultList);
        }

    }
}
