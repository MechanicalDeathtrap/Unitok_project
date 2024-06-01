using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok_progect.Domain.Entities;

namespace Unitok_progect.Persistence.Configuration
{
    public class StaticFileConfiguration : IEntityTypeConfiguration<StaticFile>
    {
        public void Configure(EntityTypeBuilder<StaticFile> builder)
        {
/*            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Path).IsRequired();
            builder.Property(x => x.Extension).HasMaxLength(10);
            builder.HasOne(x => x.Card).WithOne(x => x.Image).HasForeignKey<NftCard>(x => x.ImageId);*/

        }
    }
}
