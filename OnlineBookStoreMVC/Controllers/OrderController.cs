using Microsoft.AspNetCore.Mvc;

namespace OnlineBookStore.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Summary()
        {
            return View();
        }

        public IActionResult Confirmation()
        {
            return View();
        }
    }
}