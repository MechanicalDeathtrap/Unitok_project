using Microsoft.AspNetCore.Mvc;

namespace Unitok_progect.Areas.Author.Controllers
{
	[Area("Author")]
	public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
