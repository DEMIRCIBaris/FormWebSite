using FormWebSite.Core.Entities.Abstract;
using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.Entities.Concrete
{
    public class Study : IEntity
    {
        public int Id { get; set; }
        public string StudyName { get; set; }
        public List<Education> Educations  { get; set; }
    }
}
