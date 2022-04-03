using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static List<string> list = new List<string>();
        static string path = "test.txt";
        FileInfo info = new FileInfo(path);
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {

                var tasks = new List<Task>();
                for (int i = 4; i < 14; i++)
                {
                    var task = GetTask(i, client);
                    tasks.Add(task);
                }
                await Task.WhenAll(tasks);

            }

            foreach (var c in list)
            {
                File.AppendAllText(path, c);
                File.AppendAllText(path, Environment.NewLine);
                File.AppendAllText(path, Environment.NewLine);
            }
        }

        static async Task GetTask(int count, HttpClient client)
        {
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri(@"https://jsonplaceholder.typicode.com/");
            }
            var postResponce = await client.GetAsync($"posts/{count}");
            HttpContent httpContent = postResponce.Content;
            var json = await httpContent.ReadAsStringAsync();
            string hg = json.ToString();
            list.Add(hg);
        }

    }
}
