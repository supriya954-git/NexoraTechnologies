using Microsoft.AspNetCore.Mvc;
using NexoraTechnologies.Models;

namespace NexoraTechnologies.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            List<Event> events = new List<Event>
            {
                new Event
                {
                    Name = "Tech Innovation Summit",
                    Description = "Discover the latest technology trends, innovations and digital solutions.",
                    Date = "September 15, 2026",
                    Location = "Nexora Technologies Conference Hall",
                    Image = "/Images/tech innovation.jpg"
                },

                new Event
                {
                    Name = "Coding Hackathon",
                    Description = "A competitive coding event where participants work together to develop innovative solutions.",
                    Date = "October 5, 2026",
                    Location = "Nexora Technologies Lab",
                    Image = "/Images/hackathon.jpg"
                },

                new Event
                {
                    Name = "Sports Day",
                    Description = "A fun-filled day featuring football, basketball, volleyball and other exciting sports activities.",
                    Date = "November 10, 2026",
                    Location = "City Sports Ground",
                    Image = "/Images/sports.jpg"
                },

                new Event
                {
                    Name = "AI & Robotics Workshop",
                    Description = "Learn about artificial intelligence, robotics and the future of intelligent technology.",
                    Date = "December 2, 2026",
                    Location = "Nexora Technologies Innovation Lab",
                    Image = "/Images/ai robotic workshop.jpg"
                }
            };

            return View(events);
        }
    }
}