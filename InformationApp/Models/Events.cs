using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationApp.Models
{
    public class Events
    {
        public int EventId { get; set; }

        public String EventName { get; set; }

        public String EventDesc { get; set; }

        public String EventLocation { get; set; }

        public DateTime Date { get; set; }

        public String Location { get; set; }

       
    }
}