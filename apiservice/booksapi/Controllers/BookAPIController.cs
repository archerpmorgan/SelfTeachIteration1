using booksapi.Models;
using booksapi.Data;
using Microsoft.AspNetCore.Mvc;

namespace booksapi.Controllers
{
    [Route("api/BookAPI")]
    [ApiController]
    public class BookAPIController : ControllerBase
    {
        [HttpGet]
        public Book GetBook(BookContext dbcontext, int id)
        {
            return null;
        }
    }
}