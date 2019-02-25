using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class CursoLogic
    {
        private CursoAdapter CursoData { get; set; }

        public CursoLogic()
        {
            this.CursoData = new CursoAdapter();
        }

        public List<Curso> GetAll()
        {
            return this.CursoData.GetAll();
        }

        public Curso GetOne(int ID)
        {
           return this.CursoData.GetOne(ID);
        }

        public void Save(Curso cur)
        {
            this.CursoData.Save(cur);
        }

        public void Delete(int ID)
        {
            try
            {
                this.CursoData.Delete(ID);
            }
            catch (Exception ex)
            {

                Exception ExcepcionManejada = new Exception("Error al eliminar el curso", ex);
                throw ExcepcionManejada;
            }
            
        }

        public List<Curso> GetCursosByMateria(int idmateria,int idplan)
        {
            return this.CursoData.GetCursosByMateria(idmateria, idplan);
        }
    }
}
