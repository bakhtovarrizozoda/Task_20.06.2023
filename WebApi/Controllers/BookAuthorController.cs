using Domain.Entities;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BookAuthorController
{
    private readonly BookAuthorService _service;

    public BookAuthorController(BookAuthorService service)
    {
        _service = service;
    }
    
    [HttpGet("GetBookAuthor")]
    public List<GetBookAuthorDto> GetBookAuhtor()
    {
        return _service.GetBookAuthor();
    }

    [HttpGet("GetById")]
    public GetBookAuthorDto GetBookAuthorById(int id)
    {
        return _service.GetBookAuthorById(id);
    }

    [HttpPost("AddBookAuthor")]
    public AddBookAuthorDto AddBookAuthor(AddBookAuthorDto model)
    {
        return _service.AddBookAuthor(model);
    }

    [HttpPut("UpdateBookAuthor")]
    public AddBookAuthorDto UpdateBookAuthor(AddBookAuthorDto model)
    {
        return _service.UpdateBookAuthor(model);
    }

    [HttpDelete("DeleteBookAuthor")]
    public bool DeleteAuthor(int id)
    {
        return _service.DeleteBookAuthor(id);
    }
}