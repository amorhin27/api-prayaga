using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Handlers.Facultad.Commands.Delete
{
    public class CreateFacultadValidator : AbstractValidator<DeleteFacultadCommand>
    {
        public CreateFacultadValidator(){
            RuleFor(x=>x.FacultadId).NotNull().WithMessage("{PropertyName} no puede ser nulo");
        }
    }
}
