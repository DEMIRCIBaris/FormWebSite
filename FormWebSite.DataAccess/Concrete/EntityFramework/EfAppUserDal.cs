using FormWebSite.DataAccess.Abstract;
using FormWebSite.DataAccess.Concrete.EntityFramework.Context;
using FormWebSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FormWebSite.DataAccess.Concrete.EntityFramework
{
    public class EfAppUserDal : IAppUserDal
    {
        public List<UserEducation> GetUserEducations(int userId)
        {
            using (var dB = new MyDataContext())
            {
                var userEdu = dB.Users.Where(i => i.Id == userId).Include(i => i.UserEducations).ThenInclude(i => i.Education).ThenInclude(i=>i.Study).Select(i => i.UserEducations).FirstOrDefault();
                return userEdu;
            }
        }
    }
}
