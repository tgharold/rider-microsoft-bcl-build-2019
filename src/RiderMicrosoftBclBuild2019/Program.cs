using System;
using System.Net.Http;

namespace RiderMicrosoftBclBuild2019
{
    public class Program
    {
        public static string GetBaseAddress(HttpClient client)
        {
            return client?.BaseAddress?.ToString();
        }
        
        public static void Main(string[] args)
        {
            var client = new HttpClient();
            Console.WriteLine(GetBaseAddress(client));
        }
    }
}