using Business.Entities;
using Data.Database.context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {

        public List<Comision> GetAll()
        {
            using (var context = new AcademiaContext())
            {
                return context.Comisiones.Include("Plan").ToList();
            }
        }


        public Comision GetOne(int ID)
        {
            using (var context = new AcademiaContext())
            {
                return context.Comisiones.Include("Plan").FirstOrDefault(x => x.ID == ID);
            }
        }

        public void Delete(int ID)
        {
            using (var context = new AcademiaContext())
            {
                var comision = context.Comisiones.Find(ID);
                context.Comisiones.Remove(comision);
                context.SaveChanges();
            }
        }

        protected void Update(Comision comi)
        {
            using (var context = new AcademiaContext())
            {
                var comision = context.Comisiones.Find(comi.ID);
                context.Entry(comision).CurrentValues.SetValues(comi);
                context.SaveChanges();
            }
        }

        protected void Insert(Comision comi)
        {
            using (var context = new AcademiaContext())
            {
                context.Comisiones.Add(comi);
                context.SaveChanges();
            }
        }

        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.Deleted)
            {
                this.Delete(comision.ID);
            }
            else if (comision.State == BusinessEntity.States.New)
            {
                this.Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                this.Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }

        public List<Comision> GetAllByMateria(int idPlan)
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM COMISIONES WHERE id_plan = @idPlan", SqlConn);
                cmdComisiones.Parameters.Add("@idPlan", SqlDbType.Int).Value = idPlan;
                SqlDataReader drComision = cmdComisiones.ExecuteReader();
                while (drComision.Read())
                {
                    Comision comi = new Comision();
                    comi.ID = (int)drComision["id_comision"];
                    comi.Descripcion = (string)drComision["desc_comision"];
                    comi.AnioEspecialidad = (int)drComision["anio_especialidad"];
                    comi.IDPlan = (int)drComision["id_plan"];
                    comisiones.Add(comi);
                }
                drComision.Close();
                return comisiones;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar comisiones", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

      


    }
}
