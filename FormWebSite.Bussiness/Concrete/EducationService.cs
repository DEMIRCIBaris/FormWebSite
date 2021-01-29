using FormWebSite.Bussiness.Abstract;
using FormWebSite.DataAccess.Abstract;
using FormWebSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FormWebSite.Bussiness.Concrete
{
    public class EducationService : IEducationService
    {
        private readonly IEducationDal educationDal;
        public EducationService(IEducationDal educationDal)
        {
            this.educationDal = educationDal;
        }

        public void Add(Education entity)
        {
            educationDal.Add(entity);
        }

        public void Delete(Education entity)
        {
            educationDal.Delete(entity);
        }

        public Education Get(Expression<Func<Education, bool>> filter)
        {
            var education = educationDal.Get(filter);
            return education;
        }

        public List<Education> GetList(Expression<Func<Education, bool>> filter = null)
        {
            var educations = educationDal.GetList(filter);
            return educations;
        }

        public void Update(Education entity)
        {
            educationDal.Update(entity);
        }
    }
}
