namespace MW.KUNTUR.Blog.Domain.Entities;

public class Comment
{
    public int AuthorId { get; set; }
    public int PostId { get; set; }
    public string? Content { get; set; }
    public DateTime? CreatedAt { get; set; }
}