using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.Bussiness.Abstract
{
    public interface IUserEducationService
    {
        public void Add(AppUser user, int StudyId, string SchoolName, string DepartmentName);
    }
}
