using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.WebMvc.Controllers
{
    public class ProfesoresController : Controller
    {
        ProfesorLogic pl { get; set; }
        PlanLogic PlanLogic { get; set; }
        public ProfesoresController()
        {
            this.pl = new ProfesorLogic();
            this.PlanLogic = new PlanLogic();
        }
        // GET: Profesores
        public ActionResult Index()
        {
            return View(GetModels());
        }

        // GET: Profesores/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Profesores/Create
        public ActionResult Nuevo()
        {           
            return View(this.GetModel());
        }

        // POST: Profesores/Create
        [HttpPost]
        public ActionResult Nuevo(FormCollection collection)
        {
            try
            {
                this.pl.Save(this.ProfesorToBusiness(collection, Business.Entities.BusinessEntity.States.New));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profesores/Edit/5
        public ActionResult Editar(int id)
        {
            var model = this.GetModel(id);
            model.Planes = PlanesEdit(model.IDPlan);
            return View(model);
        }

        // POST: Profesores/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                this.pl.Save(this.ProfesorToBusiness(collection,Business.Entities.BusinessEntity.States.Modified));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profesores/Delete/5
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
                this.pl.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                
                return View();
            }
        }

        public IList<SelectListItem> Planes()
        {
            var planes = this.PlanLogic.GetAllForCombo();
            var items = planes.Select(x => new SelectListItem { Text = x.Descripcion, Value = x.ID.ToString() }).ToList();
            return items;
        }

        public IList<SelectListItem> PlanesEdit(int idPlanes)
        {
            var planes = this.PlanLogic.GetAllForCombo();
            var items = planes.Select(x => new SelectListItem { Text = x.Descripcion, Value = x.ID.ToString() }).ToList();
            items.Find(x => x.Value == idPlanes.ToString()).Selected = true;
            return items;
        }

        public Models.PersonaModel GetModel(int id)
        {
            var prof = this.pl.GetOne(id);
            var model = new Models.PersonaModel(prof);
            return model;
        }

        public Models.PersonaModel GetModel()
        {
            var model = new Models.PersonaModel();
            model.Planes = Planes();
            return model;
        }

        public List<Models.PersonaModel> GetModels()
        {
            var models = new List<Models.PersonaModel>();
            foreach (var prof in this.pl.GetAll())
                models.Add(new Models.PersonaModel(prof));
            return models;
        }

        public Business.Entities.Persona ProfesorToBusiness(FormCollection collection, Business.Entities.BusinessEntity.States estado)
        {
            Business.Entities.Persona persona = new Business.Entities.Persona();
            persona.Nombre = collection["Nombre"].ToString();
            persona.Apellido = collection["Apellido"].ToString();
            persona.Direccion = collection["Direccion"].ToString();
            persona.Email = collection["Email"].ToString();
            persona.FechaNacimiento = DateTime.Parse(collection["FechaNacimiento"].ToString());
            persona.Telefono = collection["Telefono"].ToString();
            persona.TipoPersona = Convert.ToInt32(collection["TipoPersona"].ToString());
            persona.Legajo = Convert.ToInt32(collection["Legajo"].ToString());
            persona.IDPlan = Convert.ToInt32(collection["IDPlan"].ToString());
            persona.State = estado;
            if (estado == Business.Entities.BusinessEntity.States.Modified)
                persona.ID = Convert.ToInt32(collection["ID"]);
            return persona;
        }


    }
}
