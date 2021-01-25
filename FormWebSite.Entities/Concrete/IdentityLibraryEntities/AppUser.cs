using FormWebSite.Core.Entities.Abstract;
using Microsoft.AspNetCore.Identity;

namespace FormWebSite.Entities.Concrete.IdentityLibraryEntities
{
    public class AppUser:IdentityUser<int>,IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Picture { get; set; }
    }
}
