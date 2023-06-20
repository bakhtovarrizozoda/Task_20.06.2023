using Domain.Entities;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController
{
    private readonly BookService _service;

    public BookController(BookService service)
    {
        _service = service;
    }
    
    [HttpGet("GetBook")]
    public List<GetBookDto> GetBook()
    {
        return _service.GetBook();
    }

    [HttpGet("GetById")]
    public GetBookDto GetBookById(int id)
    {
        return _service.GetBookById(id);
    }

    [HttpPost("AddBook")]
    public AddBookDto AddBook(AddBookDto model)
    {
        return _service.AddBook(model);
    }

    [HttpPut("UpdateBook")]
    public AddBookDto UpdateBook(AddBookDto model)
    {
        return _service.UpdateBook(model);
    }

    [HttpDelete("DeleteBook")]
    public bool DeleteBook(int id)
    {
        return _service.DeleteBook(id);
    }
}