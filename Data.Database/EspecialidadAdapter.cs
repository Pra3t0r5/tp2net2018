using Business.Entities;
using Data.Database.context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {
            using(var context = new AcademiaContext())
            {
                return context.Especialidades.Include("Planes").ToList();
            }
        }

        public Especialidad GetOne(int ID)
        {
            using (var context = new AcademiaContext())
            {
                return context.Especialidades.Include("Planes").FirstOrDefault(x => x.ID == ID);
            }
        }

        public Especialidad GetOneFromPlan(int ID)
        {
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("SELECT * FROM especialidades e"+
                    "INNER JOIN planes p ON e.id_plan = p_id_plan"+
                    "WHERE id_plan = @id", SqlConn);
                cmdEspecialidad.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                if (drEspecialidad.Read())
                {
                    esp.ID = (int)drEspecialidad["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidad["desc_especialidad"];
                }
                drEspecialidad.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error el traer la especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return esp;
        }

        public void Delete(int ID)
        {
            using (var context = new AcademiaContext())
            {
                var especialidad = this.GetOne(ID);
                context.Especialidades.Attach(especialidad);
                context.Especialidades.Remove(especialidad);
                context.SaveChanges();
            }
        }

        protected void Update(Especialidad esp)
        {
            using (var context = new AcademiaContext())
            {
                var especialidad = context.Especialidades.Find(esp.ID);
                context.Entry(especialidad).CurrentValues.SetValues(esp);
                context.SaveChanges();
            }
        }

        protected void Insert(Especialidad esp)
        {
            using (var context = new AcademiaContext())
            {
                context.Especialidades.Add(esp);
                context.SaveChanges();
            }
        }

        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.Deleted)
            {
                this.Delete(especialidad.ID);
            }
            else if (especialidad.State == BusinessEntity.States.New)
            {
                this.Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                this.Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;

        }


        public List<Especialidad> GetAllByIdPlan(int idPlan)
        {

            List<Especialidad> especialidades = new List<Especialidad>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("SELECT * FROM ESPECIALIDADES e INNER JOIN PLANES p ON e.id_especialidad = p.id_especialidad WHERE id_plan = @idPlan", SqlConn);
                cmdEspecialidades.Parameters.Add("@idPlan", SqlDbType.Int).Value = idPlan;
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
                while (drEspecialidades.Read())
                {
                    Especialidad esp = new Especialidad();
                    esp.ID = drEspecialidades["id_especialidad"] != DBNull.Value? (int)drEspecialidades["id_especialidad"] : 0;
                    esp.Descripcion = drEspecialidades["desc_especialidad"] != DBNull.Value? (string)drEspecialidades["desc_especialidad"] : null;
                    especialidades.Add(esp);
                }
                drEspecialidades.Close();
                this.CloseConnection();

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar las especialidades", ex);
                throw ExcepcionManejada;
            }
            return especialidades;

        }

    }
}
