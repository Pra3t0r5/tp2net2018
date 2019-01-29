using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace Business.Logic
{
    public class PlanLogic
    {
        private MetodosParaCombosBox Metodos { get; set; }      
        private PlanAdapter PlanData { get; set; }

        public PlanLogic()
        {
            this.Metodos = new MetodosParaCombosBox();
            this.PlanData = new PlanAdapter();
        }

        public List<Plan> GetAllForCombo()
        {
            return this.Metodos.GetAllPlanesForCombo();
        }

        public List<Plan> GetAll()
        {
            return this.PlanData.GetAll();
        }

        public Plan GetOne(int ID)
        {
            return this.PlanData.GetOne(ID);
        }

        public void Save(Plan plan)
        {
            this.PlanData.Save(plan);
        }

        public void Delete(int ID)
        {
            try
            {

                this.PlanData.Delete(ID);
            }

            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el plan", ex);
                throw ExcepcionManejada;
            }
        }
    }
}
