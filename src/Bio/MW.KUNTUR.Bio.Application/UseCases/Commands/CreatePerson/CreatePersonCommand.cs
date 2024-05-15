using MediatR;
using MW.KUNTUR.Bio.Application.DTOs;

namespace MW.KUNTUR.Bio.Application.UseCases.Commands.CreatePerson;

public record CreatePersonCommand : CreatePersonDTO, IRequest<int>
{

}