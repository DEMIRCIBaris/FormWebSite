using FormWebSite.Entities.Concrete;
using System.Collections.Generic;

namespace FormWebSite.Bussiness.Abstract
{
    public interface IAppUserService
    {
        public List<UserEducation> GetUserEducations(int userId);
    }
}
