using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.WebMvc.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Personal()
        {
            return View();
        }

        public ActionResult Administracion()
        {
            return View();
        }
    }
}