using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineBookStore.Models;
using OnlineBookStore.Repositories;

namespace OnlineBookStore.Pages.Books
{
    public class AddBookModel : PageModel
    {
        private readonly IBookRepository _repository;

        public AddBookModel(
            IBookRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _repository.AddBook(Book);

                return RedirectToPage();
            }

            return Page();
        }
    }
}