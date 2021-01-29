using FormWebSite.Core.Entities.Abstract;
using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.Entities.Concrete
{
    public class Program : IEntity
    {
        public int Id { get; set; }
        public string ProgramCat { get; set; }
        public List<AppUser> AppUsers { get; set; }

    }
}
