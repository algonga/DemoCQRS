using Application.Asignaturas.Commands.CreateAlumno;
using Application.Asignaturas.Queries.GetAlumnoById;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Abstractions;
using Presentation.Contracts;

namespace Presentation.Controllers;

[Route("api/alumnos")]
public sealed class AlumnoController : ApiController
{
    public AlumnoController(ISender sender) : base(sender)
    {
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetAlumnoById(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetAlumnoByIdQuery(id);

        Result<AlumnoResponse> response = await Sender.Send(query, cancellationToken);

        return response.IsSuccess ? Ok(response.Value) : NotFound(response.Error);
    }

    [HttpPost]
    public async Task<IActionResult> RegisterAlumno(
        [FromBody] RegisterAlumnoRequest request,
        CancellationToken cancellationToken)
    {
        var command = new CreateAlumnoCommand(
            request.Email,
            request.FirstName,
            request.LastName);

        Result<Guid> result = await Sender.Send(command, cancellationToken);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return CreatedAtAction(
            nameof(GetAlumnoById),
            new { id = result.Value },
            result.Value);
    }
}
