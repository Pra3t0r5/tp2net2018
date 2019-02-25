using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UI.WebMvc.Models;

namespace UI.WebMvc.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            Login login = new Login();
            return View(login);
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            LoginLogic lg = new LoginLogic();
            var nombre = collection["NombreUsuario"].ToString();
            var clave = collection["Clave"].ToString();
            var usr = lg.ValidateUser(nombre, clave);
            if(!string.IsNullOrEmpty(usr.NombreUsuario))
            {
                Session["Usuario"] = usr;
                return RedirectToAction("Index","Home");
            }
            else
            {
                return Redirect("/Login");
            }
        }

        public ActionResult FinalizarSesion()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }

    }
}