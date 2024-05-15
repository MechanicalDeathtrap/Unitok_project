using Microsoft.AspNetCore.Mvc;

namespace Unitok_progect.Areas.Authors.Controllers
{
    [Area("Authors")]
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
