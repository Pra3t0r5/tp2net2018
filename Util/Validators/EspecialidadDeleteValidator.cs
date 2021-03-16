using Business.Entities;
using Business.Logic;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Validators
{
    public class EspecialidadDeleteValidator: AbstractValidator<Especialidad>
    {
        public EspecialidadDeleteValidator()
        {
            RuleFor(x => x).Must(this.NoTienePlanesVinculados).WithMessage("Error: La especialidad posee uno o mas planes vinculados, proceda a borrar los planes e intente nuevamente");
        }

        private bool NoTienePlanesVinculados(Especialidad esp) => !esp.Planes.Any();

    }
}
