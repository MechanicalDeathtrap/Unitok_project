using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unitok.Persistence.Repositories;
using Unitok_progect.Persistence.Contexts;
using Unitok_project.Areas.Authors.Models;
using Unitok_project.Areas.Explore.Models;

namespace Unitok_progect.Areas.Authors.Controllers
{
    [Area("Authors")]
    public class AuthorsController : Controller
    {
		private ApplicationDbContext db;
		public AuthorsController(ApplicationDbContext context)
		{
			db = context;
		}
		public async Task<IActionResult> Index()
		{
			var usersRepo = new UsersRepository().Users;

			var model = new AuthorsModel
			{
				Authors = usersRepo
			};

			return View(model);
		}
	}
}
