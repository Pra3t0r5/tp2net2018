using Business.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Validators
{
    public class PlanValidator : AbstractValidator<Plan>
    {
        public PlanValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty().WithMessage("El campo descripciòn no puede estar vacio");
            RuleFor(x => x.IDEspecialidad).NotNull().WithMessage("Debe asignarse una especialidad al plan");
        }
    }
}
