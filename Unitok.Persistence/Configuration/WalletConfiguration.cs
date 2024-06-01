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
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
			builder.HasKey(w => w.Id);
			builder.Property(w => w.Id).UseIdentityColumn();
			/*            builder.HasKey(x => x.Id);
						builder.Property(x => x.Earnings).IsRequired().HasDefaultValue(0);*/
			//builder.HasKey(x => x.Id);
			/*			builder.HasOne(x => x.UserInfo)
							.WithOne(x => x.Wallet)
							.HasForeignKey<UserInfo>(x => x.WalletId)
							.OnDelete(DeleteBehavior.Cascade);*/
		}
    }
}
