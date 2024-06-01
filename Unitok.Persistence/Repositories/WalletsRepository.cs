using Microsoft.EntityFrameworkCore;
using Unitok_progect.Domain.Entities;
using Unitok_progect.Persistence.Contexts;

namespace Unitok.Persistence.Repositories
{
	public class WalletsRepository
	{
		public List<Wallet> Wallets { get; set; } = new List<Wallet>();

		public WalletsRepository()
		{
			Wallets = GetWallets().Result;
		}
		public async Task<List<Wallet>> GetWallets()
		{
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				return await db.Wallets.ToListAsync();
			}
		}
	}
}
