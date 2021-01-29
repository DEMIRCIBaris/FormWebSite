using FormWebSite.Entities.Concrete;
using System.Collections.Generic;

namespace FormWebSite.DataAccess.Abstract
{
    public interface IAppUserDal
    {
        public List<UserEducation> GetUserEducations(int userId);
    }
}
