using HtmlSerializer;
using System;
using System.Threading.Tasks;

namespace HtmlProcessor
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HtmlSerialize loader = new HtmlSerialize();
            string url = "https://www.example.com";

            string htmlContent = await loader.Load(url);

            Console.WriteLine(htmlContent);
        }

    }
}
