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

    public static List<TrekEvent> GetTrekEvent()
    {
      var apiCallTask = ApiHelper.GetAll();

      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);

      List<TrekEvent> trekInfo = JsonConvert.DeserializeObject<List<TrekEvent>>(jsonResponse.ToString());

      return trekInfo;
    }
    public static TrekEvent Details(int id)
    {
      var apiCallTask = ApiHelper.Get(id);

      var result = apiCallTask.Result;

      JObject jsonresponse = JsonConvert.DeserializeObject<JObject>(result);

      TrekEvent trek = JsonConvert.DeserializeObject<TrekEvent>(jsonresponse.ToString());

      return trek;
    }

    public static void Post(TrekEvent trekEvent)
    {
      string jsonTrekEvent = JsonConvert.SerializeObject(trekEvent);

      var apiCallTask = ApiHelper.Post(jsonTrekEvent);
    }

    public static void Put(TrekEvent trekEvent)
    {
      string jsonTrekEvent = JsonConvert.SerializeObject(trekEvent);

      var apiCallTask = ApiHelper.Put(trekEvent.TrekEventId, jsonTrekEvent);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  } 
}