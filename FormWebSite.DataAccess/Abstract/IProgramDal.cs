using FormWebSite.Core.DataAccess.Abstract;
using FormWebSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.DataAccess.Abstract
{
    public interface IProgramDal : IEntityRepository<Program>
    {
        void AddRange(string[] programs);
    }
}
