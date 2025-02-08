using System.Diagnostics.Metrics;
using Application.Abstractions.Messaging;
using Domain.Entities;
using Domain.Errors;
using Domain.Repositories;
using Domain.Shared;
using Domain.ValueObjects;


namespace Application.Asignaturas.Commands.CreateAlumno;

internal sealed class CreateAlumnoCommandHandler : ICommandHandler<CreateAlumnoCommand, Guid>
{
    private readonly IAlumnoRepository _alumnoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateAlumnoCommandHandler(
        IAlumnoRepository memberRepository,
        IUnitOfWork unitOfWork)
    {
        _alumnoRepository = memberRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<Result<Guid>> Handle(CreateAlumnoCommand request, CancellationToken cancellationToken)
    {
        Result<Email> emailResult = Email.Create(request.Email);
        Result<FirstName> firstNameResult = FirstName.Create(request.FirstName);
        Result<LastName> lastNameResult = LastName.Create(request.LastName);

        if (!await _alumnoRepository.IsEmailUniqueAsync(emailResult.Value, cancellationToken))
        {
            return Result.Failure<Guid>(DomainErrors.Alumno.EmailAlreadyInUse);
        }

        var member = Alumno.Create(
            Guid.NewGuid(),
            emailResult.Value,
            firstNameResult.Value,
            lastNameResult.Value);
    }
}
