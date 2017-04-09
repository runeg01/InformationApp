using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationApp.Models
{
    public class Members
    {
        public int MemberId { get; set; }

        public String Name { get; set; }

        public String EmailAddress { get; set; }

        public String Address { get; set; }

        public int PhoneNumber { get; set; }

        public String Location { get; set; }

        public String Biography { get; set; }

        public String Skills { get; set; }
    }
}