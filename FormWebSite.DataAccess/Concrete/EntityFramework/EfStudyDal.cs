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
    public class EfStudyDal : EfEntityRepositoryBase<MyDataContext, Study>, IStudyDal
    {
        public void AddRange(string[] studies)
        {
            using (var dB = new MyDataContext())
            {
                if (dB.Studies.Count() == 0)
                {
                    var studiesList = new List<Study>();
                    foreach (var item in studies)
                    {
                        studiesList.Add(new Study { StudyName = item });
                    }

                    dB.Studies.AddRange(studiesList);
                    dB.SaveChanges();
                }

            }
        }
    }
}
