namespace Domain.Entities;

public class EditorBaseDto
{
    public int EditorId { get; set; }
    public int SSN { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string EditorPosition { get; set; }
    public decimal Salary { get; set; }
}