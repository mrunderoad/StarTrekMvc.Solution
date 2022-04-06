using Microsoft.AspNetCore.Mvc;
using StarTrek.Models;

namespace StarTrek.Controllers
{
  public class CharactersController : Controller
  {
    public IActionResult Index()
    {
      var character = Character.GetCharacters();
      return View(character);
    }
  }
}