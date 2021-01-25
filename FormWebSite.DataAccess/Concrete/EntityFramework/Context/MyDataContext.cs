using FormWebSite.DataAccess.Concrete.EntityFramework.Mapping;
using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FormWebSite.DataAccess.Concrete.EntityFramework.Context
{
    public class MyDataContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=WorkFlowDB;Server=(localdb)\MSSQLLocalDB;Trusted_Connection=True;"); //Connection String eklendi
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserMap());
            base.OnModelCreating(builder);
        }
    }
}
