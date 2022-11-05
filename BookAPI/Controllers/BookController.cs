using Application.Interfaces;
using Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook bookobj;
        public BookController (IBook bookobj)
        {
            this.bookobj = bookobj;
        }

        [HttpGet]

        public  IList<Book> GetAll ()
        {
            return bookobj.GetAll ();
        }

        [HttpGet("{Id}")]
        public  ActionResult<Book> GetBookById (int Id)
        {
            return bookobj.GetBookById (Id);
        }

        [HttpDelete("{Id}")]

        public  ActionResult<string> deleteBook (int Id)
        {
            return  bookobj.DeleteBook (Id);
        }

        [HttpPost]
        public ActionResult<string> AddBook(Book book)
        {
            return bookobj.AddBook (book);
        }

    }
}
