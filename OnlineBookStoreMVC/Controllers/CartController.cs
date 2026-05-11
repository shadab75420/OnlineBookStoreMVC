using Microsoft.AspNetCore.Mvc;

namespace OnlineBookStore.Controllers
{
    public class CartController : Controller
    {
        public IActionResult ViewCart()
        {
            return View();
        }

        public IActionResult AddToCart()
        {
            return RedirectToAction("ViewCart");
        }
    }
}