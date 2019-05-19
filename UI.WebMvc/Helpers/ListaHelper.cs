using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.WebMvc.Helpers
{
    public static class ListaHelper
    {
       public static HtmlString ListaElementos(IList<SelectListItem> items,string id,string NombreLabel)
        {
            string string1 = string.Format("<div class='form-group row'>" +
              "<label class='col-lg-3 col-form-label form-control-label' for='{0}'> {1} </label>" +
              "<div class='col-lg-6'>" +
              "<select class='form-control' id='{0}' name='{0}' size='0'>",id,NombreLabel);
            foreach (var i in items)
            {
                string1 += string.Format("<option value='{0}'>{1}</option>",i.Value,i.Text);
            }
            string1 += "</select>" + "</div>" + "</div>";
            return new HtmlString(string1);
        }
    }
}