using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormWebSite.DataAccess.Concrete.EntityFramework.Mapping
{
    public class AppUserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.Name).HasMaxLength(100);
            builder.Property(i => i.Surname).HasMaxLength(100);

            builder.HasOne(i => i.Gender).WithMany(i => i.AppUsers).HasForeignKey(i => i.GenderId);

            builder.HasOne(i => i.Program).WithMany(i => i.AppUsers).HasForeignKey(i => i.ProgramId);
        }
    }
}
