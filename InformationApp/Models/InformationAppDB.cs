using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationApp.Models
{
    public class InformationAppDB
    {
        static List<Members> _Members;
        static List<Events> _Events;
        static List<Announcements> _Announcements;
        static InformationAppDB()
        {
            _Members = new List<Members>();
            _Members.Add(new Members
            {
                MemberId = 1,
                Name = "Kevin",
                EmailAddress = "Kevin@gmail.com",
                Address = "45 KevinStreet 7NU 9NU",
                PhoneNumber = 0293203212,
                Location = "Kingston",
                Biography = "Some cool book",
                Skills = "Cooking"
            });
            _Events = new List<Events>();
            _Events.Add(new Events
            {
                EventId = 1,
                EventName = "Swimming",
                EventDesc = "Cool event",
                EventLocation = "Kingston",
                Date = DateTime.Now
            });

            _Announcements = new List<Announcements>();
            _Announcements.Add(new Announcements
            {
                AnnouncementId = 1,
                AnnouncementName = "New cows!",
                AnnouncementDescription = "There is new cows",
                AnnouncementAuthor = "Kevin smith"
            });

        }
        public IList<Members> Members
        {
            get { return _Members; }
        }
        public IList<Events> Events
        {
            get { return _Events; }
        }
        public IList<Announcements> Announcements
        {
            get { return _Announcements; }
        }
    }
}
