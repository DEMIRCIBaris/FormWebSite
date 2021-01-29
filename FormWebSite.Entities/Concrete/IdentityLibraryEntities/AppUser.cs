using FormWebSite.Core.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace FormWebSite.Entities.Concrete.IdentityLibraryEntities
{
    public class AppUser:IdentityUser<int>,IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public  DateTime? Birthday { get; set; }
        public int Book { get; set; }
        public int ClassroomTrainings { get; set; }
        public int Master { get; set; }
        public int OnTheJob { get; set; }
        public int Other { get; set; }
        public string OtherExplanation { get; set; }
        public bool aydin { get; set; }
        public bool riza { get; set; }

        public int? GenderId { get; set; }
        public Gender Gender { get; set; }

        public int? ProgramId { get; set; }
        public Program  Program { get; set; }

        public string ProgramName { get; set; }

        public List<UserEducation> UserEducations { get; set; }

    }
}
