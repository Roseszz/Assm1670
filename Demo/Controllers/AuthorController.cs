using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
