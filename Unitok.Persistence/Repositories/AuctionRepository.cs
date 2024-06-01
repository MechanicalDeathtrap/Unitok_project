using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitok_progect.Domain.Entities;
using Unitok_progect.Persistence.Contexts;

namespace Unitok.Persistence.Repositories
{
	public class AuctionRepository
	{
		public List<Auction> Auctions { get; set; } = new List<Auction>();

		public AuctionRepository()
		{
			Auctions = GetAuctions().Result;
		}
		public async Task<List<Auction>> GetAuctions()
		{
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				return await db.Auctions.ToListAsync();
			}
		}
	}
}
