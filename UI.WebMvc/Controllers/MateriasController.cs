using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.WebMvc.Controllers
{
    public class MateriasController : Controller
    {
        private MateriaLogic materiaLogic {get; set;}
        private PlanLogic planLogic { get; set; }
        public MateriasController()
        {
            this.materiaLogic = new MateriaLogic();
            this.planLogic = new PlanLogic();
        }
        public ActionResult Index()
        {
            return View(this.GetModelList());
        }

        // GET: Materias/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Materias/Create
        public ActionResult Nuevo()
        {
            return View(this.GetModelEmpty());
        }

        // POST: Materias/Create
        [HttpPost]
        public ActionResult Nuevo(FormCollection collection)
        {
            try
            {
                this.materiaLogic.Save(this.MateriaToBusiness(collection, Business.Entities.BusinessEntity.States.New));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Materias/Edit/5
        public ActionResult Editar(int id)
        {
            return View(this.GetModel(id));
        }

        // POST: Materias/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                this.materiaLogic.Save(this.MateriaToBusiness(collection, Business.Entities.BusinessEntity.States.Modified));
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Materias/Delete/5
        public ActionResult Eliminar(int id)
        {
            return View(this.GetModel(id));
        }

        // POST: Materias/Delete/5
        [HttpPost]
        public ActionResult Eliminar(int id, FormCollection collection)
        {
            try
            {
                this.materiaLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public List<Models.MateriaModel> GetModelList()
        {
            var listaobjs = this.materiaLogic.GetAll();
            var listaModelos = new List<Models.MateriaModel>();
            foreach(var i in listaobjs)
            {
                listaModelos.Add(new Models.MateriaModel(i));
            }
            return listaModelos;
        }

        public Models.MateriaModel GetModelEmpty()
        {
            var model = new Models.MateriaModel();
            model.Planes = this.Planes();
            return model;
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

        public Models.MateriaModel GetModel(int id)
        {
            var mat = this.materiaLogic.GetOne(id);
            var model = new Models.MateriaModel(mat);
            model.Planes = this.PlanesEdit(mat.IDPlan);
            return model;
        }

        public Business.Entities.Materia MateriaToBusiness(FormCollection collection, Business.Entities.BusinessEntity.States estado)
        {
            Business.Entities.Materia materia= new Business.Entities.Materia();
            materia.Descripcion = collection["Descripcion"].ToString();
            materia.HSSemanales = Convert.ToInt32(collection["HSSemanales"].ToString());
            materia.HSTotales = Convert.ToInt32(collection["HSTotales"].ToString());
            materia.IDPlan = Convert.ToInt32(collection["IDPlan"].ToString());
            materia.State = estado;
            if (estado == Business.Entities.BusinessEntity.States.Modified)
                materia.ID = Convert.ToInt32(collection["ID"]);
            return materia;
        }


    }
}
