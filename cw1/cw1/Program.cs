using System;
using System.Net.Http;

namespace cw1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new HttpClient();
            var result = await client.GetAcync("https://www.pja.edu.pl");
        }
    }
}
