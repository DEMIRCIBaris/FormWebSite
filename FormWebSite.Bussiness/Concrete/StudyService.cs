using FormWebSite.Bussiness.Abstract;
using FormWebSite.DataAccess.Abstract;
using FormWebSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FormWebSite.Bussiness.Concrete
{
    public class StudyService : IStudyService
    {
        private readonly IStudyDal studyDal;
        public StudyService(IStudyDal studyDal)
        {
            this.studyDal = studyDal;
        }
        public void Add(Study entity)
        {
            studyDal.Add(entity);
        }

        public void AddRange(string[] studies)
        {
            studyDal.AddRange(studies);
        }

        public void Delete(Study entity)
        {
            studyDal.Delete(entity);
        }

        public Study Get(Expression<Func<Study, bool>> filter)
        {
            var study = studyDal.Get(filter);
            return study;
        }

        public List<Study> GetList(Expression<Func<Study, bool>> filter = null)
        {
            var studies = studyDal.GetList(filter);
            return studies;
        }

        public void Update(Study entity)
        {
            studyDal.Update(entity);
        }
    }
}
