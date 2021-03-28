using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Plan:BusinessEntity
    {
        public string Descripcion { get; set; }

        public int IDEspecialidad { get; set; }

        //public string Especialidad { get; set; }

        public  Especialidad Especialidad { get; set; }

        public string DescripcionEspecialidad => this.Especialidad.Descripcion;

        public List<Materia> Materias { get; set; }
    }
}
