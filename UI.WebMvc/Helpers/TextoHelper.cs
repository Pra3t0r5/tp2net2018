using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.WebMvc.Helpers
{
    public static class TextoHelper
    {
        public static HtmlString TextoConLabel(string id, string NombreLabel,string tipo,string valor)
        {
         var cadena = string.Format(
             "<div class=\"form-group row\"> " +
             "<label for=\"{0}\" class=\"col-lg-3 col-form-label form-control-label\"> {2} </label> " +
             "<div class=\"col-lg-6\">" +
             "<input type =\"{1}\" name=\"{0}\" class=\"form-control\" id=\"{0}\" value='{3}' /> </div>" +
             "</div>", id, tipo, NombreLabel,valor );
            return new HtmlString(cadena);
        }
    }
}