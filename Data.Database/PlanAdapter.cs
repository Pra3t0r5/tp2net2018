using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            List<Plan> planes = new List<Plan>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("SELECT * from planes p inner join especialidades e on p.id_especialidad = e.id_especialidad ",SqlConn);
                SqlDataReader drPlan = cmdPlan.ExecuteReader();
                while(drPlan.Read())
                {
                    Plan pl = new Plan();
                    pl.ID = (int)drPlan["id_plan"];
                    pl.Descripcion = (string)drPlan["desc_plan"];
                    pl.IDEspecialdad = (int)drPlan["id_especialidad"];
                    pl.DescripcionEspecialidad = (string)drPlan["desc_especialidad"];
                    planes.Add(pl);
                }
                drPlan.Close();
                return planes;
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar planes", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Plan GetOne(int ID)
        {
            Plan plan = new Plan();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("SELECT * FROM PLANES p inner join especialidades e on e.id_especialidad = p.id_especialidad where id_plan = @idplan",SqlConn);
                cmdPlan.Parameters.Add("@idplan", SqlDbType.Int).Value = ID;
                SqlDataReader drPlanes = cmdPlan.ExecuteReader();
                if(drPlanes.Read())
                {
                    plan.ID = (int)drPlanes["id_plan"];
                    plan.Descripcion = (string)drPlanes["desc_plan"];
                    plan.DescripcionEspecialidad = (string)drPlanes["desc_especialidad"];
                    plan.IDEspecialdad = (int)drPlanes["id_especialidad"];
                }
                drPlanes.Close();
                return plan;
            }
            catch(Exception ex)
            {
                Exception ExceptionManejada = new Exception("Error al traer plan",ex);
                throw ExceptionManejada;
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
                SqlCommand cmdPlan = new SqlCommand("DELETE FROM PLANES WHERE ID_PLAN = @IDPLAN", SqlConn);
                cmdPlan.Parameters.Add("@IDPLAN", SqlDbType.Int).Value = ID;
                cmdPlan.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar plan", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("UPDATE PLANES SET desc_plan = @descplan , id_especialidad = @idespecialidad where id_plan = @idplan", SqlConn);
                cmdPlan.Parameters.Add("@idplan", SqlDbType.Int).Value = plan.ID;
                cmdPlan.Parameters.Add("@descplan", SqlDbType.VarChar, 100).Value = plan.Descripcion;
                cmdPlan.Parameters.Add("idespecialidad", SqlDbType.Int).Value = plan.IDEspecialdad;
                cmdPlan.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar plan", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand("INSERT INTO PLANES (desc_plan,id_especialidad) values (@descplan,@idespecialidad); select @@identity", SqlConn);
                cmdPlanes.Parameters.Add("@descplan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdPlanes.Parameters.Add("@idespecialidad", SqlDbType.Int).Value = plan.IDEspecialdad;
                cmdPlanes.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al agregar plan", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan.ID);
            }
            else if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }

    }
}
