namespace Domain.Entities;

public class GetBookEditorDto : BookEditorBaseDto
{
    public string EditorName { get; set; }
    public string BookName { get; set; }
}