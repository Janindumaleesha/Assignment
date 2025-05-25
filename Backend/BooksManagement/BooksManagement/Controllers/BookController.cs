using BooksManagement.Interfaces;
using BooksManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BooksManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;

        public BookController(IBookService _bookService)
        {
            bookService = _bookService;
        }

        [HttpPost]
        public async Task<ActionResult<ResponseResult>> Insert([Required, FromBody] ModelBookDetails model)
        {
            return await bookService.Insert(model);
        }

        [HttpPut]
        [Route("{bookId:Guid}")]
        public async Task<ActionResult<ResponseResult>> Update([Required, FromRoute] Guid bookId, [Required, FromBody] ModelBookDetails model)
        {
            return await bookService.Update(bookId, model);
        }

        [HttpDelete]
        [Route("{bookId:Guid}")]
        public async Task<ActionResult<ResponseResult>> Delete([Required, FromRoute] Guid bookId)
        {
            return await bookService.Delete(bookId);
        }

        [HttpGet]
        public async Task<ActionResult<ResponseResult>> SelectAll()
        {
            return await bookService.SelectAll();
        }

        [HttpGet]
        [Route("{bookId:Guid}")]
        public async Task<ActionResult<ResponseResult>> SelectById([Required, FromRoute] Guid bookId)
        {
            return await bookService.SelectById(bookId);
        }
    }
}
