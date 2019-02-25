using Business.Logic;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Util;

namespace UI.WebMvc.Controllers
{
    public class PlanesController : Controller
    {
        private PlanLogic planLogic { get; set; }
        private EspecialidadLogic EspecialidadLogic { get; set; }

        public PlanesController()
        {
            this.planLogic = new PlanLogic();
            this.EspecialidadLogic = new EspecialidadLogic();
        }

        // GET: Planes
        public ActionResult Index()
        {
            var lista = this.planLogic.GetAll();
            var model = new List<Models.Plan>();
            foreach (var i in lista)
                model.Add(new Models.Plan(i));
            return View(model);
        }

        // GET: Planes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Planes/Create
        public ActionResult Nuevo()
        {
            var model = new Models.Plan();
            model.Especialidades = this.Especialidades();

            return View(model);
        }

        // POST: Planes/Create
        [HttpPost]
        public ActionResult Nuevo(FormCollection collection)
        {
            try
            {
                var plan = this.PlanToBusiness(collection, Business.Entities.BusinessEntity.States.New);
                this.planLogic.Save(plan);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Planes/Edit/5
        public ActionResult Editar(int id)
        {
            var plan = this.planLogic.GetOne(id);
            var model = new Models.Plan(plan);
            model.Especialidades = this.EspecialidadesEdit(model.IDEspecialidad);
            return View(model);
        }

        // POST: Planes/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                var esp = this.PlanToBusiness(collection, Business.Entities.BusinessEntity.States.Modified);
                this.planLogic.Save(esp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Planes/Delete/5
        public ActionResult Eliminar(int id)
        {
            var plan = this.planLogic.GetOne(id);
            var model = new Models.Plan(plan);
            return View(model);
        }

        // POST: Planes/Delete/5
        [HttpPost]
        public ActionResult Eliminar(int id, FormCollection collection)
        {
            try
            {
                this.planLogic.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

     
        public ActionResult ReportPlanes()
        {
            PlanLogic pl = new PlanLogic();
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.SizeToReportContent = true;
            reportViewer.Width = Unit.Percentage(200);
            reportViewer.Height = Unit.Percentage(700);
            ReportDataSource reportDataSource = new ReportDataSource("Planes", pl.GetAll());
            reportViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"ReportePlanes.rdlc";
            reportViewer.LocalReport.DataSources.Add(reportDataSource);


            ViewBag.ReportViewer = reportViewer;

            return View();
        }
        




        public IList<SelectListItem> Especialidades()
        {
            var especialidades = this.EspecialidadLogic.GetAllForCombo();
            var items = especialidades.Select(x => new SelectListItem { Text = x.Descripcion, Value = x.ID.ToString() }).ToList();
            return items;
        }

        public IList<SelectListItem>EspecialidadesEdit(int idEspecialidad)
        {
            var especialidades = this.EspecialidadLogic.GetAllForCombo();
            var items = especialidades.Select(x => new SelectListItem { Text = x.Descripcion, Value = x.ID.ToString() }).ToList();
            items.Find(x => x.Value == idEspecialidad.ToString()).Selected = true;
            return items;
        }

        public Business.Entities.Plan PlanToBusiness(FormCollection collection, Business.Entities.BusinessEntity.States estado)
        {
            Business.Entities.Plan plan = new Business.Entities.Plan();
            plan.Descripcion = collection["Descripcion"].ToString();
            plan.IDEspecialdad = Convert.ToInt32(collection["IDEspecialidad"]);
            plan.State = estado;
            if (estado == Business.Entities.BusinessEntity.States.Modified)
                plan.ID = Convert.ToInt32(collection["ID"]);
            return plan;
        }
        
    }
}
