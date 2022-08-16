using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
