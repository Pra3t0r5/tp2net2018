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

        public ActionResult Nuevo()
        {
            var usr = new Usuario();
            return View(new Models.UsuarioModel(usr));
        }

        // POST: Profesores/Create
        [HttpPost]
        public ActionResult Nuevo(FormCollection collection)
        {
            try
            {
                this.usuarioLogic.Save(this.UsuarioToBusiness(collection, Business.Entities.BusinessEntity.States.New));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Eliminar(int id)
        {
            return View(this.GetModel(id));
        }

        // POST: Profesores/Delete/5
        [HttpPost]
        public ActionResult Eliminar(int id, FormCollection collection)
        {
            try
            {
                this.usuarioLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }

        public ActionResult Editar(int id)
        {
            var model = this.GetModel(id);
            return View(model);
        }

        // POST: Profesores/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                this.usuarioLogic.Save(this.UsuarioToBusiness(collection, Business.Entities.BusinessEntity.States.Modified));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public Models.UsuarioModel GetModel(Usuario usr)
        {
            var model = new Models.UsuarioModel(usr);
            return model;
        }

        public Models.UsuarioModel GetModel(int id)
        {
            var prof = this.usuarioLogic.GetOne(id);
            var model = new Models.UsuarioModel(prof);
            return model;
        }

        public Business.Entities.Usuario UsuarioToBusiness(FormCollection collection, Business.Entities.BusinessEntity.States estado)
        {
            Business.Entities.Usuario usuario = new Business.Entities.Usuario();
            usuario.Nombre = collection["Nombre"].ToString();
            usuario.Apellido = collection["Apellido"].ToString();
            usuario.NombreUsuario = collection["NombreUsuario"].ToString();
            usuario.EMail = collection["EMail"].ToString();
            usuario.Habilitado = Convert.ToBoolean(collection["Habilitado"]);
            usuario.TipoPersona = Convert.ToInt32(collection["TipoPersona"].ToString());
            usuario.IDPersona = Convert.ToInt32(collection["IDPersona"].ToString());
            usuario.State = estado;
            if (estado == Business.Entities.BusinessEntity.States.Modified)
                usuario.ID = Convert.ToInt32(collection["ID"]);
            return usuario;
        }
    }
}