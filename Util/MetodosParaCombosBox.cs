using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class MetodosParaCombosBox : Adapter
    {
        public List<Comision> GetAllComisiones()
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("SELECT id_comision,desc_comision from comisiones", SqlConn);
                SqlDataReader drComision = cmdComision.ExecuteReader();
                while(drComision.Read())
                {
                    Comision cur = new Comision();
                    cur.ID = (int)drComision["id_comision"];
                    cur.Descripcion = (string)drComision["desc_comision"];
                    comisiones.Add(cur);
                }
                drComision.Close();
                return comisiones;
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer las comisiones", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        public List<Especialidad> GetAllEspecialidadesForCombo()
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("SELECT ID_ESPECIALIDAD,DESC_ESPECIALIDAD FROM ESPECIALIDADES", SqlConn);
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                while(drEspecialidad.Read())
                {
                    Especialidad esp = new Especialidad();
                    esp.ID = (int)drEspecialidad["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidad["desc_especialidad"];
                    especialidades.Add(esp);
                }
                drEspecialidad.Close();
                return especialidades;
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer especialidades", ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
        }

        public List<Plan> GetAllPlanesForCombo()
        {
            List<Plan> planes = new List<Plan>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("SELECT ID_PLAN,DESC_PLAN FROM PLANES", SqlConn);
                SqlDataReader drplan = cmdPlan.ExecuteReader();
                while(drplan.Read())
                {
                    Plan plan = new Plan();
                    plan.ID = (int)drplan["id_plan"];
                    plan.Descripcion = (string)drplan["desc_plan"];
                    planes.Add(plan);
                }
                drplan.Close();
                return planes;
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer planes", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
