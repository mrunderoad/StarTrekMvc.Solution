using System;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace StarTrek
{
  class Program
  {

       public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
  //   static void Main()
  //   {
  //     var apiCallTask = ApiHelper.ApiCall("[YOUR-API-KEY-HERE]");
  //     var result = apiCallTask.Result;
  //     JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
  //     Console.WriteLine(jsonResponse["results"]);
  //   }
  // }

  // class ApiHelper
  // {
  //   public static async Task<string> ApiCall(string apiKey)
  //   {
  //     RestClient client = new RestClient("https://api.nytimes.com/svc/topstories/v2");
  //     RestRequest request = new RestRequest($"home.json?api-key={apiKey}", Method.GET);
  //     var response = await client.ExecuteTaskAsync(request);
  //     return response.Content;
  //   }
  }
}
