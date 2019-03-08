using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Net.Http;
using System.Net;
using System.IO;


namespace StreetEasyScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "";
            var html = string.Empty;

            var options = new ChromeOptions();
            options.AddArgument("--enable-javascript");

            var proxy = new Proxy();
            proxy.Kind = ProxyKind.Manual;
            proxy.IsAutoDetect = false;
            proxy.HttpProxy = "";

            options.Proxy = proxy;
            options.AddArgument("ignore-certificate-errors");

            var chromeDriver = new ChromeDriver(options);
            chromeDriver.Navigate().GoToUrl(url);
            


           Console.WriteLine(html);
            Console.ReadKey();

            
        }
    }
}
