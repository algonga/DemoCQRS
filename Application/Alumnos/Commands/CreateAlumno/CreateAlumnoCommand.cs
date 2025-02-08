using Application.Abstractions.Messaging;

namespace Application.Asignaturas.Commands.CreateAlumno;

public sealed record CreateAlumnoCommand(
    string Email,
    string FirstName,
    string LastName) : ICommand<Guid>;
