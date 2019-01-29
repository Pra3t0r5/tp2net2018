using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.WebMvc.Models;

namespace UI.WebMvc.Controllers
{
    public class UsuariosController : Controller
    {
        public UsuarioLogic usuarioLogic { get; set; }
        public UsuariosController()
        {
            this.usuarioLogic = new UsuarioLogic();
        }

        // GET: Usuarios
        public ActionResult Index()
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            foreach(var i in usuarioLogic.GetAll())
            {
                UsuarioModel usr = new UsuarioModel(i);
                usuarios.Add(usr);
            }
            return View(usuarios);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                UsuarioLogic usuario = new UsuarioLogic();
                Usuario usr = usuario.GetOne(id);
                usr.State = BusinessEntity.States.Deleted;
                usuarioLogic.Save(usr);
                return RedirectToAction("Index");
            }
            catch { return View(); }
        }
    }
}