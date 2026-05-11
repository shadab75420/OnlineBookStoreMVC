using OnlineBookStore.Models;

namespace OnlineBookStore.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();

        Book GetBookById(int id);

        void AddBook(Book book);
    }
}