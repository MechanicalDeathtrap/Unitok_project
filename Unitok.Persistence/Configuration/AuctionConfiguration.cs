using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok_progect.Domain.Entities;

namespace Unitok_progect.Persistence.Configuration
{
    public class AuctionConfiguration : IEntityTypeConfiguration<Auction>
    {
        public void Configure(EntityTypeBuilder<Auction> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.StartingPrice).IsRequired();
            builder.Property(x => x.StartTime).IsRequired();
            builder.Property(x => x.EndTime).IsRequired();

            builder.HasOne(x => x.NftCard)
                .WithOne(x => x.Auction)
                .HasForeignKey<Auction>(x => x.NftCardId).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Bids)
                .WithOne(x => x.Auction)
                .HasForeignKey(x => x.AuctionId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
