
namespace MW.KUNTUR.Blog.Domain.Entities;

public class Post
{
    //
    // private
    //
    private readonly List<Comment> _comments = [];
    private readonly List<Category> _categories = [];
    private readonly List<Tag> _tags = [];
    //
    // public
    //
    public int PostId { get; set; }
    public Author? Author { get; set; } // author
    public string? Slug { get; set; }
    public string? Title { get; set; }
    public string? ImagePath { get; set; }
    public string? Content { get; set; }
    public bool IsPublished { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }

    public IReadOnlyCollection<Tag> Tags => _tags.AsReadOnly();
    public IReadOnlyCollection<Category> Categories => _categories.AsReadOnly();
    public IReadOnlyCollection<Comment> Comments => _comments.AsReadOnly();

}