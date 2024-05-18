using MW.KUNTUR.Bio.Application.DTOs;
using MW.KUNTUR.Bio.Domain.Entities;

namespace MW.KUNTUR.Bio.Application.Mapper;

public static class PersonDTOMapper
{
    public static Person ToPerson(this GetPersonDto personDto)
    {
        var person = new Person
        {
            FirstName = personDto?.FirstName ?? default,
            LastName = personDto?.LastName ?? default,

        };

        return person;
    }
}