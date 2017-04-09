using InformationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace InformationApp.Controllers
{
    public class HomeController : Controller
    {
        private Members myMember = new Members
        {
            MemberId = 1,
            Name = "Kevin",
            EmailAddress = "Kevin@gmail.com",
            Address = "45 KevinStreet 7NU 9NU",
            PhoneNumber = 0293203212,
            Location = "Kingston",
            Biography = "Some cool book",
            Skills = "Cooking"
        };
        private Events myEvent = new Events
        {
            EventId = 1,
            EventName = "Swimming",
            EventDesc = "Cool event",
            EventLocation = "Kingston",
            Date = DateTime.Now
          
        };
        private Announcements myAnnouncement = new Announcements
        {
            AnnouncementId = 1,
            AnnouncementName = "New cows!",
            AnnouncementDescription = "There is new cows",
            AnnouncementAuthor = "Kevin smith"
          
        };
        public ActionResult Index()
        {
            return View(myMember);
        }
        [HttpGet]
        public ViewResult AddMember ()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddMember (Members members)
        {
            if(ModelState.IsValid)
            { 
            return View("Index", members);
        }
            else
            {
                return View();
            }
            }

        public ActionResult Events ()
        {
            return View(myEvent);
        }
        [HttpGet]
        public ViewResult AddEvent ()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddEvent(Events events)
        {
            if (ModelState.IsValid)
            {
                return View("Events", events);
            }
            else
            {
                return View();
            }
        }

        public ActionResult Announcements ()
        {
            return View(myAnnouncement);
        }
        [HttpGet]
        public ViewResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddAnnouncement(Announcements announcements)
        {
            if (ModelState.IsValid)
            {
                return View("Announcements", announcements);
            }
            else
            {
                return View();
            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}