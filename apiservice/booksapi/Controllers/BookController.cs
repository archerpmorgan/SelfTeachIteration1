using booksapi.Models;
using booksapi.Data;
using Microsoft.AspNetCore.Mvc;

namespace booksapi.Controllers
{
    [Route("api/")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet("{id}")]
        public Book GetBook(BookContext dbcontext, int id)
        {
            return null;
        }

        [HttpGet("getallbooks")]
        public List<Book> GetAllBooks(BookContext dbcontext)
        {
            //return dummy data
            var bookList = new List<Book>(){
                new Book() {
                    title = "Study of Ephemeral Moments",
                    subject = "Lifeology",
                    author = "Archer Morgan",
                    edition = "1"
                },
            };

            return bookList;
        }

        [HttpGet("librarybooks")]
        public List<Book> GetAllLibraryBooks(BookContext dbcontext)
        {

            //make database query to library database and send






            // var bookList = new List<Book>(){
            //     new Book() {
            //         title = "Linear Algebra Done Right",
            //         subject = "Mathematics",
            //         author = "Sheldon Axler",
            //         edition = "3",
            //         sections = new List<Section>() {
            //             new Section() {
                            
            //             }
            //         }
            //     },
            // };

            return null;
        }
    }
}