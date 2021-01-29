using FormWebSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.DataAccess.Concrete.EntityFramework.Mapping
{
    public class EducationMap : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.SchoolName).HasMaxLength(50);
            builder.Property(i => i.DepartmentName).HasMaxLength(50);

            builder.HasOne(i => i.Study).WithMany(i => i.Educations).HasForeignKey(i => i.StudyId);

        }
    }
}
