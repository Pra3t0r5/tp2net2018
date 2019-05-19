using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.WebMvc.Models
{
    public class Especialidad
    {
        public Especialidad()
        {

        }

        public Especialidad(Business.Entities.Especialidad esp)
        {
            this.ID = esp.ID;
            this.Descripcion = esp.Descripcion;
        }

        public int ID { get; set; }

        [Required]
        public string Descripcion { get; set; }
    }
}