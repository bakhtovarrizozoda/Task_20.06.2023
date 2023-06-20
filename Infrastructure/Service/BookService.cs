using Domain.Entities;
using Infrastructure.Context;

namespace Infrastructure.Service;

public class BookService
{
    private readonly DataContext _context;

    public BookService(DataContext context)
    {
        _context = context;
    }

    public List<GetBookDto> GetBook()
    {
        return _context.Books.Select(e=>new GetBookDto()
        {
            Isbn = e.Isbn,
            Title = e.Title,
            Type = e.Type,
            PublisherId = e.PublisherId,
            Price = e.Price,
            Advance = e.Advance,
            Ytdsales = e.Ytdsales,
            PubDate = e.PubDate,
            PublisherName = e.Publisher.Name
        }).ToList();
    }
    
    public GetBookDto? GetBookById(int id)
    {
        return _context.Books.Select(e=>new GetBookDto()
        {
            Isbn = e.Isbn,
            Title = e.Title,
            Type = e.Type,
            PublisherId = e.PublisherId,
            Price = e.Price,
            Advance = e.Advance,
            Ytdsales = e.Ytdsales,
            PubDate = e.PubDate,
            PublisherName = e.Publisher.Name
        }).FirstOrDefault(p=>p.Isbn==id);
    }

    public AddBookDto AddBook(AddBookDto model)
    {
        var books = new Book()
        {
            Title = model.Title,
            Type = model.Type,
            PublisherId = model.PublisherId,
            Price = model.Price,
            Advance = model.Advance,
            Ytdsales = model.Ytdsales,
            PubDate = model.PubDate
        };
        _context.Books.Add(books);
        _context.SaveChanges();
        return model;
    }

    public AddBookDto UpdateBook(AddBookDto model)
    {
        var find = _context.Books.Find(model.Isbn);
        find.Title = model.Title;
        find.Type = model.Type;
        find.PublisherId = model.PublisherId;
        find.Price = model.Price;
        find.Advance = model.Advance;
        find.Ytdsales = model.Ytdsales;
        find.PubDate = model.PubDate;
        _context.SaveChanges();
        return model;
    }

    public bool DeleteBook(int id)
    {
        var find = _context.Books.Find(id);
        _context.Books.Remove(find);
        _context.SaveChanges();
        return true;
    }
}