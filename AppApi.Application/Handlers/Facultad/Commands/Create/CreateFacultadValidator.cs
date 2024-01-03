using FluentValidation;

namespace ApiPrayaga.Application.Handlers.Facultad.Commands.Create
{
    public class CreateFacultadValidator : AbstractValidator<CreateFacultadCommand>
    {
        public CreateFacultadValidator()
        {
            RuleFor(c => c.NombreFacultad)
                .NotEmpty().WithMessage("{PropertyName} no puede estar nulo.")
                .NotNull();
            
            RuleFor(c => c.CodigoFacultad)
                .NotEmpty().WithMessage("{PropertyName} no puede estar nulo.")
                .NotNull()
                .MinimumLength(2).WithMessage("{PropertyName} no puede ser menor a 8 caracteres.");
        }
    }
}
