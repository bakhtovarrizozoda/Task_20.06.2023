using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class BookAuthor
{
    [Required]
    public int AuthorId { get; set; }
    [Required]
    public int Isbn { get; set; }
    [Required]
    public int AuthorOrder { get; set; }
    [Required]
    public decimal Royaltyshare { get; set; }
    public Author Author { get; set; }
    [ForeignKey("Isbn")]
    public Book Book { get; set; }
}