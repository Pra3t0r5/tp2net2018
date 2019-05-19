using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.WebMvc.Models
{
    public class Plan
    {

        public Plan(Business.Entities.Plan plan)
        {
            this.ID = plan.ID;
            this.Descripcion = plan.Descripcion;
            this.DescripcionEspecialidad = plan.DescripcionEspecialidad;
            this.IDEspecialidad = plan.IDEspecialdad;
            this.Especialidades = new List<SelectListItem>();
        }
        
        public Plan() { }

        public int ID { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public string DescripcionEspecialidad { get; set; }

        [Required]
        public int IDEspecialidad { get; set; }

        public IList<SelectListItem> Especialidades { get; set; }


    }
}