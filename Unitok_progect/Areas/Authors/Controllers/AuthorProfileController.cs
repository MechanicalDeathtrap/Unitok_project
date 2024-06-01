using Microsoft.AspNetCore.Mvc;
using Unitok.Persistence.Repositories;
using Unitok_progect.Persistence.Contexts;
using Unitok_project.Areas.Authors.Models;

namespace Unitok_project.Areas.Authors.Controllers
{
	[Area("Authors")]

	[Route("/Authors/Author")]
	public class AuthorProfileController : Controller
	{
		private ApplicationDbContext db;
		public AuthorProfileController(ApplicationDbContext context)
		{
			db = context;
		}

		[HttpGet("{id:int}")]//guid
		public async Task<IActionResult> Index(int id)
		{
			Console.WriteLine("Author profile");
			var usersRepo = new UsersRepository().Users;
			var userNfts = new CardsRepository().NftCards;
			var auctions = new AuctionRepository().Auctions;

			var ownedNfts = userNfts.Where(x => x.OwnerId == id).ToList();
			var createdNfts = userNfts.Where(x => x.CreatorId == id).ToList();


			var model = new AuthorProfileModel
			{
				Auctions = auctions,
				User = usersRepo.Where(x => x.Id == id).First(),
				CreatedCards = createdNfts,
				OwnedCards = ownedNfts,
				Authors = usersRepo
			};

			return View(model);
		}
	}
}
