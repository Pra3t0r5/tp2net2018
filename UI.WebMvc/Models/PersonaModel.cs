using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.WebMvc.Models
{
    public class PersonaModel
    {

        public PersonaModel(Business.Entities.Persona profesor)
        {
            this.ID = profesor.ID;
            this.Nombre = profesor.Nombre;
            this.Apellido = profesor.Apellido;
            this.Direccion = profesor.Direccion;
            this.Email = profesor.Email;
            this.FechaNacimiento = profesor.FechaNacimiento;
            this.Legajo = profesor.Legajo;
            this.TipoPersona = profesor.TipoPersona;
            this.Telefono = profesor.Telefono;
            this.IDPlan = profesor.IDPlan;
            this.DescripcionPlan = profesor.DescripcionPlan;
        }

        public PersonaModel()
        {
            this.FechaNacimiento = DateTime.Today;
        }

        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public int Legajo { get; set; }

        public int TipoPersona { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public int IDPlan { get; set; }

        public string DescripcionPlan { get; set; }

        public string Error { get; set; }

        public IList<SelectListItem> Planes { get; set; }
    }
}