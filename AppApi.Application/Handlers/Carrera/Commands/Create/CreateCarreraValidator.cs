using FluentValidation;

namespace ApiPrayaga.Application.Handlers.Carrera.Commands.Create
{
    public class CreateCarreraValidator : AbstractValidator<CreateCarreraCommand>
    {
        public CreateCarreraValidator()
        {
            RuleFor(c => c.NombreCarrera)
                .NotEmpty().WithMessage("{PropertyName} no puede estar nulo.")
                .NotNull();
            
            RuleFor(c => c.CodigoCarrera)
                .NotEmpty().WithMessage("{PropertyName} no puede estar nulo.")
                .NotNull()
                .MinimumLength(2).WithMessage("{PropertyName} no puede ser menor a 8 caracteres.");
        }
    }
}
