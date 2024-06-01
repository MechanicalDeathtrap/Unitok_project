using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unitok.Persistence.Repositories;
using Unitok_progect.Persistence.Contexts;
using Unitok_project.Areas.Explore.Models;
using Unitok_project.Models;

namespace Unitok_progect.Areas.Explore.Controllers
{
	[Area("Explore")]
	public class ExploreController : Controller
	{
		private ApplicationDbContext db;
		public ExploreController(ApplicationDbContext context) 
		{
			db = context;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var cardsRepo = new CardsRepository().NftCards;
			var usersRepo = new UsersRepository().Users;

			var model = new ExploreModel 
			{ 
					NftCards = cardsRepo, 
					Users = usersRepo
			};

			return View(model);
			

		}
	}
}
