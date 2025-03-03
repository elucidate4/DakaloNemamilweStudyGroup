using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using DakaloNemamilweStudyGroup.Models;

namespace DakaloNemamilweStudyGroup.Controllers
{
    public class GroupController: Controller
    {


        public ActionResult Index()
        {
            List<GroupMemberDetails> memberDetails = new List<GroupMemberDetails>
            {
                new GroupMemberDetails {Student_Number = "u23854830", Name = "Dakalo", Surname = "Nemamilwe", Email = "u23854830@tuks.co.za"},
                new GroupMemberDetails {Student_Number = "u23643570", Name = "Mary", Surname = "Modiba", Email = "u23643570@tuks.co.za"},
                new GroupMemberDetails {Student_Number = "u05084360", Name = "Zoe", Surname = "Joubert", Email = "u05084360@tuks.co.za"},
                new GroupMemberDetails {Student_Number = "u23957281", Name = "Andani", Surname = "Bologo", Email = "u23957281@tuks.co.za"},
                new GroupMemberDetails {Student_Number = "u22715895", Name = "Moeletsi", Surname = "Melamu", Email = "u22715895@tuks.co.za"}
            };

            return View(memberDetails);
        
        }
    }
}