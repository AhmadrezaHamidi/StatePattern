using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using vestaabnerMonqo.Models;
using vestaabnerMonqo.Services;

namespace vestaabnerMonqo.Contollers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;

        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<List<Book>> GetsBook() =>
            _bookService.GetBooks();

        [HttpGet("{id:length(24)}", Name = "GetBook")]
        public ActionResult<Book> Get(string id)
        {
            var book = _bookService.GetBookByItemId(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost]
        public ActionResult<Book> CreateBook(Book book)
        {
            _bookService.CreateBook(book);

            return CreatedAtRoute("GetBook", new { id = book._id.ToString() }, book);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult UpdateBook(string id, Book bookIn)
        {
            var book = _bookService.GetBookByItemId(id);

            if (book == null)
            {
                return NotFound();
            }

            _bookService.UpdateBook(id, bookIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var book = _bookService.GetBookByItemId(id);

            if (book == null)
            {
                return NotFound();
            }

            _bookService.RemoveBook(book);

            return NoContent();
        }
    }
}