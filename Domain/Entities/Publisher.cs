using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Publisher
{
    public Publisher()
    {
        
    }
    public Publisher(string modelName, string modelAddress, string modelCity, string modelState)
    {
        Name = modelName;
        Address = modelAddress;
        City = modelCity;
        State = modelState;
    }

    [Key]
    public int PublisherId { get; set; }
    [Required, MaxLength(50)]
    public string Name { get; set; }
    [Required, MaxLength(50)]
    public string Address { get; set; }
    [Required, MaxLength(50)]
    public string City { get; set; }
    [Required, MaxLength(50)]
    public string State { get; set; }
    public List<Book> Books { get; set; }
}