using FormWebSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.DataAccess.Concrete.EntityFramework.Mapping
{
    public class GenderMap : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.GenderName).HasMaxLength(50);

            builder.HasMany(i => i.AppUsers).WithOne(i => i.Gender).HasForeignKey(i => i.GenderId);
        }
    }
}
