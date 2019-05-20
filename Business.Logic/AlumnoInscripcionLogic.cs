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

        public void InscribirAlumno(int IDPersona, int IDcomision, int IDmateria)
        {
            CursoAdapter ca = new CursoAdapter();
            int IDCurso = ca.GetOneByIDs(IDcomision, IDmateria);
            this.AlumnoInscripcionData.InsertAlumnoInscripcion(IDPersona, IDCurso);
        }

        public List<AlumnoInscripcion> GetAlumnoInscripcionsWithDates(int desde, int hasta)
        {
            return this.AlumnoInscripcionData.GetAlumnoInscripcionsWithDates(desde, hasta);
        }

        public void InscribirAlumno(int IDPersona,int IDCurso)
        {
            this.AlumnoInscripcionData.InsertAlumnoInscripcion(IDPersona, IDCurso);
        }

        public int GetInscripcionesByMateria(int curso)
        {
            return this.AlumnoInscripcionData.GetInscripcionesByMateria(curso);
        }
    }
}
