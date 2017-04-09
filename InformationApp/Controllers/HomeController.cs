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
        InformationAppDB db = new InformationAppDB();
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
            var model = db.Members.LastOrDefault();
            return View(model);
        }
        [HttpGet]
        public ViewResult AddMember ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMember (Members members)
        {
            if(ModelState.IsValid)
            {
                db.Members.Add(members);
                return RedirectToAction("MemberList");
        }
            else
            {
                return View();
            }
            }
        public ViewResult MemberList()
        {
            var model = db.Members.ToList();
            return View(model);
        }

        public ActionResult Events ()
        {
            var model = db.Members.LastOrDefault();
            return View(model);
        }
        [HttpGet]
        public ViewResult AddEvent ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEvent(Events events)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(events);
                return RedirectToAction("EventList");
            }
            else
            {
                return View();
            }
        }
        public ViewResult EventList()
        {
            var model = db.Events.ToList();
            return View(model);
        }

        public ActionResult Announcements ()
        {
            var model = db.Members.LastOrDefault();
            return View(model);
        }
        [HttpGet]
        public ViewResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAnnouncement(Announcements announcements)
        {
            if (ModelState.IsValid)
            {
                db.Announcements.Add(announcements);
                return RedirectToAction("AnnouncementList");
            }
            else
            {
                return View();
            }
        }
        public ViewResult AnnouncementList()
        {
            var model = db.Announcements.ToList();
            return View(model);
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