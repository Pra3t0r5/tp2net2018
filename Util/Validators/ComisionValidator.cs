using Business.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Validators
{
    public class ComisionValidator : AbstractValidator<Comision>
    {

        public ComisionValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty().WithMessage("El campo descripciòn no puede estar vacio");
            RuleFor(x => x.AnioEspecialidad).NotEqual(0).WithMessage("El año especialidad no puede ser cero");
            RuleFor(x => x.IDPlan).NotEqual(0).WithMessage("Debe seleccionarse un plan para registrar la comisiòn");
        }
    }
}
