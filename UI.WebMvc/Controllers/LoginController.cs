﻿using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
        public void Index(FormCollection collection)
        {
            LoginLogic lg = new LoginLogic();
            var nombre = collection["NombreUsuario"].ToString();
            var clave = collection["Clave"].ToString();
            var usr = lg.ValidateUser(nombre, clave);
            if(usr.NombreUsuario != string.Empty)
            {
                Session["Usuario"] = usr.NombreUsuario;
                Redirect("/Home");
            }
            else
            {
                Redirect("/Login");
            }
        }
    }
}