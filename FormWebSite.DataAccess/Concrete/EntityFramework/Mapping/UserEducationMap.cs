using FormWebSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserEducationMap : IEntityTypeConfiguration<UserEducation>
    {
        public void Configure(EntityTypeBuilder<UserEducation> builder)
        {
            builder.HasKey(used => new { used.UsersId, used.EducationsId });
            builder.HasOne(bc => bc.AppUser).WithMany(b => b.UserEducations).HasForeignKey(bc => bc.UsersId);
            builder.HasOne(bc => bc.Education).WithMany(b => b.UserEducations).HasForeignKey(bc => bc.EducationsId);
        }
    }
}
