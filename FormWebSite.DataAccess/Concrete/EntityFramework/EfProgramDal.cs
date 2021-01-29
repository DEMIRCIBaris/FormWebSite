using FormWebSite.Core.DataAccess.EntitiyFramework;
using FormWebSite.DataAccess.Abstract;
using FormWebSite.DataAccess.Concrete.EntityFramework.Context;
using FormWebSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormWebSite.DataAccess.Concrete.EntityFramework
{
    public class EfProgramDal : EfEntityRepositoryBase<MyDataContext, Program>, IProgramDal
    {
        public void AddRange(string[] programs)
        {
            using(var dB=new MyDataContext())
            {
                if (dB.Programs.Count()==0)
                {
                    var programList = new List<Program>();
                    foreach (var item in programs)
                    {
                        programList.Add(new Program { ProgramCat = item });
                    }

                    dB.Programs.AddRange(programList);
                    dB.SaveChanges();
                }
              
            }
        }
    }
}
