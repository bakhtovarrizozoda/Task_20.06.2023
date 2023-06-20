using Domain.Entities;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController
{
    private readonly AuthorService _service;

    public AuthorController(AuthorService service)
    {
        _service = service;
    }

    [HttpGet("GetAuthor")]
    public List<AuthorBaseDto> GetAuhtor()
    {
        return _service.GetAuthor();
    }

    [HttpGet("GetById")]
    public AuthorBaseDto GetAuthorById(int id)
    {
        return _service.GetAuthorById(id);
    }

    [HttpPost("AddAuthor")]
    public AddAuthorDto AddAuthor(AddAuthorDto model)
    {
        return _service.AddAuthor(model);
    }

    [HttpPut("UpdateAuthor")]
    public AddAuthorDto UpdateAuthor(AddAuthorDto model)
    {
        return _service.UpdateAuthor(model);
    }

    [HttpDelete("DeleteAuthor")]
    public bool DeleteAuthor(int id)
    {
        return _service.DeleteAuthor(id);
    }
}