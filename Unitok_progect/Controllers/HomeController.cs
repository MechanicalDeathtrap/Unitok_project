using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Unitok_progect.Models;
using Unitok_project.Models;
using Unitok_progect.Persistence.Contexts;
using Unitok_progect.Domain.Entities;
using Unitok.Persistence.Repositories;
using Unitok_project.Areas.Explore.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Identity;

namespace Unitok_progect.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		private ApplicationDbContext db;
		private readonly UserManager<UserMain> _userManager;
		public HomeController(ApplicationDbContext context, UserManager<UserMain> userManager)
		{
			db = context;
			_userManager = userManager;
		}

		public async Task<IActionResult> Index()
		{
			var cardsRepo = new CardsRepository().NftCards;
			var usersRepo = new UsersRepository().Users;
			var auctionsRepo = new AuctionRepository().Auctions;
			var walletsRepo = new WalletsRepository().Wallets;

			var user = await _userManager.GetUserAsync(User);
			var wallet = new Wallet { Earnings = 0 };

			if (user is not null)
			{
				wallet = walletsRepo.Where(x => x.Id == user.Id).First();
			}

			var model = new HomeModel
				{
					NftCards = cardsRepo,
					Users = usersRepo,
					Auctions = auctionsRepo,
					Wallets = walletsRepo,
					AuthorizedUserWallet = wallet
				};

				return View(model);

		}
	}
}