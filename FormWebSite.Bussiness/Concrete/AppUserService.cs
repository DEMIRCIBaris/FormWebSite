using FormWebSite.Bussiness.Abstract;
using FormWebSite.DataAccess.Abstract;
using FormWebSite.Entities.Concrete;
using System.Collections.Generic;

namespace FormWebSite.Bussiness.Concrete
{
    public class AppUserService : IAppUserService
    {
        private readonly IAppUserDal appUserDal;

        public AppUserService(IAppUserDal appUserDal)
        {
            this.appUserDal = appUserDal;
        }


        public List<UserEducation> GetUserEducations(int userId)
        {
            return appUserDal.GetUserEducations(userId);
        }
    }
}
