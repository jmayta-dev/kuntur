namespace MW.KUNTUR.Bio.Domain.Entities;

public class Project
{
    //
    // private
    //
    private readonly List<Technology> _technologies = [];
    //
    // public
    //
    public int ProjectId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public IReadOnlyCollection<Technology> Technologies => _technologies.AsReadOnly();
}
