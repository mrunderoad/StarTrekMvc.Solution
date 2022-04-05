using Microsoft.AspNetCore.Mvc;
using StarTrek.Models;

namespace StarTrek.Controllers
{
  public class TrekEventsController : Controller
  {
    public IActionResult Index()
    {
      var trekInfo = TrekEvent.GetEvents();
      return View(trekInfo);
    }
  }
}