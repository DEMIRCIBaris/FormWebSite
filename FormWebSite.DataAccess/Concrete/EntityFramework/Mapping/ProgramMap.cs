using FormWebSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormWebSite.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ProgramMap : IEntityTypeConfiguration<Program>
    {
        public void Configure(EntityTypeBuilder<Program> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();
            builder.Property(i => i.ProgramCat).HasMaxLength(50);

            builder.HasMany(i => i.AppUsers).WithOne(i => i.Program).HasForeignKey(i => i.ProgramId);
        }
    }
}
