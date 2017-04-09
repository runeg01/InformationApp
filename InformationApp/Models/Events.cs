using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InformationApp.Models
{
    public class Events
    {
        public int EventId { get; set; }
        [Required(ErrorMessage = "Please Enter the event Name")]

        public String EventName { get; set; }
        [Required(ErrorMessage = "Please Enter the event Description")]

        public String EventDesc { get; set; }
        [Required(ErrorMessage = "Please Enter the event Location")]

        public String EventLocation { get; set; }
        [Required(ErrorMessage = "Please Enter the event Date")]

        public DateTime Date { get; set; }

        

       
    }
}