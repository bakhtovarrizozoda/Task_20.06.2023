namespace Domain.Entities;

public class GetBookAuthorDto : BookAuthorBaseDto
{
    public string AuthorName { get; set; }
    public string BookName { get; set; }
}