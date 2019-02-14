using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace Business.Logic
{
    public class ComisionLogic
    {
        private MetodosParaCombosBox combos { get; set; }
        private ComisionAdapter ComisionData { get; set; }

        public ComisionLogic()
        {
            this.combos = new MetodosParaCombosBox();
            this.ComisionData = new ComisionAdapter();
        }

        public List<Comision> GetAll()
        {
            return this.ComisionData.GetAll();
        }

        public Comision GetOne(int ID)
        {
            return this.ComisionData.GetOne(ID);
        }

        public void Save(Comision comi)
        {
            //try
            //{
            this.ComisionData.Save(comi);
            //}
            //catch(Exception)
            //{
            //    Exception ErrorAlborrar = new Exception("Error al borrar comision, asegurese que los cursos relacionados al mismo este eliminados primero");
            ////    throw ErrorAlborrar;
            ////}

        }

        public void Delete(int ID)
        {
            try
            {
                this.ComisionData.Delete(ID);
            }
            catch (Exception ex)
            {

                Exception ExcepcionManejada = new Exception("Error al eliminar la comision", ex);
                throw ExcepcionManejada;
            }
           
            
        }

        public List<Comision> GetAllCombo()
        {
            return this.combos.GetAllComisiones();
        }

        public List<Comision> GetAllByMateria(int idPlan)
        {
            return this.ComisionData.GetAllByMateria(idPlan);
        }
    }
}
