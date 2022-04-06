using Microsoft.AspNetCore.Mvc;
using StarTrek.Models;

namespace StarTrek.Controllers
{
  public class ShipsController : Controller
  {
    public IActionResult Index()
    {
      var ship = Ship.GetAllShips();
      return View(ship);
    }
  }
}