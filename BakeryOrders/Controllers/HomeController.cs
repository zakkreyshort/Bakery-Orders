using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    public class HomeController : Controller 
    {
        [HttpGet("/")]
        {
            return View();
        }
    }
}