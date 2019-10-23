using Microsoft.AspNetCore.Mvc;
using MongoAPI.Models;
using MongoAPI.Services;
using System.Collections.Generic;

namespace MongoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService documentservice;

        public BooksController(BookService bookService)
        {
            documentservice = bookService;
        }

        [HttpGet]
        public ActionResult<List<Book>> Get() =>
            documentservice.Get();

        [HttpGet("{id:length(24)}", Name = "GetBook")]
        public ActionResult<Book> Get(string id)
        {
            var book = documentservice.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost]
        public ActionResult<Book> Create(Book book)
        {
            documentservice.Create(book);

            return CreatedAtRoute("GetBook", new { id = book.Id.ToString() }, book);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Book bookIn)
        {
            var book = documentservice.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            documentservice.Update(id, bookIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var book = documentservice.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            documentservice.Remove(book.Id);

            return NoContent();
        }
    }
}