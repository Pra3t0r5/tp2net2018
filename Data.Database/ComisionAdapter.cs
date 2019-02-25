using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {

        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM COMISIONES C INNER JOIN PLANES P ON P.id_plan = c.id_plan", SqlConn);
                SqlDataReader drComision = cmdComisiones.ExecuteReader();
                while(drComision.Read())
                {
                    Comision comi = new Comision();
                    comi.ID = (int)drComision["id_comision"];
                    comi.Descripcion = (string)drComision["desc_comision"];
                    comi.AnioEspecialidad = (int)drComision["anio_especialidad"];
                    comi.IDPlan = (int)drComision["id_plan"];
                    comi.DescripcionPlan = (string)drComision["desc_plan"];
                    comisiones.Add(comi);
                }
                drComision.Close();
                return comisiones;
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar comisiones", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        public Comision GetOne(int ID)
        {
            Comision comi = new Comision();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("SELECT * FROM COMISIONES C INNER JOIN PLANES P ON C.ID_PLAN = P.ID_PLAN WHERE C.ID_COMISION = @id", SqlConn);
                cmdComision.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drComision = cmdComision.ExecuteReader();
                if(drComision.Read())
                {
                    comi.ID = (int)drComision["id_comision"];
                    comi.Descripcion = (string)drComision["desc_comision"];
                    comi.AnioEspecialidad = (int)drComision["anio_especialidad"];
                    comi.IDPlan = (int)drComision["id_plan"];
                    comi.DescripcionPlan = (string)drComision["desc_plan"];
                }
                drComision.Close();
                return comi;
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer comision", ex);
                throw ExcepcionManejada;
            }
            finally
            {
               this.CloseConnection();
            }
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("DELETE FROM COMISIONES WHERE ID_COMISION = @ID", SqlConn);
                cmdComisiones.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                cmdComisiones.ExecuteNonQuery();
            }
           catch (SqlException)
            {
               Exception ExcepcionManejada = new Exception("Error al eliminar comision");
                throw ExcepcionManejada;

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar comision", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Comision comi)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("UPDATE COMISIONES SET DESC_COMISION = @DESCRIPCION, ANIO_ESPECIALIDAD = @ANIO , ID_PLAN = @IDPLAN WHERE ID_COMISION = @IDCOMISION", SqlConn);
                cmdComision.Parameters.Add("@IDCOMISION", SqlDbType.Int).Value = comi.ID;
                cmdComision.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = comi.Descripcion;
                cmdComision.Parameters.Add("@ANIO", SqlDbType.Int).Value = comi.AnioEspecialidad;
                cmdComision.Parameters.Add("@IDPLAN", SqlDbType.Int).Value = comi.IDPlan;
                cmdComision.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar comision", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Comision comi)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("INSERT INTO COMISIONES (DESC_COMISION,ANIO_ESPECIALIDAD,ID_PLAN) VALUES (@DESCRIPCION,@ANIO,@IDPLAN); select @@identity", SqlConn);
                cmdComision.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = comi.Descripcion;
                cmdComision.Parameters.Add("@ANIO", SqlDbType.Int).Value = comi.AnioEspecialidad;
                cmdComision.Parameters.Add("@IDPLAN", SqlDbType.Int).Value = comi.IDPlan;
                comi.ID = decimal.ToInt32((decimal)cmdComision.ExecuteScalar());

            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al agregar comision", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
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
