using System.Diagnostics;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var urls = new string[] 
            { 
                "http://webcode.me", 
                "http://example.com",
                "http://httpbin.org", 
                "https://ifconfig.me", 
                "http://termbin.com", 
                "https://github.com"
            };
            using var client = new HttpClient();
            var sw = new Stopwatch();
            sw.Start();
            foreach (var url in urls)
            {
                var result = await client.GetAsync(url);
            }

            //var result = await client.GetAsync("http://webcode.me");
            sw.Stop();
            Console.WriteLine($"Async: {sw.ElapsedMilliseconds} ms");
            var sw2 = new Stopwatch();
            sw2.Start();
            foreach (var url in urls)
            {
                var result = client.GetAsync(url);
            }
            Console.WriteLine($"Sync: {sw2.ElapsedMilliseconds} ms");
        }
    }
}
