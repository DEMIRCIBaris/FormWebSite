using FormWebSite.DataAccess.Abstract;
using FormWebSite.DataAccess.Concrete.EntityFramework.Context;
using FormWebSite.Entities.Concrete;
using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormWebSite.DataAccess.Concrete.EntityFramework
{
    public class EfUserEducation : IUserEducationDal
    {
        public void Add(AppUser user, int StudyId, string SchoolName, string DepartmentName)
        {
            using(var dB=new MyDataContext())
            {
                var education = new Education();

                education.StudyId = StudyId;
                education.SchoolName = SchoolName;
                education.DepartmentName = DepartmentName;

                var userEducation = new UserEducation();
                userEducation.AppUser = user;
                userEducation.Education = education;

                var newUser = dB.Users.Where(i => i.UserName == user.UserName).Include(i => i.UserEducations).FirstOrDefault();

                newUser.UserEducations.Add(userEducation);
                dB.Educations.Add(education);
              
                dB.SaveChanges();

            }
        }
    }
}
