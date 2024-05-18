using MediatR;
using MW.KUNTUR.Bio.Application.DTOs;

namespace MW.KUNTUR.Bio.Application.UseCases.Queries.GetPerson;

public record GetPersonByIdQuery : IRequest<GetPersonDto>
{

}