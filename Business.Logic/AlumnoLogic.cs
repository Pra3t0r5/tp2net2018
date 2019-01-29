using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class AlumnoLogic
    {
        private AlumnoAdapter AlumnoData { get; set; }

        public AlumnoLogic()
        {
            this.AlumnoData = new AlumnoAdapter();
        }

        public List<Persona> GetAll()
        {
            return this.AlumnoData.GetAll();
        }

        public Persona GetOne(int ID)
        {
            return this.AlumnoData.GetOne(ID);
        }

        public void Save(Persona persona)
        {
            this.AlumnoData.Save(persona);
        }

        public void Delete(int ID)
        {
            this.AlumnoData.Delete(ID);
        }

    }
}
