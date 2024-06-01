using Unitok_progect.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Unitok_progect.Domain.Entities
{
    public class UserInfo: BaseAuditableEntity
	{
		public int Id { get; set; }
		public string? NickName { get; set; }
		public string Email { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Description { get; set; }
		public int FollowersNumber { get; set; } = 0;
		public string? AvatarImageUrl { get; set; }
		public byte[]? AvatarImageData { get; set; }
		public string? BackgroundImageUrl { get; set; }
		public byte[]? BackgroundImageData { get; set; }
		public List<NftCard> NftCollection { get; set; } = new List<NftCard>();
		public virtual Wallet Wallet { get; set; }
		public virtual UserMain User { get; set; }

	}
}
