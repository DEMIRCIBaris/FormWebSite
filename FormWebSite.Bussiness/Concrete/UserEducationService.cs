using FormWebSite.Bussiness.Abstract;
using FormWebSite.DataAccess.Abstract;
using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.Bussiness.Concrete
{
    public class UserEducationService : IUserEducationService
    {
        private readonly IUserEducationDal userEducationDal;

        public UserEducationService(IUserEducationDal userEducationDal)
        {
            this.userEducationDal = userEducationDal;
        }


        public void Add(AppUser user, int StudyId, string SchoolName, string DepartmentName)
        {
            userEducationDal.Add(user, StudyId, SchoolName, DepartmentName);
        }
    }
}
