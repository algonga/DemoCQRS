
using Application.Abstractions.Messaging;

namespace Application.Asignaturas.Queries.GetAlumnoById
{
    public sealed record GetAlumnoByIdQuery(Guid AlumnoId) : IQuery<AlumnoResponse>;
   
}
