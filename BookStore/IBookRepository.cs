using System.Collections.Generic;

namespace BookStore
{
    public interface IBookRepository
    {
        List<Book> BooksCollection { get; set; }
    }
}