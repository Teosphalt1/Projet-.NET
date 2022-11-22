using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace TestJson
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://my-json-server.typicode.com/typicode/demo/posts";
            HttpClient httpClient = new HttpClient();
            try
            {
                var httpResponseMessage = await httpClient.GetAsync(url);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(jsonResponse);

                var myPosts = JsonConvert.DeserializeObject<Post[]>(jsonResponse);

                foreach (var post in myPosts)
                {
                    Console.WriteLine($"{post.id} {post.title}");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                httpClient.Dispose();
            }
        }
    }
}