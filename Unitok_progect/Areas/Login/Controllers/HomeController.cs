using Microsoft.AspNetCore.Mvc;

namespace Unitok_progect.Areas.Login.Controllers
{
	[Area("Login")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			Console.WriteLine("Login");
			return View();
		}

    }
}
