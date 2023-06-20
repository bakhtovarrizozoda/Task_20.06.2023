using Domain.Entities;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PulisherController
{
    private readonly PulisherService _service;

    public PulisherController(PulisherService service)
    {
        _service = service;
    }
    
    [HttpGet("GetPublisher")]
    public List<PublisherBaseDto> GetPulisher()
    {
        return _service.GetPulisher();
    }

    [HttpGet("GetById")]
    public PublisherBaseDto? GetPulisherById(int id)
    {
        return _service.GetPulisherById(id);
    }

    [HttpPost("AddPublisher")]
    public AddPublisherDto AddPublisher(AddPublisherDto model)
    {
        return _service.AddPublisher(model);
    }

    [HttpPut("UpdatePublisher")]
    public AddPublisherDto UpdatePublisher(AddPublisherDto model)
    {
        return _service.UpdatePublisher(model);
    }

    [HttpDelete("DeleteBook")]
    public bool DeletePulisher(int id)
    {
        return _service.DeletePulisher(id);
    }
}