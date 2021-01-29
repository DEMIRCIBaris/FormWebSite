using FormWebSite.DataAccess.Concrete.EntityFramework.Mapping;
using FormWebSite.Entities.Concrete;
using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FormWebSite.DataAccess.Concrete.EntityFramework.Context
{
    public class MyDataContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=SehreminiDB;Server=(localdb)\MSSQLLocalDB;Trusted_Connection=True;"); //Connection String eklendi
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserMap());
            builder.ApplyConfiguration(new GenderMap());
            builder.ApplyConfiguration(new EducationMap());
            builder.ApplyConfiguration(new StudyMap());
            builder.ApplyConfiguration(new UserEducationMap());
            builder.ApplyConfiguration(new ProgramMap());
            base.OnModelCreating(builder);
        }

        public DbSet<Gender> Genders { get; set; }
        public DbSet<Study>  Studies { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<UserEducation> UserEducations { get; set; }
        public DbSet<Program> Programs { get; set; }
    }
}
