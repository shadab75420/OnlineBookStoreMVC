using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineBookStore.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        public IActionResult OnPost()
        {
            HttpContext.Session
                .SetString("user", Username);

            return RedirectToPage("/Index");
        }
    }
}