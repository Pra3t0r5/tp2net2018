using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.WebMvc.Helpers
{
    public class BtnAceptarCancelarHelper
    {
        public static HtmlString BotonesAceptarCancelar()
        {
            var cadena = string.Format(@"<div class='form-group row'>
           <label class='col-lg-3 col-form-label form-control-label'></label>
           <div class='col-lg-9'>
           <input type = 'submit' class='btn btn-primary' value='Guardar'>
           <input type = 'button' class='btn btn-secondary' value='Cancelar'>
           </div>
           </div>");
            return new HtmlString(cadena);
        }
    }
}