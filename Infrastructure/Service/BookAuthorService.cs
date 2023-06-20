using Domain.Entities;
using Infrastructure.Context;

namespace Infrastructure.Service;

public class BookAuthorService
{
    private readonly DataContext _context;

    public BookAuthorService(DataContext context)
    {
        _context = context;
    }

    public List<GetBookAuthorDto> GetBookAuthor()
    {
        return _context.BookAuthors.Select(e=>new GetBookAuthorDto()
        {
            AuthorId = e.AuthorId,
            Isbn = e.Isbn,
            AuthorOrder = e.AuthorOrder,
            Royaltyshare = e.Royaltyshare,
            AuthorName = e.Author.FirstName,
            BookName = e.Book.Title
        }).ToList();
    }
    
    public GetBookAuthorDto? GetBookAuthorById(int id)
    {
        return _context.BookAuthors.Select(e=>new GetBookAuthorDto()
        {
            AuthorId = e.AuthorId,
            Isbn = e.Isbn,
            AuthorOrder = e.AuthorOrder,
            Royaltyshare = e.Royaltyshare,
            AuthorName = e.Author.FirstName,
            BookName = e.Book.Title
        }).FirstOrDefault(p=>p.AuthorId==id);
    }

    public AddBookAuthorDto AddBookAuthor(AddBookAuthorDto model)
    {
        var bookauthor = new BookAuthor()
        {
            Isbn = model.Isbn,
            AuthorId = model.AuthorId,
            AuthorOrder = model.AuthorOrder,
            Royaltyshare = model.Royaltyshare,
        };
        _context.BookAuthors.Add(bookauthor);
        _context.SaveChanges();
        return model;
    }

    public AddBookAuthorDto UpdateBookAuthor(AddBookAuthorDto model)
    {
        var find = _context.BookAuthors.Find(model.AuthorId);
        find.Isbn = model.Isbn;
        find.AuthorOrder = model.AuthorOrder;
        find.Royaltyshare = model.Royaltyshare;
        _context.SaveChanges();
        return model;
    }

    public bool DeleteBookAuthor(int id)
    {
        var find = _context.BookAuthors.Find(id);
        _context.BookAuthors.Remove(find);
        _context.SaveChanges();
        return true;
    }
}