using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ProfesorLogic
    {
        private ProfesorAdapter ProfesorData { get; set; }

        public ProfesorLogic()
        {
            this.ProfesorData = new ProfesorAdapter();
        }

        public List<Persona> GetAll()
        {
            return this.ProfesorData.GetAll();
        }

        public Persona GetOne(int ID)
        {
            return this.ProfesorData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            this.ProfesorData.Delete(ID);
        }

        public void Save(Persona persona)
        {
            this.ProfesorData.Save(persona);
        }

    }
}
