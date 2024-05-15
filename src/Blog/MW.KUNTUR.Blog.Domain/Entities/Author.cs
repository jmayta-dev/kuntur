namespace MW.KUNTUR.Blog.Domain.Entities;

public class Author
{
    public int AuthorId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? AvatarUrl { get; set; }
}