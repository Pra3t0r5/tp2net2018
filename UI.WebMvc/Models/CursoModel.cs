using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.WebMvc.Models
{
    public class CursoModel
    {
        public CursoModel(Business.Entities.Curso Curso)
        {
            this.ID = Curso.ID;
            this.Descripcion = Curso.Descripcion;
            this.AnioCalendario = Curso.AnioCalendario;
            this.IDMateria = Curso.IDMateria;
            this.IDComision = Curso.IDComision;
            this.DescripcionMateria = Curso.DescripcionMateria;
            this.DescripcionComision = Curso.DescripcionComision;
            this.Cupo = Curso.Cupo;
        }

        public CursoModel() {}

        public int ID { get; set; }

        public string Descripcion { get; set; }

        public int AnioCalendario { get; set; }

        public int Cupo { get; set; }

        public int IDMateria { get; set; }

        public int IDComision { get; set; }

        public string DescripcionMateria { get; set; }

        public string DescripcionComision { get; set; }

        public IList<SelectListItem> Comisiones { get; set; }

        public IList<SelectListItem> Materias { get; set; }
    }
}