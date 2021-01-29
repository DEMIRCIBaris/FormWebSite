using FormWebSite.Core.DataAccess.EntitiyFramework;
using FormWebSite.DataAccess.Abstract;
using FormWebSite.DataAccess.Concrete.EntityFramework.Context;
using FormWebSite.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace FormWebSite.DataAccess.Concrete.EntityFramework
{
    public class EfGenderDal : EfEntityRepositoryBase<MyDataContext, Gender>, IGenderDal
    {
        public void AddRange(string[] genders)
        {
            using(var dB=new MyDataContext())
            {
                if (dB.Genders.Count()==0)
                {
                    var gendersList = new List<Gender>();
                    foreach (var item in genders)
                    {
                        gendersList.Add(new Gender { GenderName = item });
                    }

                    dB.Genders.AddRange(gendersList);
                    dB.SaveChanges();
                }
               
            }
        }
    }
}
