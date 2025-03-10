using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KuhleStudyProfile.Models;

namespace KuhleStudyProfile.Controllers
{
    public class KuhleStudyGroupController : Controller
    {
        // GET: KuhleStudyGroup
        public ActionResult Index()
        {
            List<KuhleStudyGroupModel> studyGroup = new List<KuhleStudyGroupModel>
            {
                new KuhleStudyGroupModel { StudentNumber = "u01234567" , Name = " Jane" , Surname = " Doe" , EmailAddress = " u01234567@tuks.co.za" , myLink = "~/HTML/Jane.html"},
                new KuhleStudyGroupModel { StudentNumber = "u12345678", Name = "John", Surname = "Doe", EmailAddress = "u12345678@tuks.co.za", myLink = "~/HTML/John.html"},
                new KuhleStudyGroupModel { StudentNumber = "u23456789", Name = "Moses", Surname = "Mo", EmailAddress = "u23456789@tuks.co.za", myLink = "~/HTML/Moses.html"},
                new KuhleStudyGroupModel { StudentNumber = "u34567891", Name = "Mary", Surname = "Beth", EmailAddress = "u34567891@tuks.co.za", myLink = "~/HTML/Mary.html"}
            };
            return View(studyGroup);
            
        }
    }
}