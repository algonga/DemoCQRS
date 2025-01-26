
namespace Presentation.Contracts;

public sealed record RegisterAlumnoRequest(
    string Email,
    string FirstName,
    string LastName);
