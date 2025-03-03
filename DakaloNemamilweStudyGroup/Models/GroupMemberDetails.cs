using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DakaloNemamilweStudyGroup.Models
{
    public class GroupMemberDetails
    {
        //unique number for each student
        public String Student_Number { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Email { get; set; }

    }
}