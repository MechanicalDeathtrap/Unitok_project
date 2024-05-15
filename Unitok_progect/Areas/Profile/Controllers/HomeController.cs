using Microsoft.AspNetCore.Mvc;

namespace Unitok_progect.Areas.Profile.Controllers
{
	[Area("Profile")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
