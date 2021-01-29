using FormWebSite.Core.Bussiness;
using FormWebSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.Bussiness.Abstract
{
    public interface IStudyService : IGenericService<Study>
    {
        public void AddRange(string[] studies);
    }
}
