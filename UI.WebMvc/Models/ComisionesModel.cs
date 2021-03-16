using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.WebMvc.Models
{
    public class ComisionesModel
    {
        public ComisionesModel(Business.Entities.Comision com)
        {
            this.ID = com.ID;
            this.Descripcion = com.Descripcion;
            this.IDPlan = com.IDPlan;
            this.AnioEspecialidad = com.AnioEspecialidad;
            
        }

        public ComisionesModel() { }

        public int ID { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public int AnioEspecialidad { get; set; }

        [Required]
        public int IDPlan { get; set; }

        public string DescripcionPlan { get; set; }

        public IList<SelectListItem> Planes { get; set; }

        public string Error { get; set; }
    }
}