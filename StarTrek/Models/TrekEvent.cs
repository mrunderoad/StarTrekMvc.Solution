using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StarTrek.Models
{
  public class TrekEvent
  {
    public int TrekEventId { get; set; }
    public int Date { get; set; }
    public string Description { get; set; }

    public static List<TrekEvent> GetEvents()
    {
      var apiCallTask = ApiHelper.GetAll();

      var result = apiCallTask.Result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<TrekEvent> trekInfo = JsonConvert.DeserializeObject<List<TrekEvent>>(jsonResponse.ToString());
      return trekInfo;
    }
  } 
}