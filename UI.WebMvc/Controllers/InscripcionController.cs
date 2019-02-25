using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.WebMvc.Models;

namespace UI.WebMvc.Controllers
{
    public class InscripcionController : Controller
    {
        private MateriaLogic materiaLogic { get; set; }
        private ComisionLogic comisionLogic { get; set; }
        private CursoLogic CursoLogic { get; set; }
        private AlumnoInscripcionLogic AlumnoInscripcionLogic { get; set;}

        public InscripcionController()
        {
            this.materiaLogic = new MateriaLogic();
            this.CursoLogic = new CursoLogic();
            this.AlumnoInscripcionLogic = new AlumnoInscripcionLogic();
        }
        // GET: Inscripcion
        public ActionResult InscripcionAlumno()
        {
            try
            {
                List<Models.MateriaModel> materias = this.GetModelList();
                return View(materias);
            }
            catch(Exception)
            {
               return RedirectToAction("Index", "Home");
            }
       
        }

        public ActionResult ComisionesMateria(int idmateria,int idplan)
        {
            var modelList = new List<CursoModel>();
            foreach (var obj in this.CursoLogic.GetCursosByMateria(idmateria,idplan))
            {
                modelList.Add(new CursoModel(obj));
            }
            return View(modelList);
        }

        public ActionResult GenerarInscripcion(int idcurso)
        {
            var usuario = (Business.Entities.Usuario)this.HttpContext.Session["Usuario"];
            this.AlumnoInscripcionLogic.InscribirAlumno(usuario.IDPersona.Value, idcurso);
            return RedirectToAction("InscripcionAlumno", "Inscripcion");
        }


        public List<Models.MateriaModel> GetModelList()
        {
            var usuario = (Business.Entities.Usuario)this.HttpContext.Session["Usuario"];
            var listaobjs = this.materiaLogic.GetAllMateriasNoInscripctasByAlumno(usuario.IDPersona.Value);
            var listaModelos = new List<Models.MateriaModel>();
            foreach (var i in listaobjs)
            {
                listaModelos.Add(new Models.MateriaModel(i));
            }
            return listaModelos;
        }



    }
}