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
    public class EspecialidadLogic
    {   
        private MetodosParaCombosBox combos { get; set; }
        EspecialidadAdapter EspecialidadData { get; set; }

        public EspecialidadLogic()
        {
            this.EspecialidadData = new EspecialidadAdapter();
            this.combos = new MetodosParaCombosBox();
        }

        public List<Especialidad> GetAllForCombo()
        {
            return this.combos.GetAllEspecialidadesForCombo();
        }

        public List<Especialidad> GetAll()
        {
            return this.EspecialidadData.GetAll();
        }

        public Especialidad GetOne(int ID)
        {
            return this.EspecialidadData.GetOne(ID);
        }
        public Especialidad GetOneFromPlan(int ID)
        {
            return this.EspecialidadData.GetOneFromPlan(ID);
        }

        public void Save(Especialidad esp)
        {
            this.EspecialidadData.Save(esp);
        }

        public void Delete(int ID)
        {
            try
            {
                this.EspecialidadData.Delete(ID);
            }
            
            
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al borrar especialidad", ex);
                throw ExcepcionManejada;

            }
        
        }

    }
}
