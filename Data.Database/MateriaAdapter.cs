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
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAllForCombo()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT ID_MATERIA,DESC_MATERIA FROM MATERIAS", SqlConn);
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                while(drMaterias.Read())
                {
                    Materia mat = new Materia();
                    mat.ID = (int)drMaterias["id_materia"];
                    mat.Descripcion = (string)drMaterias["desc_materia"];
                    materias.Add(mat);
                }
                drMaterias.Close();
                return materias;
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer materias",ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT * from materias m inner join planes p on m.id_plan = p.id_plan", SqlConn);
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                while(drMaterias.Read())
                {
                    Materia mat = new Materia();
                    mat.ID = (int)drMaterias["id_materia"];
                    mat.Descripcion = (string)drMaterias["desc_materia"];
                    mat.HSSemanales = (int)drMaterias["hs_semanales"];
                    mat.HSTotales = (int)drMaterias["hs_totales"];
                    mat.IDPlan = (int)drMaterias["id_plan"];
                    mat.DescripcionPlan = (string)drMaterias["desc_plan"];
                    materias.Add(mat);
                }
                drMaterias.Close();
                return materias;
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer materias", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Materia GetOne(int ID)
        {
            Materia mat = new Materia();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT * FROM MATERIAS M INNER JOIN PLANES P ON M.ID_PLAN = P.ID_PLAN", SqlConn);
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                if(drMaterias.Read())
                {
                    mat.ID = (int)drMaterias["id_materia"];
                    mat.Descripcion = (string)drMaterias["desc_materia"];
                    mat.HSSemanales = (int)drMaterias["hs_semanales"];
                    mat.HSTotales = (int)drMaterias["hs_totales"];
                    mat.IDPlan = (int)drMaterias["id_plan"];
                    mat.DescripcionPlan = (string)drMaterias["desc_plan"];
                }
                drMaterias.Close();
                return mat;
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer materia", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }

        public void Insert(Materia mat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("INSERT INTO MATERIAS (desc_materia,hs_semanales,hs_totales,id_plan VALUES(@DESCMATERIA,@HSSEMANALES,@HSTOTALES,@IDPLAN)", SqlConn);
                cmdMaterias.Parameters.Add("@DESCMATERIA", SqlDbType.Int).Value = mat.Descripcion;
                cmdMaterias.Parameters.Add("@HSSEMANALES", SqlDbType.Int).Value = mat.HSSemanales;
                cmdMaterias.Parameters.Add("@HSTOTALES", SqlDbType.Int).Value = mat.HSTotales;
                cmdMaterias.Parameters.Add("@IDPLAN", SqlDbType.Int).Value = mat.IDPlan;
                cmdMaterias.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al agregar usuario", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        public void Update(Materia mat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("UPDATE MATERIAS SET desc_materia = @DESCMATERIA, hs_semanales = @HSSEMANALES, hs_totales = @HSTOTALES, id_plan = @IDPLAN where id_materia = @ID", SqlConn);
                cmdMaterias.Parameters.Add("@ID", SqlDbType.Int).Value = mat.ID;
                cmdMaterias.Parameters.Add("@DESCMATERIA", SqlDbType.VarChar,50).Value = mat.Descripcion;
                cmdMaterias.Parameters.Add("@HSSEMANALES", SqlDbType.Int).Value = mat.HSSemanales;
                cmdMaterias.Parameters.Add("@HSTOTALES", SqlDbType.Int).Value = mat.HSTotales;
                cmdMaterias.Parameters.Add("@IDPLAN", SqlDbType.Int).Value = mat.IDPlan;
                cmdMaterias.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar materia", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("DELETE FROM MATERIAS WHERE ID_MATERIA = @ID", SqlConn);
                cmdMaterias.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                cmdMaterias.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al borrar materia", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Materia mat)
        {
            if (mat.State == BusinessEntity.States.Deleted)
            {
                this.Delete(mat.ID);
            }
            else if (mat.State == BusinessEntity.States.New)
            {
                this.Insert(mat);
            }
            else if (mat.State == BusinessEntity.States.Modified)
            {
                this.Update(mat);
            }
            mat.State = BusinessEntity.States.Unmodified;
        }

        public List<Materia> GetAllByIdPlan(int idPlan)
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT * FROM materias WHERE id_plan = @idPlan ", SqlConn);
                cmdMaterias.Parameters.Add("@idPlan", SqlDbType.Int).Value = idPlan;
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                while (drMaterias.Read())
                {
                    Materia mat = new Materia();
                    mat.ID = drMaterias["id_materia"] != DBNull.Value? (int)drMaterias["id_materia"] : 0;
                    mat.Descripcion = drMaterias["desc_materia"] != DBNull.Value? (string)drMaterias["desc_materia"] : null;
                    mat.HSSemanales = drMaterias["hs_semanales"] != DBNull.Value ? (int)drMaterias["hs_Semanales"] : 0;
                    mat.HSTotales = drMaterias["hs_totales"] != DBNull.Value ? (int)drMaterias["hs_totales"] : 0;
                    mat.IDPlan = drMaterias["id_plan"] != DBNull.Value ? (int)drMaterias["id_plan"] : 0;
                    materias.Add(mat);
                }
                drMaterias.Close();
                return materias;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer materias", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


    }
}
