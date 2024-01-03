using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Carrera.Commands.Delete
{
    public class CreateCarreraValidator : AbstractValidator<DeleteCarreraCommand>
    {
        public CreateCarreraValidator(){
            RuleFor(x=>x.CarreraId).NotNull().WithMessage("{PropertyName} no puede ser nulo");
        }
    }
}
