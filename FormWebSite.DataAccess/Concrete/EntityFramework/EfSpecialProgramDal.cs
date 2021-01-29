using FormWebSite.Core.DataAccess.EntitiyFramework;
using FormWebSite.DataAccess.Abstract;
using FormWebSite.DataAccess.Concrete.EntityFramework.Context;
using FormWebSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.DataAccess.Concrete.EntityFramework
{
    public class EfSpecialProgramDal : EfEntityRepositoryBase<MyDataContext, Education>, ISpecialProgramDal
    {
    }
}
