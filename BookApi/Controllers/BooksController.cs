using BookApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    // https: //localhost:7082/api/books
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book { Id = 1,Author = "a1", Title = "asd" },
            new Book { Id = 2,Author = "adfg1", Title = "asggd" },
            new Book { Id = 3,Author = "ah1", Title = "asgd" }
        };

        [HttpGet]

        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }


    }
}
