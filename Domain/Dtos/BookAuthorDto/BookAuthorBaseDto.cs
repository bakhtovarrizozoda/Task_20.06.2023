namespace Domain.Entities;

public class BookAuthorBaseDto
{
    public int AuthorId { get; set; }
    public int Isbn { get; set; }
    public int AuthorOrder { get; set; }
    public decimal Royaltyshare { get; set; }
}