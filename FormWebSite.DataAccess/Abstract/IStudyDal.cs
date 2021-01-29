using FormWebSite.Core.DataAccess.Abstract;
using FormWebSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.DataAccess.Abstract
{
    public interface IStudyDal : IEntityRepository<Study>
    {
        void AddRange(string[] studies);
    }
}
