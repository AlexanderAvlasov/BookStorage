using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using CoreLogic;
using CoreLogic.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        SQLiteConnection connection;
        public BooksController(SQLiteConnection connection)
        {
            this.connection = connection;
        }
        
        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Fuck yourself", "Rick and Morty the best" };
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value= "+id;
        }

        [HttpGet("GetBookList")]
        public List<Book> GetBookList() {
            //BookRepository br = new BookRepository();
            List<Book> books = new List<Book>();
            SQLiteCommand sql = connection.CreateCommand();
            sql.CommandText = @"SELECT * FROM books";
            var reader = sql.ExecuteReader();
            while (reader.Read()) {
                books.Add(new Book { Id=reader.GetInt32(0), Name=reader.GetString(1),Author=reader.GetString(2), Pages=reader.GetInt32(3)});
            }
            return books;
        }

        [HttpPost("AddNewBook")]
        public ActionResult AddNewBook([FromBody]Book book) {
            SQLiteCommand dml = connection.CreateCommand();
            dml.CommandText = @"INSERT INTO books(name, author, pages)
                                VALUES(@name, @author, @pages)";
            dml.Parameters.Add(new SQLiteParameter{ ParameterName = "@name", Value=book.Name, DbType = DbType.String });
            dml.Parameters.Add(new SQLiteParameter{ ParameterName = "@author", Value = book.Author , DbType = DbType.String});
            dml.Parameters.Add(new SQLiteParameter{ ParameterName = "@pages", Value = book.Pages, DbType = DbType.Int32 });

            dml.ExecuteNonQuery();
            return Ok();
        }


        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}
