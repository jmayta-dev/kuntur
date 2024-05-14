namespace MW.KUNTUR.Bio.Domain.Entities;

public class SocialNetwork
{
    public int SocialNetworkId { get; set; }
    public string? Name { get; set; }
    public string? AccountUrl { get; set; }
    public string? IconUrl { get; set; }
    public string? Icon { get; set; }
    public bool Visible { get; set; }
}