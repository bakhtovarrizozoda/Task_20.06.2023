using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Editor
{
    public Editor()
    {
        
    }
    public Editor(int modelSsn, string modelFirstName, string modelLastName, string modelPhone, string modelEditorPosition, decimal modelSalary)
    {
        SSN = modelSsn;
        FirstName = modelFirstName;
        LastName = modelLastName;
        Phone = modelPhone;
        EditorPosition = modelEditorPosition;
        Salary = modelSalary;
    }

    [Key]
    public int EditorId { get; set; }
    [Required]
    public int SSN { get; set; }
    [Required, MaxLength(50)]
    public string FirstName { get; set; }
    [Required, MaxLength(50)]
    public string LastName { get; set; }
    [Required, MaxLength(50)]
    public string Phone { get; set; }
    [Required, MaxLength(50)]
    public string EditorPosition { get; set; }
    [Required]
    public decimal Salary { get; set; }
    public List<BookEditor> BookEditors { get; set; }
}