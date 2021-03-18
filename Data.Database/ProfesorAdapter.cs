using Business.Entities;
using Data.Database.context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class ProfesorAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            using (var context = new AcademiaContext())
            {
                return context.Personas.Include("Plan").Where(x => x.TipoPersona == (int)Persona.TipoPersonaEnum.Profesor).ToList();
            }

        }

        public Persona GetOne(int ID)
        {
            using (var context = new AcademiaContext())
            {
                return context.Personas.Include("Plan").FirstOrDefault(x => x.ID == ID);
            }
        }

        public void Delete(int ID)
        {
            using (var context = new AcademiaContext())
            {
                var alumno = context.Personas.Find(ID);
                context.Personas.Remove(alumno);
                context.SaveChanges();
            }
        }

        protected void Update(Persona psr)
        {
            using (var context = new AcademiaContext())
            {
                var alumno = context.Personas.Find(psr.ID);
                context.Entry(alumno).CurrentValues.SetValues(psr);
                context.SaveChanges();
            }
        }

        protected void Insert(Persona psr)
        {
            using (var context = new AcademiaContext())
            {
                psr.TipoPersona = (int)Persona.TipoPersonaEnum.Profesor;
                context.Personas.Add(psr);
                context.SaveChanges();
            }
        }

        public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(persona.ID);
            }
            else if (persona.State == BusinessEntity.States.New)
            {
                this.Insert(persona);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                this.Update(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }

    }
}
