using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic
    {
        public AlumnoInscripcionAdapter AlumnoInscripcionData { get; set; }

        public AlumnoInscripcionLogic()
        {
            this.AlumnoInscripcionData = new AlumnoInscripcionAdapter();
        }

        public List<AlumnoInscripcion> GetAllInscripciones()
        {
            return this.AlumnoInscripcionData.GetAllInscripciones();
        }

        public void InscribirAlumno(int IDPersona, int IDCurso)
        {
            this.AlumnoInscripcionData.InsertAlumnoInscripcion(IDPersona, IDCurso);
        }

        public List<AlumnoInscripcion> GetAlumnoInscripcionsWithDates(int desde, int hasta)
        {
            return this.AlumnoInscripcionData.GetAlumnoInscripcionsWithDates(desde, hasta);
        }
    }
}
