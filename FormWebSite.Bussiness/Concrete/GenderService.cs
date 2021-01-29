using FormWebSite.Bussiness.Abstract;
using FormWebSite.DataAccess.Abstract;
using FormWebSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FormWebSite.Bussiness.Concrete
{
    public class GenderService : IGenderService
    {
        private readonly IGenderDal genderDal;

        public GenderService(IGenderDal genderDal)
        {
            this.genderDal = genderDal;
        }

        public void Add(Gender entity)
        {
            genderDal.Add(entity);
        }

        public void Delete(Gender entity)
        {
            genderDal.Delete(entity);
        }

        public Gender Get(Expression<Func<Gender, bool>> filter)
        {
            var gender = genderDal.Get(filter);
            return gender;
        }

        public List<Gender> GetList(Expression<Func<Gender, bool>> filter = null)
        {
            var genders = genderDal.GetList(filter);
            return genders;
        }

        public void Update(Gender entity)
        {
            genderDal.Update(entity);
        }

        public void AddRange(string[] genders)
        {
            genderDal.AddRange(genders);
        }
    }
}
