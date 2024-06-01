using Microsoft.EntityFrameworkCore;
using Unitok.Application.DTOs.Cards;
using Unitok.Application.Interfaces.Repositories;
using Unitok_progect.Domain.Entities;
using Unitok_progect.Persistence.Contexts;

namespace Unitok.Persistence.Repositories
{
	public class CardsRepository //: ICardRepository
	{
		public List<NftCard> NftCards { get; set; } = new List<NftCard>();

		public CardsRepository() {

			NftCards = GetCards().Result;
		}
		public async Task<List<NftCard>> GetCards()
		{
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				return await db.NftCards.ToListAsync();
			}
		}
/*		private readonly ApplicationDbContext _context;

		public CardRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public IQueryable<NftCard> Entities => _context.NftCards;

		public DbContext Context => _context;
		public Task<NftCard> GetByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<NftCard>> GetAllAsync()
		{
			return await _context.NftCards
				.Include(i => i.Url)
				.Include(i => i.OwnerId)
				.Include(i => i.CreatorId)
				.Include(i => i.Category)
				.Include(i => i.Auction)
				.ToListAsync();
		}

		public Task<NftCard> AddAsync(NftCard entity)
		{
			throw new NotImplementedException();
		}

		public Task UpdateAsync(NftCard entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(NftCard entity)
		{
			throw new NotImplementedException();
		}*/
	}
}
