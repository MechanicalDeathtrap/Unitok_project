using Unitok_progect.Domain.Entities;

namespace Unitok_project.Areas.Profile.Models
{
	public class UserProfileModel
	{
		public UserInfo User { get; set; }
		public List<NftCard> OwnedCards { get; set; }
		public List<NftCard> CreatedCards { get; set; }
		public List<Auction> Auctions { get; set; }
		public List<UserInfo> Authors { get; set; }
		public Wallet Wallet { get; set; }
	}
}
