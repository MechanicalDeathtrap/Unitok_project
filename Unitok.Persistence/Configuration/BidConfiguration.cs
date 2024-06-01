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
    public class BidConfiguration : IEntityTypeConfiguration<Bid>
    {
        public void Configure(EntityTypeBuilder<Bid> builder)
        {
/*            builder.HasKey(x => x.Id);

            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.BidTime).IsRequired();

            builder.HasOne(x => x.Auction)
                .WithMany(x => x.Bids)
                .HasForeignKey(x => x.AuctionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);*/
        }
    }
}
