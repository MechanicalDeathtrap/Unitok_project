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
    public class NftCardConfiguration : IEntityTypeConfiguration<NftCard>
    {
        public void Configure(EntityTypeBuilder<NftCard> builder)
        {
            /*            builder.HasKey(x => x.Id);

                        builder.Property(x => x.Name).IsRequired();
                        builder.Property(x => x.Description).HasMaxLength(300);

                        builder.HasOne(x => x.Image).WithOne(x => x.Card).HasForeignKey<NftCard>(x => x.ImageId).OnDelete(DeleteBehavior.NoAction);*/
/*            builder.HasOne(x => x.Creator).WithMany(x => x.NftCreatedCollection).HasForeignKey(x => x.CreatorId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Owner).WithMany(x => x.NftOnSaleCollection).HasForeignKey(x => x.OwnerId).OnDelete(DeleteBehavior.NoAction);*/

            /*            builder.Property(x => x.isOnSale).IsRequired().HasDefaultValue(true);
                        builder.Property(x => x.Price).IsRequired().HasDefaultValue(0);
                        builder.HasOne(x => x.Category).WithMany(x => x.NftCards).HasForeignKey(x => x.CategoryId);
                        builder.Property(x => x.IsOnAuction).IsRequired().HasDefaultValue(false);*/
        }
    }
}
