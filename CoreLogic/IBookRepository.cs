using CoreLogic.Model;
using System.Collections.Generic;

namespace CoreLogic
{
    public interface IBookRepository
    {
        List<Book> BooksCollection { get; set; }
    }
}