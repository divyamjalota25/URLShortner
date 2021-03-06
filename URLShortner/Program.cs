
using System;
using System.Net;
using System.Net.Http;
using Google.Apis.Services;
using Google.Apis.Urlshortener.v1;
using Google.Apis.Urlshortener.v1.Data;
using Google.Apis.Http;
using System.Web;
using System.Xml;
using BitlyAPI;
using System.Threading.Tasks;

namespace URLShortner
{
    class Program
    {
        //private const string ApiKey = "AIzaSyAXvB2FFFbW5lwxUNqN1a1CxZWf3XghHhA";
        async System.Threading.Tasks.Task<string> stringShortenAsync(string longURL) {
            var bitly = new Bitly("e61f727aec6760256e23dab252b5ea13f7087a48");
            var linkResponse = await bitly.PostShorten(longURL);
            var newLink = linkResponse.Link;
            return newLink;
        }
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter URL to shorten: ");
            string longURL = Console.ReadLine();
            var bitly = new Bitly("e61f727aec6760256e23dab252b5ea13f7087a48");
            var linkResponse = await bitly.PostShorten(longURL);
            var newLink = linkResponse.Link;
            Console.WriteLine("Shortened URL is: ");
            Console.WriteLine(newLink);



        }
    }
}
