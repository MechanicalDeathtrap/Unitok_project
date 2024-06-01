using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Unitok_progect.Domain.Entities;

namespace Unitok.Persistence.Configuration
{
	public class UserConfiguration : IEntityTypeConfiguration<UserMain>
	{
		public void Configure(EntityTypeBuilder<UserMain> builder)
		{
			builder.HasKey(u => u.Id);
			builder.Property(u => u.Id).UseIdentityColumn();

			builder.HasOne(u => u.UserInfo)
				   .WithOne(ui => ui.User)
				   .HasForeignKey<UserMain>(u => u.UserInfoId);
			/*			builder
						.HasOne(u => u.UserInfo)
						.WithOne(ui => ui.User)
						.HasForeignKey<UserInfo>(ui => ui.IdUser)
						.OnDelete(DeleteBehavior.Cascade);*/

		}
	}
}
