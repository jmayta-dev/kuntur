namespace MW.KUNTUR.Blog.Application.DTOs;

public record CreatePostDTO
{
    public int PostId { get; init; }
    public int AuthorId { get; init; }
    public string? Slug { get; init; }
    public string? Title { get; init; }
    public string? ImagePath { get; init; }
    public string? Content { get; init; }
    public bool IsPublished { get; init; }
    public DateTime? CreatedAt { get; init; }
    public DateTime? UpdatedAt { get; init; }
    public DateTime? PublishedAt { get; init; }
    public IEnumerable<int>? Tags { get; init; }
    public IEnumerable<int>? Categories { get; init; }
    public IEnumerable<int>? Comments { get; init; }
}