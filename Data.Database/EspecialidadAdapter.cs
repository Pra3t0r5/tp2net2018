using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("SELECT * FROM ESPECIALIDADES", SqlConn);
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
                while (drEspecialidades.Read())
                {
                    Especialidad esp = new Especialidad();
                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidades["desc_especialidad"];
                    especialidades.Add(esp);
                }
                drEspecialidades.Close();
                this.CloseConnection();
                
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar las especialidades",ex);
                throw ExcepcionManejada;
            }
            return especialidades;
        }

        public Especialidad GetOne(int ID)
        {
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("SELECT * FROM especialidades where id_especialidad = @id", SqlConn);
                cmdEspecialidad.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                if (drEspecialidad.Read())
                {
                    esp.ID = (int)drEspecialidad["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidad["desc_especialidad"];
                }
                drEspecialidad.Close();
            }
            catch(Exception Ex)
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
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("delete from especialidades where id_especialidad = @id", SqlConn);
                cmdEspecialidad.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdEspecialidad.ExecuteNonQuery();
               
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al borrar especialidad", ex);
                throw ExcepcionManejada;
                           
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Especialidad esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("UPDATE especialidades set desc_especialidad = @descripcion where id_especialidad = @id", SqlConn);
                cmdEspecialidad.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = esp.Descripcion;
                cmdEspecialidad.Parameters.Add("@id", SqlDbType.Int).Value = esp.ID;
                cmdEspecialidad.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar la especialidad", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Especialidad esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("INSERT INTO especialidades (desc_especialidad) values (@descripcion)", SqlConn);
                cmdEspecialidad.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = esp.Descripcion;
                cmdEspecialidad.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al agregar una nueva especialidad", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
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
