using Domain.ValueObjects;
using FluentValidation;

namespace Application.Asignaturas.Commands.CreateAlumno
{
    internal class CreateAlumnoCommandValidator : AbstractValidator<CreateAlumnoCommand>
    {
        public CreateAlumnoCommandValidator()
        {
            RuleFor(x => x.Email).NotEmpty();

            RuleFor(x => x.FirstName).NotEmpty().MaximumLength(FirstName.MaxLength);

            RuleFor(x => x.LastName).NotEmpty().MaximumLength(LastName.MaxLength);
        }
    }
}
