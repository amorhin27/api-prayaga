using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Carrera.Commands.Update
{
    public class UpdateCarreraValidator : AbstractValidator<UpdateCarreraCommand>
    {
        public UpdateCarreraValidator() {
            RuleFor(x => x.CarreraId).NotNull().WithMessage("{PropertyName} no puede ser null");
        }
    }
}
