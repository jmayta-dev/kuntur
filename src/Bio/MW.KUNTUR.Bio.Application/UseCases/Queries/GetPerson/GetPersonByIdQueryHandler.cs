using MediatR;
using MW.KUNTUR.Bio.Application.DTOs;
using MW.KUNTUR.Bio.Domain.Interfaces;

namespace MW.KUNTUR.Bio.Application.UseCases.Queries.GetPerson;

public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, GetPersonDto>
{

    #region Properties & Variables
    private readonly IUnitOfWorkBio _unitOfWork;
    #endregion

    #region Constructor
    public GetPersonByIdQueryHandler(IUnitOfWorkBio unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    #endregion

    #region Events
    #endregion

    #region Methods
    public Task<GetPersonDto> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    {
        var person = _unitOfWork.BioRepository.GetPersonByIdAsync(1, cancellationToken);
        throw new NotImplementedException();
    }
    #endregion
}