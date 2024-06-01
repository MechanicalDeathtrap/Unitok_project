using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Unitok.Application.DTOs.Cards;
using Unitok.Persistence.Repositories;
using Unitok_progect.Areas.Register.Controllers;
using Unitok_progect.Domain.Entities;
using Unitok_progect.Persistence.Contexts;
using Unitok_project.Areas.Profile.Models;

namespace Unitok_project.Areas.Profile.Controllers
{
	[Area("Profile")]
	public class CreateCardController : Controller
	{
		private ApplicationDbContext db;
		private readonly UserManager<UserMain> _userManager;
		private readonly ILogger<CreateCardController> _logger;

		public CreateCardController(ApplicationDbContext context, UserManager<UserMain> userManager, ILogger<CreateCardController> logger)
		{
			db = context;
			_userManager = userManager;
			_logger = logger;
		}
		[HttpGet]
		public async Task<IActionResult> Index()
		{
/*			var user = await _userManager.GetUserAsync(User);
			var usersRepo = new UsersRepository().Users;
			var userNfts = new CardsRepository().NftCards;
			var auctions = new AuctionRepository().Auctions;
			var wallets = new WalletsRepository().Wallets;

			var ownedNfts = userNfts.Where(x => x.OwnerId == user.Id).ToList();
			var createdNfts = userNfts.Where(x => x.CreatorId == user.Id).ToList();


			var model = new UserProfileModel
			{
				Auctions = auctions,
				User = usersRepo.Where(x => x.Id == user.Id).First(),
				CreatedCards = createdNfts,
				OwnedCards = ownedNfts,
				Authors = usersRepo,
				Wallet = wallets.Where(x => x.Id == user.Id).First()
			};*/

			//return View(/*model*/);
			return View("CreateCard");
		}

		[HttpPost("/CreateCard/CreateCard")]
		public async Task<IActionResult> CreateCard(CreateCardDto model)
		{
			_logger.LogInformation(ModelState.IsValid.ToString());
			if (ModelState.IsValid)
			{
				var user = await _userManager.GetUserAsync(User);
				if (user == null)
				{
					_logger.LogInformation("Пользователь не найден");
					return RedirectToRoute("default", new { area = "", controller = "Home", action = "Index" });
				}

				byte[] imageData = null;
				if (model.Image != null && model.Image.Length > 0)
				{
					using (var memoryStream = new MemoryStream())
					{
						await model.Image.CopyToAsync(memoryStream);
						imageData = memoryStream.ToArray();
					}
				}


				Auction auction = null;
				if (model.isOnAuction)
				{
					auction = new Auction()
					{
						Id = new Random().Next(1000, 100000),
						StartingPrice = model.Price,
						StartTime = DateTime.Now,
						EndTime = DateTime.Now.AddDays(3),
						Bids = new List<Bid>()
					};
				}
				
				var card = new NftCard
				{
					Name = model.Name,
					Description = model.Description,
					CategoryId = model.Category,
					IsOnAuction = model.isOnAuction,
					ImageData = imageData,
					OwnerId = user.Id,
					CreatorId = user.Id,
					isOnSale = model.isOnInstantSale,
					Auction = auction,
					Price = model.Price
				};

				db.NftCards.Add(card);
				await db.SaveChangesAsync();

				return RedirectToAction("Index", "UserProfile");
			}

			foreach (var modelState in ModelState.Values)
			{
				foreach (var error in modelState.Errors)
				{
					_logger.LogError(error.ErrorMessage);
				}
			}

			if (model.Image == null)
			{
				_logger.LogInformation("Изображение не прикреплено");
				TempData["Error"] = "Заполните все поля!";
				RedirectToAction(nameof(Index));
			}

			_logger.LogInformation("Модель не валидна");

			return View(model);
		}
	}
}
