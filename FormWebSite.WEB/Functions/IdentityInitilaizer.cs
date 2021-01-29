using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace FormWebSite.WEB.Functions
{
    public class IdentityInitilaizer
    {
        public static async Task SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Member" });
            }

            var memberUser = await userManager.FindByNameAsync("Dancho");
            if (memberUser == null)
            {
                var appuser = new AppUser
                {
                    UserName = "Dancho",
                };
                await userManager.CreateAsync(appuser, "1");
                await userManager.AddToRoleAsync(appuser, "Member");
            }


        }
    }
}
