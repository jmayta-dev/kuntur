
using MediatR;
using MW.KUNTUR.Bio.Domain.Entities;
using MW.KUNTUR.Bio.Domain.Interfaces;

namespace MW.KUNTUR.Bio.Application.UseCases.Commands.CreatePerson;

public class CreatePersonCommandHandler(IUnitOfWorkBio unitOfWorkBio) : IRequestHandler<CreatePersonCommand, int>
{
    private readonly IUnitOfWorkBio _unitOfWorkBio = unitOfWorkBio;

    public async Task<int> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
    {
        var newPerson = new Person
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            EmailAddress = request.EmailAddress
        };
        var newPersonId = await _unitOfWorkBio.BioRepository.CreatePerson(newPerson, cancellationToken);
        await _unitOfWorkBio.SaveChangesAsync(cancellationToken);
        return newPersonId;
    }
}