using FormWebSite.Core.Entities.Abstract;
using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.Entities.Concrete
{
    public class UserEducation : IEntity
    {
        public int UsersId { get; set; }
        public AppUser  AppUser { get; set; }

        public int EducationsId { get; set; }
        public Education Education { get; set; }

    }
}
