using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Repositories;
using OnlineBookStore.Filters;

namespace OnlineBookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _repository;

        public BookController(
            IBookRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(
                _repository.GetAllBooks());
        }

        [Route("Book/Details/{id:int}")]
        public IActionResult Details(int id)
        {
            var book =
                _repository.GetBookById(id);

            return View(book);
        }
    }
}