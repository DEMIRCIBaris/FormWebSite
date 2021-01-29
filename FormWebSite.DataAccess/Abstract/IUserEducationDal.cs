using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.DataAccess.Abstract
{
    public interface IUserEducationDal
    {
        public void Add(AppUser user, int StudyId, string SchoolName, string DepartmentName);
    }
}
