using Application.Abstractions.Messaging;
using Domain.Repositories;
using Domain.Shared;

namespace Application.Asignaturas.Queries.GetAlumnoById;

internal sealed class GetAlumnoByIdQueryHandler : IQueryHandler<GetAlumnoByIdQuery, AlumnoResponse>
{

    private readonly IAlumnoRepository _alumnoRepository;

    public GetAlumnoByIdQueryHandler(IAlumnoRepository alumnoRepository)
    {
        _alumnoRepository = alumnoRepository;
    }
    public async Task<Result<AlumnoResponse>> Handle(GetAlumnoByIdQuery request, CancellationToken cancellationToken)
    {
        var alumno = await _alumnoRepository.GetByIdAsync(
             request.AlumnoId,
             cancellationToken);

        if (alumno is null)
        {
            return Result.Failure<AlumnoResponse>(new Error(
                "Member.NotFound",
                $"The member with Id {request.AlumnoId} was not found"));
        }

        var response = new AlumnoResponse(alumno.Id, alumno.Email);

        return response;
    }
}
