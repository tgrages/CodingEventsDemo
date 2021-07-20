using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{
    public class EventsController : Controller
    {
        // GET: /<controller>/
        /*public IActionResult Index()
        {
            List<string> Events = new List<string>();
            Events.Add("Code With Pride");
            Events.Add("Apple WWDC");
            Events.Add("Strange Loop");

            ViewBag.events = Events;

            return View();
        }
        */

        public IActionResult Index()
            {
                Dictionary<string, string> eventsDictionary = new Dictionary<string, string>();

                eventsDictionary.Add("Code-a-thon 2021", "An internation coding challenge for all skill levels");
                eventsDictionary.Add("Hack the Box", "A pentester challenge for all skill levels");
                eventsDictionary.Add("Code Camp", "A coding bootcamp for beginners");
                eventsDictionary.Add("Code Master", "A coding training program for expert coders");

                ViewBag.storedEvents = eventsDictionary;

                return View();
            }

    }
}
