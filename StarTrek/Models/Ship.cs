using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace StarTrek.Models
{
  public class Ship
  {
    public int StarshipId { get; set; }
    public string ShipModel { get; set; }
    public string ShipClass { get; set; }
    public string Captain { get; set; }
    public string Launch { get; set; }
    public string Image { get; set; }
    

    public static List<Ship> GetAllShips()
    {
      var apiCallTask = ApiHelper.GetShips();

      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);

      List<Ship> trekInfo = JsonConvert.DeserializeObject<List<Ship>>(jsonResponse.ToString());

      return trekInfo;
    }
  }
}