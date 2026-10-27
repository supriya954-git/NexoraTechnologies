using Microsoft.AspNetCore.Mvc;
using NexoraTechnologies.Models;

namespace NexoraTechnologies.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Registration registration)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Registration successful! We look forward to seeing you at the event.";

                ModelState.Clear();

                return View();
            }

            return View(registration);
        }
    }
}