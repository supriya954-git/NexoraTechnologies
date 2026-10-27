using Microsoft.AspNetCore.Mvc;

namespace NexoraTechnologies.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}