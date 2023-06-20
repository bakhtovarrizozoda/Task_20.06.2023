using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Book
{


    [Key]
    public int Isbn { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Type { get; set; }
    [Required]
    public int PublisherId { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required, MaxLength(50)]
    public string Advance { get; set; }
    [Required]
    public int Ytdsales { get; set; }
    [Required]
    public DateTime PubDate { get; set; }
    public Publisher Publisher { get; set; }
    public List<BookEditor> BookEditors { get; set; }
    public List<BookAuthor> BookAuthors { get; set; }
    
}
