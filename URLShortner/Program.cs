
using System;
using System.Net;
using System.Net.Http;
using Google.Apis.Services;
using Google.Apis.Urlshortener.v1;
using Google.Apis.Urlshortener.v1.Data;
using Google.Apis.Http;

namespace URLShortner
{
    class Program
    {
        private const string APIKey = "AIzaSyAXvB2FFFbW5lwxUNqN1a1CxZWf3XghHhA";
        static void Main(string[] args)
        {
            var initializer = new BaseClientService.Initializer
            {
                ApiKey = APIKey,
                //HttpClientFactory = new ProxySupportedHttpClientFactory()
            };
            var service = new UrlshortenerService(initializer);
            string val;
            Console.Write("Enter long URL: ");
            val = Console.ReadLine();
            var response = service.Url.Insert(new Url { LongUrl = val }).Execute();

            Console.WriteLine($"Short URL: {response.Id}");
            Console.ReadKey();
            
        }
    }
}
