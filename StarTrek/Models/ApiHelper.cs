using System.Threading.Tasks;
using RestSharp;

namespace StarTrek.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"trekevents", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"trekevents/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetAllCharacters()
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"characters", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetCharacter(int id)
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"characters/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

     public static async Task<string> GetShips()
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"starships", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}