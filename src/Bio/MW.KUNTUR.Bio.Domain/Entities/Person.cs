using MW.KUNTUR.Bio.Domain.ValueObjects;

namespace MW.KUNTUR.Bio.Domain.Entities;

public class Person
{
    //
    // private
    //
    private readonly List<Job> _jobs = []; // new() / new List<Job>()
    private readonly List<SocialNetwork> _socialNetworks = []; // new() / new List<Job>()
    //
    // public
    //
    public string? PersonId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? AvatarUrl { get; set; }
    public IReadOnlyCollection<Job>? Jobs => _jobs.AsReadOnly();
    public IReadOnlyCollection<SocialNetwork>? SocialNetworks => _socialNetworks.AsReadOnly();
    public Profile? Profile { get; set; } // Presentation, Bio, BioImageUrl, SocialNetworks
}
