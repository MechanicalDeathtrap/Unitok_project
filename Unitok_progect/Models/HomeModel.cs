using Unitok_progect.Domain.Entities;

namespace Unitok_project.Models
{
	public class HomeModel
	{
		public List<NftCard> NftCards;
		public List<UserInfo> Users;
		public List<Auction> Auctions;
		public List<Wallet> Wallets;
		public Wallet AuthorizedUserWallet;

		public NftCard NftCard;
	}
}
