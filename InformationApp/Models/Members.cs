using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InformationApp.Models
{
    public class Members
    {
        public int MemberId { get; set; }
        [Required(ErrorMessage = "Please Enter the member Name")]

        public String Name { get; set; }
        [Required(ErrorMessage = "Please Enter the member Email")]

        public String EmailAddress { get; set; }
        [Required(ErrorMessage = "Please Enter the member Address")]

        public String Address { get; set; }
        [Required(ErrorMessage = "Please Enter the member Phone")]

        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please Enter the member Location")]

        public String Location { get; set; }
        [Required(ErrorMessage = "Please Enter the member Biography")]

        public String Biography { get; set; }
        [Required(ErrorMessage = "Please Enter the member Skills")]

        public String Skills { get; set; }
    }
}