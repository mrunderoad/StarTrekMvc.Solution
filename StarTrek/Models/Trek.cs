// using System.Collections.Generic;
// using System;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Linq;

// namespace StarTrek.Models
// {
//   public class Trek
//   {
//     public int TrekId { get; set; }

//     public static List<Trek> GetInfo()
//     {
//       var apiCallTask = ApiHelper.GetAll();
//       var result = apiCallTask.Result;
//       JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
//       List<Trek> trekInfo = JsonConvert.DeserializeObject<List<Trek>>(jsonResponse.ToString());
//       return trekInfo;
//     }
//     public  static Trek GetDetails(int id)
//     {
//       var apiCallTask = ApiHelper.Get(id);
//       var result = apiCallTask.Result;
//       JObject jsonresponse = JsonConvert.DeserializeObject<JObject>(result);
//       Trek trek = JsonConvert.DeserializeObject<Trek>(jsonresponse.ToString());
//       return trek;
//     }
//   } 
// }