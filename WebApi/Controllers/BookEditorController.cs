using Domain.Entities;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BookEditorController
{
    private readonly BookEditorService _service;

    public BookEditorController(BookEditorService service)
    {
        _service = service;
    }
    
    [HttpGet("GetBookEditor")]
    public List<GetBookEditorDto> GetBookEditor()
    {
        return _service.GetBookEditor();
    }

    [HttpGet("GetById")]
    public GetBookEditorDto GetBookEditorById(int id)
    {
        return _service.GetBookEditorById(id);
    }

    [HttpPost("AddBookEditor")]
    public AddBookEditorDto AddBookEditor(AddBookEditorDto model)
    {
        return _service.AddBookEditor(model);
    }

    [HttpPut("UpdateBookEditor")]
    public AddBookEditorDto UpdateBook(AddBookEditorDto model)
    {
        return _service.UpdateEditor(model);
    }

    [HttpDelete("DeleteBook")]
    public bool DeleteBookEditor(int id)
    {
        return _service.DeleteBookEditor(id);
    }
}