using ConsoleApp1.Models;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json.Nodes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string directoryModels = @"C:\Users\Birinci Novbe\Desktop\Nihad\BirinciNovbe\task_14_11_prak\ConsoleApp1\Models";
            string directoryData = @"C:\Users\Birinci Novbe\Desktop\Nihad\BirinciNovbe\task_14_11_prak\ConsoleApp1\Data";
            string fileJsonData = "jsonData.json";
            string url = "https://jsonplaceholder.typicode.com/posts";

            //if (!Directory.Exists(directoryModels))
            //{
            //    Directory.CreateDirectory(directoryModels);
            //}

            //if (!Directory.Exists(directoryData))
            //{
            //    Directory.CreateDirectory(directoryData);
            //}
            //if (!File.Exists(fileJsonData))
            //{
            //    File.Create(Path.Combine(directoryData, fileJsonData));
            //}

            HttpClient client = new HttpClient();
            string httpJson = client.GetStringAsync(url).Result;
            ICollection<CustomObject> customObjects;
            customObjects = JsonConvert.DeserializeObject<ICollection<CustomObject>>(httpJson);
            using (StreamWriter sw = new StreamWriter(Path.Combine(directoryData, fileJsonData)))
            {
                sw.WriteLine(JsonConvert.SerializeObject(customObjects));
            }
             
        }
    }
}
