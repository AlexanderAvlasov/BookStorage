using CoreLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLogic
{
    public class BookRepository : IBookRepository
    {
        public List<Book> BooksCollection { get; set; }

        public BookRepository()
        {
            BooksCollection = new List<Book>();
            BooksCollection.Add(new Book { Id = 1, Author = "Сунь-Цзы", Name = "ИСКУССТВО ВОЙНЫ", Pages = 1210 });
            BooksCollection.Add(new Book { Id = 2, Author = "Майкл Фарадей", Name = "История свечи", Pages = 166 });
        }



    }
}
