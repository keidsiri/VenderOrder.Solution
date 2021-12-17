using Microsoft.AspNetCore.Mvc;

namespace VenderOrder.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}