using Domain.Entities;
using Infrastructure.Context;

namespace Infrastructure.Service;

public class PulisherService
{
    private readonly DataContext _context;

    public PulisherService(DataContext context)
    {
        _context = context;
    }

    public List<PublisherBaseDto> GetPulisher()
    {
        return _context.Publishers.Select(e=>new PublisherBaseDto()
        {
            PublisherId = e.PublisherId,
            Name = e.Name,
            Address = e.Address,
            City = e.City,
            State = e.State
        }).ToList();
    }
    
    public PublisherBaseDto? GetPulisherById(int id)
    {
        return _context.Publishers.Select(e=>new PublisherBaseDto()
        {
            PublisherId = e.PublisherId,
            Name = e.Name,
            Address = e.Address,
            City = e.City,
            State = e.State
        }).FirstOrDefault(e=>e.PublisherId==id);
    }

    public AddPublisherDto AddPublisher(AddPublisherDto model)
    {
        var pulisher = new Publisher(model.Name, model.Address, model.City, model.State);
        _context.Publishers.Add(pulisher);
        _context.SaveChanges();
        model.PublisherId = pulisher.PublisherId;
        return model;
    }

    public AddPublisherDto UpdatePublisher(AddPublisherDto model)
    {
        var find = _context.Publishers.Find(model.PublisherId);
        find.Name = model.Name;
        find.Address = model.Address;
        find.City = model.City;
        find.State = model.State;
        _context.SaveChanges();
        return model;
    }

    public bool DeletePulisher(int id)
    {
        var find = _context.Publishers.Find(id);
        _context.Publishers.Remove(find);
        _context.SaveChanges();
        return true;
    }
}