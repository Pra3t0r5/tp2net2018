using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.WebMvc.Controllers
{
    public class CursosController : Controller
    {

        public CursoLogic cursoLogic { get; set; }

        public MateriaLogic materiaLogic { get; set; }

        public ComisionLogic comisionLogic { get; set; }

        public CursosController()
        {
            this.cursoLogic = new CursoLogic();
            this.materiaLogic = new MateriaLogic();
            this.comisionLogic = new ComisionLogic();
        }

        // GET: Cursos
        public ActionResult Index()
        {
            return View(this.GetCursoModels());
        }

        // GET: Cursos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cursos/Create
        public ActionResult Nuevo()
        {
            return View(this.GetModel());
        }

        // POST: Cursos/Create
        [HttpPost]
        public ActionResult Nuevo(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                this.cursoLogic.Save(this.CursoToBusiness(collection, Business.Entities.BusinessEntity.States.New));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cursos/Edit/5
        public ActionResult Editar(int id)
        {
            return View(this.GetModel(id));
        }

        // POST: Cursos/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                this.cursoLogic.Save(this.CursoToBusiness(collection,Business.Entities.BusinessEntity.States.Modified));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cursos/Delete/5
        public ActionResult Eliminar(int id)
        {
            return View(this.GetModel(id));
        }

        // POST: Cursos/Delete/5
        [HttpPost]
        public ActionResult Eliminar(int id, FormCollection collection)
        {
            try
            {
                this.cursoLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public Models.CursoModel GetModelEmpty()
        {
            return new Models.CursoModel();
        }

        public List<Models.CursoModel> GetCursoModels()
        {
            var modelos = new List<Models.CursoModel>();
            foreach (var obj in this.cursoLogic.GetAll())
                modelos.Add(new Models.CursoModel(obj));
            return modelos;
        }

        public IList<SelectListItem> Materias()
        {
            var materias = this.materiaLogic.GetAllForCombo();
            var items = materias.Select(x => new SelectListItem { Text = x.Descripcion, Value = x.ID.ToString() }).ToList();
            return items;
        }

        public IList<SelectListItem> MateriasEdit(int idMateria)
        {
            var materias = this.materiaLogic.GetAllForCombo();
            var items = materias.Select(x => new SelectListItem { Text = x.Descripcion, Value = x.ID.ToString() }).ToList();
            items.Find(x => x.Value == idMateria.ToString()).Selected = true;
            return items;
        }

        public IList<SelectListItem> Comisiones()
        {
            var comisiones = this.comisionLogic.GetAllCombo();
            var items = comisiones.Select(x => new SelectListItem { Text = x.Descripcion, Value = x.ID.ToString() }).ToList();
            return items;
        }

        public IList<SelectListItem> ComisionesEdit(int idComision)
        {
            var comisiones = this.comisionLogic.GetAllCombo();
            var items = comisiones.Select(x => new SelectListItem { Text = x.Descripcion, Value = x.ID.ToString() }).ToList();
            items.Find(x => x.Value == idComision.ToString()).Selected = true;
            return items;
        }

        public Models.CursoModel GetModel()
        {
            var model = new Models.CursoModel();
            model.Comisiones = this.Comisiones();
            model.Materias = this.Materias();
            return model;
        }

        public Models.CursoModel GetModel(int id)
        {
            var obj = this.cursoLogic.GetOne(id);
            var model = new Models.CursoModel(obj);
            model.Materias = Materias();
            model.Comisiones = Comisiones();
            return model;
        }

        public Business.Entities.Curso CursoToBusiness(FormCollection collection, Business.Entities.BusinessEntity.States estado)
        {
            Business.Entities.Curso curso = new Business.Entities.Curso();
            curso.IDComision = Convert.ToInt32(collection["IDComision"]);
            curso.IDMateria = Convert.ToInt32(collection["IDMateria"]);
            curso.Cupo = Convert.ToInt32(collection["Cupo"]);
            curso.AnioCalendario = Convert.ToInt32(collection["AnioCalendario"]);
            if (estado == Business.Entities.BusinessEntity.States.Modified)
                curso.ID = Convert.ToInt32(collection["ID"]);
            return curso;
        }

    }
}
