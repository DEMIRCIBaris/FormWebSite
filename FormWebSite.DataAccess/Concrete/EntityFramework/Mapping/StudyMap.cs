using FormWebSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.DataAccess.Concrete.EntityFramework.Mapping
{
    public class StudyMap : IEntityTypeConfiguration<Study>
    {
        public void Configure(EntityTypeBuilder<Study> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.StudyName).HasMaxLength(50);

            builder.HasMany(i => i.Educations).WithOne(i => i.Study).HasForeignKey(i => i.StudyId); 
        }
    }
}
