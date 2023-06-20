using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Author
{
    public Author()
    {
        
    }
    public Author(int modelSsn, string modelFirstName, string modelLastName, string modelPhone, string modelAddress, string modelCity, string modelState, string modelZip)
    {
        SSN = modelSsn;
        FirstName = modelFirstName;
        LastName = modelLastName;
        Phone = modelPhone;
        Address = modelAddress;
        City = modelCity;
        State = modelState;
        Zip = modelZip;
    }

    [Key]
    public int AuthorId { get; set; }
    [Required]
    public int SSN { get; set; }
    [Required, MaxLength(50)]
    public string FirstName { get; set; }
    [Required, MaxLength(50)]
    public string LastName { get; set; }
    [Required, MaxLength(50)]
    public string Phone { get; set; }
    [Required, MaxLength(50)]
    public string Address { get; set; }
    [Required, MaxLength(50)]
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public List<BookAuthor> BookAuthors { get; set; }
}