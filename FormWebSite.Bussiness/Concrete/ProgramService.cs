using FormWebSite.Bussiness.Abstract;
using FormWebSite.DataAccess.Abstract;
using FormWebSite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FormWebSite.Bussiness.Concrete
{
    public class ProgramService : IProgramService
    {
        private readonly IProgramDal programDal;
        public ProgramService(IProgramDal programDal)
        {
            this.programDal = programDal;
        }
        public void Add(Program entity)
        {
            programDal.Add(entity);
        }

        public void AddRange(string[] programs)
        {
            programDal.AddRange(programs);
        }

        public void Delete(Program entity)
        {
            programDal.Delete(entity);
        }

        public Program Get(Expression<Func<Program, bool>> filter)
        {
            var program = programDal.Get(filter);
            return program;
        }

        public List<Program> GetList(Expression<Func<Program, bool>> filter = null)
        {
            var programs = programDal.GetList(filter);
            return programs;
        }

        public void Update(Program entity)
        {
            programDal.Update(entity);
        }
    }
}
