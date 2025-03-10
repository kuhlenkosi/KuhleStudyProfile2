using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KuhleStudyProfile.Models
{
    public class KuhleStudyGroupModel
    {
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Display(Name = " Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "EmailAddress")]
        public string EmailAddress { get; set; }

        [Display(Name = "Personal Page Link")]
        public string myLink { get; set; }
    }
}