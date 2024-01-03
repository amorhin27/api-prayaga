using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Facultad.Commands.Update
{
    public class UpdateFacultadValidator : AbstractValidator<UpdateFacultadCommand>
    {
        public UpdateFacultadValidator() {
            RuleFor(x => x.FacultadId).NotNull().WithMessage("{PropertyName} no puede ser null");
        }
    }
}
