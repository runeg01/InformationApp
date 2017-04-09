using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InformationApp.Models
{
    public class Announcements
    {
        public int AnnouncementId { get; set; }
        [Required(ErrorMessage = "Please Enter the Announcement Name")]

        public String AnnouncementName { get; set; }
        [Required(ErrorMessage = "Please Enter the Announcement Description")]

        public String AnnouncementDescription { get; set; }
        [Required(ErrorMessage = "Please Enter the Announcement Author")]

        public String AnnouncementAuthor { get; set; }

       
    }
}