using Domain.Entities;
using Infrastructure.Context;

namespace Infrastructure.Service;

public class BookEditorService
{
    private readonly DataContext _context;

    public BookEditorService(DataContext context)
    {
        _context = context;
    }

    public List<GetBookEditorDto> GetBookEditor()
    {
        return _context.BookEditors.Select(e=>new GetBookEditorDto()
        {
            EditorId = e.EditorId,
            BookIsbn = e.BookIsbn,
            EditorName = e.Editor.FirstName,
            BookName = e.Book.Title
        }).ToList();
    }
    
    public GetBookEditorDto? GetBookEditorById(int id)
    {
        return _context.BookEditors.Select(e=>new GetBookEditorDto()
        {
            EditorId = e.EditorId,
            BookIsbn = e.BookIsbn,
            EditorName = e.Editor.FirstName,
            BookName = e.Book.Title
        }).FirstOrDefault(p=>p.EditorId==id);
    }

    public AddBookEditorDto AddBookEditor(AddBookEditorDto model)
    {
        var bookeditor = new BookEditor(model.EditorId, model.BookIsbn);
        _context.BookEditors.Add(bookeditor);
        _context.SaveChanges();
        return model;
    }

    public AddBookEditorDto UpdateEditor(AddBookEditorDto model)
    {
        var find = _context.BookEditors.Find(model.EditorId);
        find.EditorId = model.EditorId;
        find.BookIsbn = model.BookIsbn;
        _context.SaveChanges();
        return model;
    }

    public bool DeleteBookEditor(int id)
    {
        var find = _context.BookEditors.Find(id);
        _context.BookEditors.Remove(find);
        _context.SaveChanges();
        return true;
    }
}