using FormWebSite.Core.Entities.Abstract;
using Microsoft.AspNetCore.Identity;

namespace FormWebSite.Entities.Concrete.IdentityLibraryEntities
{
    public class AppRole:IdentityRole<int>,IEntity
    {
    }
}
