using FormWebSite.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.Entities.Concrete
{
    public class Education : IEntity
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string DepartmentName { get; set; }

        public int StudyId { get; set; }
        public Study Study { get; set; }

        public List<UserEducation> UserEducations { get; set; }

    }
}