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
     
          
        
        public ActionResult Index()
        {
            
            return View(db.Members.ToList());
            
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
            
            return View(db.Events.ToList());
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
            
            return View(db.Announcements.ToList());
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
        [Authorize(Users = "Admin@Admin.com")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}