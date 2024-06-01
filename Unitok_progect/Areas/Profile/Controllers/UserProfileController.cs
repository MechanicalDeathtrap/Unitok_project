using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Unitok.Application.DTOs.User;
using Unitok.Application.Interfaces;
using Unitok.Persistence.Repositories;
using Unitok_progect.Domain.Entities;
using Unitok_progect.Persistence.Contexts;
using Unitok_project.Areas.Authors.Models;
using Unitok_project.Areas.Profile.Controllers;
using Unitok_project.Areas.Profile.Models;
using Unitok_project.Models;

namespace Unitok_progect.Areas.Profile.Controllers
{
	[Area("Profile")]

	public class UserProfileController : Controller
	{

		private ApplicationDbContext db;
		private readonly UserManager<UserMain> _userManager;
		private readonly IUserService _userService;

		private readonly ILogger<UserProfileController> _logger;

		public UserProfileController(ApplicationDbContext context, UserManager<UserMain> userManager, IUserService userService, ILogger<UserProfileController> logger)
		{
			db = context;
			_userManager = userManager;
			_userService = userService;
			_logger = logger;
		}

		public async Task<IActionResult> Index(int id)
		{
			var authors  = new UsersRepository().Users;
			var auctions = new AuctionRepository().Auctions;
			var cards = new CardsRepository().NftCards;
			var earnings = new WalletsRepository().Wallets;
			//var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
			//var user = await _userService.GetUserProfileAsync(userId);
			var userMain = await _userManager.GetUserAsync(User);
			var user = authors.Where(x => x.Id == userMain.Id).First();


			var ownedCards = cards.Where(x => x.OwnerId == user.Id).ToList();
			var createdCards = cards.Where(x => x.CreatorId == user.Id).ToList();
			var avatarData = user.AvatarImageData;
			var backData = user.BackgroundImageData ;

			var model = new UserProfileDto
			{
				Id = id,
				FirstName = user.FirstName ?? string.Empty,
				LastName = user.LastName ?? string.Empty,
				NickName = user.NickName ?? string.Empty,
				Description = user.Description ?? string.Empty,
				AvatarImageUrl = user.AvatarImageUrl ?? string.Empty,
				BackgroundImageUrl = user.BackgroundImageUrl ?? string.Empty,
				FollowersNumber = user.FollowersNumber,
				WalletBalance = earnings.Where(x => x.UserInfoId == user.Id).First().Earnings,
				OwnedCards = ownedCards,
				CreatedCards = createdCards,
				OtherAuthors = authors,
				Auctions = auctions,
				AvatarImageData = avatarData,
				BackgroundImageData = backData
			};

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateProfile(UserProfileDto dto)
		{
			if (ModelState.IsValid)
			{
				var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
				var userMain = await _userManager.FindByIdAsync(userId.ToString());
				var user = new UsersRepository().Users.FirstOrDefault(x => x.Id == userMain.UserInfoId);

				if (user == null)
				{
					return NotFound();
				}

				byte[] avatarData = null;
				byte[] backgroundData = null;


				if (dto.AvatarImageFile != null && dto.AvatarImageFile.Length > 0)
				{
					_logger.LogInformation("avatarImage not null");
					using (var memoryStream = new MemoryStream())
					{
						await dto.AvatarImageFile.CopyToAsync(memoryStream);
						avatarData = memoryStream.ToArray();
					}
				}

				if (dto.BackgroundImageFile != null && dto.BackgroundImageFile.Length > 0)
				{
					using (var memoryStream = new MemoryStream())
					{
						await dto.BackgroundImageFile.CopyToAsync(memoryStream);
						backgroundData = memoryStream.ToArray();
					}
				}

				if (string.IsNullOrEmpty(dto.FirstName))
				{
					dto.FirstName = user.FirstName ;
				}

				if (string.IsNullOrEmpty(dto.LastName))
				{
					 dto.LastName = user.LastName ;
				}

				if (string.IsNullOrEmpty(dto.Description))
				{
					dto.Description = user.Description;
				}

				if (string.IsNullOrEmpty(dto.NickName))
				{
					dto.NickName = user.NickName;
				}

				if (avatarData != null)
				{
					dto.AvatarImageData = avatarData;
				}
				else { dto.AvatarImageData = user.AvatarImageData; }

				if (backgroundData != null)
				{
					dto.BackgroundImageData = backgroundData;
				}
				else { dto.BackgroundImageData = user.BackgroundImageData; }

				await _userService.UpdateUserProfileAsync(userId, dto);
				return Redirect("/Profile/UserProfile/Index");
			}

			return View(dto);
		}

	}
}
