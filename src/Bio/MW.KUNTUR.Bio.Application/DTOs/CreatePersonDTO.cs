namespace MW.KUNTUR.Bio.Application.DTOs;

public record CreatePersonDTO
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? AvatarUrl { get; set; }
}