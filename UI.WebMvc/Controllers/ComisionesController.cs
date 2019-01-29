using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.WebMvc.Models;

namespace UI.WebMvc.Controllers
{
    public class ComisionesController : Controller
    {
        private ComisionLogic comisionLogic { get; set; }
        private PlanLogic planLogic { get; set; }
        // GET: Comisiones

        public ComisionesController()
        {
            this.comisionLogic = new ComisionLogic();
            this.planLogic = new PlanLogic();
        }

        public ActionResult Index()
        {
            var modelList = new List<ComisionesModel>();
            foreach(var obj in this.comisionLogic.GetAll())
            {
                modelList.Add(new ComisionesModel(obj));
            }
            return View(modelList);
        }

        // GET: Comisiones/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Comisiones/Create
        public ActionResult Nuevo()
        {   
            var model = new ComisionesModel();
            model.Planes = this.Planes();
            return View(model);
        }

        // POST: Comisiones/Create
        [HttpPost]
        public ActionResult Nuevo(FormCollection collection)
        {
            try
            {
                var obj = this.ComisionToBusiness(collection, Business.Entities.BusinessEntity.States.New);
                comisionLogic.Save(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comisiones/Edit/5
        public ActionResult Editar(int id)
        {
            var com = this.comisionLogic.GetOne(id);
            var model = new ComisionesModel(com);
            model.Planes = this.PlanesEdit(com.IDPlan);
            return View(model);
        }

        // POST: Comisiones/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                var comisionbusiness = this.ComisionToBusiness(collection, Business.Entities.BusinessEntity.States.Modified);
                comisionLogic.Save(comisionbusiness);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comisiones/Delete/5
        public ActionResult Eliminar(int id)
        {
            return View(this.GetModel(id));
        }

        // POST: Comisiones/Delete/5
        [HttpPost]
        public ActionResult Eliminar(int id, FormCollection collection)
        {
            try
            {
                this.comisionLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch(Exception)
            {
                var model = this.GetModel(id);
                model.Error = "Error al borrar comision, posee recursos relacionados. Primero borre los cursos a los que este relacionados y vuelva a intentar";
                return View(model);
            }
        }

        public IList<SelectListItem> Planes()
        {
            var planes = this.planLogic.GetAllForCombo();
            var items = planes.Select(x => new SelectListItem { Text = x.Descripcion, Value = x.ID.ToString() }).ToList();
            return items;
        }

        public IList<SelectListItem> PlanesEdit(int idPlanes)
        {
            var planes = this.planLogic.GetAllForCombo();
            var items = planes.Select(x => new SelectListItem { Text = x.Descripcion, Value = x.ID.ToString() }).ToList();
            items.Find(x => x.Value == idPlanes.ToString()).Selected = true;
            return items;
        }

        public Business.Entities.Comision ComisionToBusiness(FormCollection collection, Business.Entities.BusinessEntity.States estado)
        {
            Business.Entities.Comision comision = new Business.Entities.Comision();
            comision.Descripcion = collection["Descripcion"].ToString();
            comision.AnioEspecialidad = Convert.ToInt32(collection["AnioEspecialidad"]);
            comision.IDPlan = Convert.ToInt32(collection["IDPlan"]);
            comision.State = estado;
            if (estado == Business.Entities.BusinessEntity.States.Modified)
                comision.ID = Convert.ToInt32(collection["ID"]);
            return comision;
        }

        public Models.ComisionesModel GetModel(int id)
        {
            var com = this.comisionLogic.GetOne(id);
            return new ComisionesModel(com);
        }

    }
}
