using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.WebMvc.Models
{
    public class MateriaModel
    {
        public MateriaModel(Business.Entities.Materia mat)
        {
            this.ID = mat.ID;
            this.Descripcion = mat.Descripcion;
            this.IDPlan = mat.IDPlan;
            this.HSSemanales = mat.HSSemanales;
            this.HSTotales = mat.HSTotales;
            this.DescripcionPlan = mat.DescripcionPlan;
        }

        public MateriaModel() {}

        public int ID { get; set; }

        public string Descripcion { get; set; }

        public string DescripcionPlan { get; set; }

        public int IDPlan { get; set; }

        public int HSSemanales { get; set; }

        public int HSTotales { get; set; }

        public IList<SelectListItem> Planes { get; set; }
    }
}