using Microsoft.AspNetCore.Mvc;
using StarTrek.Models;

namespace StarTrek.Controllers
{
  public class FoundersController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}