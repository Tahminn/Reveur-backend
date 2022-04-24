using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;

namespace Api.Controllers
{
    public class BookController : BaseController
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _bookService.GetAllAsync());
        }

        [HttpGet]
        [Route("GetDetails/{id}")]
        public async Task<IActionResult> GetById([FromRoute]int id)
        {
            return Ok(await _bookService.GetByIdAsync(id));
        }
    }
}
