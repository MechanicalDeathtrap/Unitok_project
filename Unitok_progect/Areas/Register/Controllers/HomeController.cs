using Microsoft.AspNetCore.Mvc;

namespace Unitok_progect.Areas.Register.Controllers
{
	[Area("Register")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
