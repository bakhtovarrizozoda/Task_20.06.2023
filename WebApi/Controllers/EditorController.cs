using Domain.Entities;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EditorController
{
    private readonly EditorService _service;

    public EditorController(EditorService service)
    {
        _service = service;
    }
    
    [HttpGet("GetEditor")]
    public List<GetEditorDto> GetEditor()
    {
        return _service.GetEditor();
    }

    [HttpGet("GetById")]
    public GetEditorDto GetEditorById(int id)
    {
        return _service.GetEditorById(id);
    }

    [HttpPost("AddEditor")]
    public AddEditorDto AddEditor(AddEditorDto model)
    {
        return _service.AddEditor(model);
    }

    [HttpPut("UpdateEditor")]
    public AddEditorDto UpdateBook(AddEditorDto model)
    {
        return _service.UpdateEditor(model);
    }

    [HttpDelete("DeleteBook")]
    public bool DeleteBookEditor(int id)
    {
        return _service.DeleteEditor(id);
    }
}