using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Unitok_progect.Domain.Entities;

namespace Unitok_progect.Persistence.Configuration
{
    public class UserInfoConfiguration : IEntityTypeConfiguration<UserInfo>
    {
        public void Configure(EntityTypeBuilder<UserInfo> builder)
        {
			builder.HasKey(ui => ui.Id);
			builder.Property(ui => ui.Id).UseIdentityColumn();

			builder.HasOne(ui => ui.Wallet)
				   .WithOne(w => w.UserInfo)
				   .HasForeignKey<Wallet>(w => w.UserInfoId);
			/*            builder.HasKey(x => x.Id);

                        builder.Property(x => x.NickName).IsRequired();
                        builder.Property(x => x.FirstName);
                        builder.Property(x => x.LastName);*/
			//builder.Property(x => x.Description).HasMaxLength(300);
			/*            builder.Property(x => x.FollowersNumber).HasDefaultValue(0);*/

			/*            builder.Property(x => x.Email).IsRequired();*/

			/*			builder.HasOne(x => x.User)
                               .WithOne(u => u.UserInfo)
                               .HasForeignKey<UserInfo>(x => x.IdUser)
                               .OnDelete(DeleteBehavior.Cascade);*/

			/*            builder.HasOne(x => x.AvatarImage)
                                .WithOne()
                                .HasForeignKey<UserInfo>(x => x.AvatarImageId).OnDelete(DeleteBehavior.NoAction);

                        builder.HasOne(x => x.BackgroundImage)
                            .WithOne()
                            .HasForeignKey<UserInfo>(x => x.BackgroundImageId).OnDelete(DeleteBehavior.NoAction);*/

			/*            builder.HasMany(x => x.NftCreatedCollection)
							.WithOne(x => x.Creator)
							.HasForeignKey(x => x.CreatorId).OnDelete(DeleteBehavior.NoAction);

						builder.HasMany(x => x.NftOnSaleCollection)
							.WithOne(x => x.Owner)
							.HasForeignKey(x => x.OwnerId).OnDelete(DeleteBehavior.NoAction);*/

			/*            builder.HasOne(x => x.Wallet)
                                .WithOne(x => x.UserInfo)
                                .HasForeignKey<UserInfo>(x => x.WalletId)
                                .OnDelete(DeleteBehavior.Cascade);*/
		}
    }
}
