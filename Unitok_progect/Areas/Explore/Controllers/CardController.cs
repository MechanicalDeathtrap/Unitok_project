using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using Unitok.Persistence.Repositories;
using Unitok_progect.Domain.Entities;
using Unitok_progect.Models;
using Unitok_progect.Persistence.Contexts;
using Unitok_project.Areas.Explore.Models;

namespace Unitok_project.Areas.Explore.Controllers
{
	[Area("Explore")]
	[Route("/Explore/Card")]
	public class CardController: Controller
	{
		private ApplicationDbContext db;
		public CardController(ApplicationDbContext context)
		{
			db = context;
		}

		[HttpGet("{id:int}")]//guid
		public async Task<IActionResult> Index(int id)
		{
			var cardsRepo = new CardsRepository().NftCards;
			var usersRepo = new UsersRepository().Users;
			var auctions = new AuctionRepository().Auctions;


			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				var card = cardsRepo.Where(x => x.Id == id).First();
				var cardAuction = new Auction()
				{
					Id = 0, StartingPrice = 0,
					StartTime = new DateTime(),
					EndTime = new DateTime(),
					Bids = new List<Bid>()
				};
				var user = usersRepo.Where(x => x.Id == card.OwnerId).First();
				var ownedCard = cardsRepo.Where(x => x.OwnerId == user.Id).ToList();

				if (auctions.Count > 0)
					cardAuction = auctions.Where(x => x.Id == card.AuctionId).First();

				var model = new CardModel
				{
					Card = card,
					NftCards = ownedCard,
					UserInfo = user,
					CardAuction = cardAuction,
				};

				return View(model);
			};
		}

		[HttpPost("BuyCard/{cardId:int}")]
		public async Task<IActionResult> BuyCard(int cardId)
		{
			var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

			var card = await db.NftCards.FirstOrDefaultAsync(x => x.Id == cardId);
			if (card == null)
			{
                TempData["Error"] = "Карточка не найдена";
                return RedirectToAction(nameof(Index), new { id = cardId });
            }

			var buyerWallet = await db.Wallets.FirstOrDefaultAsync(x => x.UserInfoId == userId);
			if (buyerWallet == null || buyerWallet.Earnings < card.Price)
			{
/*				var errorModel = new ErrorViewModel
				{
					Message = "У вас не достаточно токенов для покупки этой карточки"
				};*/
                TempData["Error"] = "У вас не достаточно токенов для покупки этой карточки";
                return RedirectToAction(nameof(Index), new { id = cardId });
/*                return View("Index", errorModel);*/
			}

			var sellerWallet = await db.Wallets.FirstOrDefaultAsync(x => x.UserInfoId == card.OwnerId);
			if (sellerWallet == null)
			{
				TempData["Error"] = "Кошелёк владельца карты не найден";
                return RedirectToAction(nameof(Index), new { id = cardId });
/*				var errorModel = new ErrorViewModel
				{
					Message = "Кошелёк владельца карты не найден"
				};
				return View("Index", errorModel);*/
			}

			buyerWallet.Earnings -= card.Price;
			sellerWallet.Earnings += card.Price;

			card.OwnerId = userId;

			db.NftCards.Update(card);
			db.Wallets.Update(buyerWallet);
			db.Wallets.Update(sellerWallet);
			await db.SaveChangesAsync();

			return RedirectToAction(nameof(Index), new { id = cardId });
		}

        [HttpGet]
        public IActionResult Error()
        {
            var model = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(model);
        }
    }
}
