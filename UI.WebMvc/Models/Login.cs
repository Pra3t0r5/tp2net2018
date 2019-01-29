using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.WebMvc.Models
{
    public class Login
    {
        [Required]
        public string NombreUsuario { get; set; }

        [Required]
        public string Clave { get; set; }

        public string returnUrl { get; set; }

        public bool Recordar { get; set; }
    }
}