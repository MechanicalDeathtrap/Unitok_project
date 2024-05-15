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
    public class UserInfoConfiguration : IEntityTypeConfiguration<UserInfo>
    {
        public void Configure(EntityTypeBuilder<UserInfo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.NickName).IsRequired();
            builder.Property(x => x.FirstName);
            builder.Property(x => x.LastName);
            builder.Property(x => x.Description).HasMaxLength(300);
            builder.Property(x => x.FollowersNumber).HasDefaultValue(0);

            builder.HasOne(x => x.AvatarImage)
                    .WithOne()
                    .HasForeignKey<UserInfo>(x => x.AvatarImageId);

            builder.HasOne(x => x.BackgroundImage)
                .WithOne()
                .HasForeignKey<UserInfo>(x => x.BackgroundImageId).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.NftCreatedCollection)
                .WithOne(x => x.Creator)
                .HasForeignKey(x => x.CreatorId).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.NftOnSaleCollection)
                .WithOne(x => x.Owner)
                .HasForeignKey(x => x.OwnerId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
