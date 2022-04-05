// using System.Collections.Generic;
// using System;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Linq;

// namespace StarTrek.Models
// {
//   public class Character
//   {
//     public int CharacterId { get; set; }
//     public string Name { get; set; }
//     public string Bio { get; set; }

//     public static List<Character> GetCharacter()
//     {
//       var apiCallTask = ApiHelper.GetAll();

//       var result = apiCallTask.Result;

//       JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);

//       List<Character> trekInfo = JsonConvert.DeserializeObject<List<Character>>(jsonResponse.ToString());

//       return trekInfo;
//     }
//     public static Character Details(int id)
//     {
//       var apiCallTask = ApiHelper.Get(id);

//       var result = apiCallTask.Result;

//       JObject jsonresponse = JsonConvert.DeserializeObject<JObject>(result);

//       Character character = JsonConvert.DeserializeObject<Character>(jsonresponse.ToString());

//       return character;
//     }
//   }
// }