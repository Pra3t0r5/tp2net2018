using Business.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic.Validators
{
    public class EspecialidadValidator : AbstractValidator<Especialidad>
    {
        public EspecialidadValidator()
        {
            RuleFor(x => x.Descripcion)
                .NotEmpty()
                .WithMessage("El campo Especialidad no puede estar vacio")
                .MaximumLength(50).WithMessage("La cantidad de caracteres supera el maximo (50)");
        }
    }
}
