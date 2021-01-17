using Microsoft.AspNetCore.Mvc;
using RestVerbs.Business;
using RestVerbs.Models;

namespace RestVerbs.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BooksController : ControllerBase
  {
    private readonly IBooksBusiness _bookBusiness;
    public BooksController(IBooksBusiness bookBusiness)
    {
      _bookBusiness = bookBusiness;
    }

    [HttpGet]
    public IActionResult Get()
    {
      return Ok(_bookBusiness.FindAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
      var book = _bookBusiness.FindById(id);
      if (book == null) return NotFound();
      return Ok(book);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Books books)
    {
      if (books == null) return BadRequest();
      return Ok(_bookBusiness.Create(books));
    }

    [HttpPut]
    public IActionResult Put([FromBody] Books books)
    {
      if (books == null) return BadRequest();
      return Ok(_bookBusiness.Update(books));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
      _bookBusiness.Delete(id);
      return NoContent();
    }
  }
}