using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Entities
{
    public class AlumnoInscripcion:BusinessEntity
    {
        private string _Condicion;
        private int _IDAlumno;
        private int _IDCurso;
        private int? _Nota;

        public string Condicion
        {
            get => _Condicion;
            set => _Condicion = value;
        }

        public int IDAlumno
        {
            get => _IDAlumno;
            set => _IDAlumno = value;
        }

        public int IDCurso
        {
            get => _IDCurso;
            set => _IDCurso = value;
        }

        public int? Nota
        {
            get => _Nota;
            set => _Nota = value;
        }


        #region PropiedadesDeTablasExteriores
        public string NombreAlumno { get; set; }
        public string ApellidoAlumno { get; set; }
        public int LegajoAlumno { get; set; }
        public string DescripcionComision { get; set; }
        public string DescripcionMateria { get; set; }
        #endregion
    }
}
