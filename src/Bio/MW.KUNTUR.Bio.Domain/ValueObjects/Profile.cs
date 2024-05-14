using MW.KUNTUR.Bio.Domain.Entities;

namespace MW.KUNTUR.Bio.Domain.ValueObjects;

public class Profile
{
    public string? Presentation { get; set; }
    public string? Title { get; set; }
    public string? Bio { get; set; }
    public string? BioImageUrl { get; set; }
    public IEnumerable<SocialNetwork>? SocialNetworks { get; set; }
}
