
using MediatR;
using MW.KUNTUR.Bio.Domain.Entities;
using MW.KUNTUR.Bio.Domain.Interfaces;

namespace MW.KUNTUR.Bio.Application.UseCases.Commands.CreatePerson;

public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, int>
{
    private readonly IBioRepository _bioRepository;

    public CreatePersonCommandHandler(IBioRepository bioRepository)
    {
        _bioRepository = bioRepository;
    }
    public async Task<int> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
    {
        var newPerson = new Person
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            EmailAddress = request.EmailAddress
        };
        var newPersonId = await _bioRepository.CreatePerson(newPerson, cancellationToken);
        return newPersonId;
    }
}