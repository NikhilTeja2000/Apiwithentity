using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Apiwithentity.Model;

namespace Apiwithentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository _booksRepository;

        public BooksController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var data = _booksRepository.GetAllBooks();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = _booksRepository.GetAllBooksByBookId(id);
            if (data == null)
                return NotFound("no record found using id:" + id);
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post(Books books)
        {
            var data = _booksRepository.AddBooks(books);
            if (data == null)
                return BadRequest("try again if possible..");
            return Created(HttpContext.Request.Scheme +
               "://" + HttpContext.Request.Host + "/" + HttpContext.Request.Path + "/" +
               books.Id, data);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _booksRepository.DeleteBooks(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Books books)
        {
            var data = _booksRepository.UpdateBooks(books,id);
            return Ok(data);
        }

    }
}
