namespace MW.KUNTUR.Bio.Domain.Entities;

public class Job
{
    //
    // private
    //
    private readonly List<string> _tags = [];
    //
    // public
    //
    public int JobId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public Company? Company { get; set; }
    public IReadOnlyCollection<string> Tags => _tags.AsReadOnly();
}
