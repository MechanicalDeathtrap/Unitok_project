using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok_progect.Domain.Entities;

namespace Unitok.Application.DTOs.User
{
	public class UserProfileDto
	{
		public int? Id { get; set; }
		public string? FirstName { get; set; } = null;
		public string? LastName { get; set; } = null;
		public string? NickName { get; set; }
		public string? Description { get; set; } = null;
		public string? AvatarImageUrl { get; set; } = null;
		public byte[]? AvatarImageData { get; set; } = null;
		public string? BackgroundImageUrl { get; set; } = null;
		public byte[]? BackgroundImageData { get; set; } = null;
		public int?	 FollowersNumber { get; set; }

		public List<NftCard>? OwnedCards { get; set; } = null;
		public List<NftCard>? CreatedCards { get; set; } = null;
		public List<UserInfo>? OtherAuthors { get; set; } 
		public List<Auction>? Auctions { get; set; } = null;
		public decimal? WalletBalance { get; set; }

		public IFormFile? AvatarImageFile { get; set; } = null;
		public IFormFile? BackgroundImageFile { get; set; } = null;
	}

}
