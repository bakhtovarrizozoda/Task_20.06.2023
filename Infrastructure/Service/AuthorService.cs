using Domain.Entities;
using Infrastructure.Context;

namespace Infrastructure.Service;

public class AuthorService
{
    private readonly DataContext _context;

    public AuthorService(DataContext context)
    {
        _context = context;
    }

    public List<AuthorBaseDto> GetAuthor()
    {
        return _context.Authors.Select(e=>new AuthorBaseDto()
        {
            AuthorId = e.AuthorId,
            SSN = e.SSN,
            FirstName = e.FirstName,
            LastName = e.LastName,
            Phone = e.Phone,
            Address = e.Address,
            City = e.City,
            State = e.State,
            Zip = e.Zip
        }).ToList();
    }
    
    public AuthorBaseDto? GetAuthorById(int id)
    {
        return _context.Authors.Select(e=>new AuthorBaseDto()
        {
            AuthorId = e.AuthorId,
            SSN = e.SSN,
            FirstName = e.FirstName,
            LastName = e.LastName,
            Phone = e.Phone,
            Address = e.Address,
            City = e.City,
            State = e.State,
            Zip = e.Zip
        }).FirstOrDefault(p=>p.AuthorId==id);
    }

    public AddAuthorDto AddAuthor(AddAuthorDto model)
    {
        var author = new Author(model.SSN, model.FirstName, model.LastName, model.Phone, model.Address, model.City, model.State, model.Zip);
        _context.Authors.Add(author);
        _context.SaveChanges();
        model.AuthorId = author.AuthorId;
        return model;
    }

    public AddAuthorDto UpdateAuthor(AddAuthorDto model)
    {
        var find = _context.Authors.Find(model.AuthorId);
        find.SSN = model.SSN;
        find.FirstName = model.FirstName;
        find.LastName = model.LastName;
        find.Phone = model.Phone;
        find.Address = model.Address;
        find.City = model.City;
        find.State = model.State;
        find.Zip = model.Zip;
        _context.SaveChanges();
        return model;
    }

    public bool DeleteAuthor(int id)
    {
        var find = _context.Authors.Find(id);
        _context.Authors.Remove(find);
        _context.SaveChanges();
        return true;
    }
}