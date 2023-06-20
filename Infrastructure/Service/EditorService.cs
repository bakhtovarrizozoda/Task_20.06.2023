using Domain.Entities;
using Infrastructure.Context;

namespace Infrastructure.Service;

public class EditorService
{
    private readonly DataContext _context;

    public EditorService(DataContext context)
    {
        _context = context;
    }

    public List<GetEditorDto> GetEditor()
    {
        return _context.Editors.Select(e=>new GetEditorDto()
        {
            EditorId = e.EditorId,
            SSN = e.SSN,
            FirstName = e.FirstName,
            LastName = e.LastName,
            Phone = e.Phone,
            EditorPosition = e.EditorPosition,
            Salary = e.Salary
        }).ToList();
    }
    
    public GetEditorDto? GetEditorById(int id)
    {
        return _context.Editors.Select(e=>new GetEditorDto()
        {
            EditorId = e.EditorId,
            SSN = e.SSN,
            FirstName = e.FirstName,
            LastName = e.LastName,
            Phone = e.Phone,
            EditorPosition = e.EditorPosition,
            Salary = e.Salary
        }).FirstOrDefault(p=>p.EditorId==id);
    }

    public AddEditorDto AddEditor(AddEditorDto model)
    {
        var editor = new Editor(model.SSN, model.FirstName,model.LastName, model.Phone, model.EditorPosition, model.Salary);
        _context.Editors.Add(editor);
        _context.SaveChanges();
        model.EditorId = editor.EditorId;
        return model;
    }

    public AddEditorDto UpdateEditor(AddEditorDto model)
    {
        var find = _context.Editors.Find(model.EditorId);
        find.SSN = model.SSN;
        find.FirstName = model.FirstName;
        find.LastName = model.LastName;
        find.Phone = model.Phone;
        find.EditorPosition = model.EditorPosition;
        find.Salary = model.Salary;
        _context.SaveChanges();
        return model;
    }

    public bool DeleteEditor(int id)
    {
        var find = _context.Editors.Find(id);
        _context.Editors.Remove(find);
        _context.SaveChanges();
        return true;
    }
}