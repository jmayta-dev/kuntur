using System.Text.Json;

namespace MW.KUNTUR.Bio.Application.DTOs;

public record GetPersonDto
{
    public string? PersonId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? Phone { get; set; }
    public string? AvatarUrl { get; set; }
    public Profile? Profile { get; set; }

    public GetPersonDto ToJson(string jsonString)
    {
        var a = JsonSerializer.Deserialize<GetPersonDto>(jsonString);

        PersonId = a?.PersonId ?? string.Empty;
        FirstName = a?.FirstName ?? string.Empty;
        LastName = a?.LastName ?? string.Empty;
        EmailAddress = a?.EmailAddress ?? string.Empty;
        Phone = a?.Phone ?? string.Empty;
        AvatarUrl = a?.AvatarUrl ?? string.Empty;

        return this;
    }
}

public record Profile
{
    public string? Bio { get; set; }
    public string? ImageUrl { get; set; }
    public string? Presentation { get; set; }
    public string? Title { get; set; }
}
