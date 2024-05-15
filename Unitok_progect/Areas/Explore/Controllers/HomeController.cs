using Microsoft.AspNetCore.Mvc;

namespace Unitok_progect.Areas.Explore.Controllers
{
	[Area("Explore")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
