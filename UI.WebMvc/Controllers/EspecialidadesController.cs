using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.WebMvc.Controllers
{
    public class EspecialidadesController : Controller
    {
        private EspecialidadLogic especialidadLogic { get; set; }
        public EspecialidadesController()
        {
            this.especialidadLogic = new EspecialidadLogic();
        }
        // GET: Especialidades
        public ActionResult Index()
        {
            var model = new List<WebMvc.Models.Especialidad>();
            foreach (var i in especialidadLogic.GetAll())
                model.Add(new Models.Especialidad(i));

            return View(model);
        }

        // GET: Especialidades/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Especialidades/Nuevo
        public ActionResult Nuevo()
        {
            return View();
        }

        // POST: Especialidades/Create
        [HttpPost]
        public ActionResult Nuevo(FormCollection collection)
        {
            try
            {
                var especialidad = this.MapEspecialidadToBussiness(collection,Business.Entities.BusinessEntity.States.New);
                this.especialidadLogic.Save(especialidad);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Especialidades/Edit/5
        public ActionResult Editar(int id)
        {
            var esp = this.especialidadLogic.GetOne(id);
            var model = new WebMvc.Models.Especialidad(esp);
            return View(model);
        }

        // POST: Especialidades/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                var especialidad = this.MapEspecialidadToBussiness(collection, Business.Entities.BusinessEntity.States.Modified);
                this.especialidadLogic.Save(especialidad);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Especialidades/Delete/5
        public ActionResult Borrar(int id)
        {
            var esp = this.especialidadLogic.GetOne(id);
            var model = new WebMvc.Models.Especialidad(esp);
            return View(model);
        }

        // POST: Especialidades/Delete/5
        [HttpPost]
        public ActionResult Borrar(int id, FormCollection collection)
        {
                this.especialidadLogic.Delete(id);
                return RedirectToAction("Index");
        }

        private Business.Entities.Especialidad MapEspecialidadToBussiness(FormCollection collection, Business.Entities.BusinessEntity.States estado)
        {
            Business.Entities.Especialidad espb = new Business.Entities.Especialidad();
            if (estado == Business.Entities.BusinessEntity.States.Modified)
                espb.ID = Convert.ToInt32(collection["ID"]);
            espb.Descripcion = collection["Descripcion"].ToString();
            espb.State = estado;
            return espb;
        }
    }
}
