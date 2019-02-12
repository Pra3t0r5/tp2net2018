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
    public class CursoAdapter : Adapter
    {
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("SELECT * FROM CURSOS C INNER JOIN materias m on m.id_materia = c.id_materia inner join comisiones co on c.id_comision = co.id_comision", SqlConn);
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                while(drCursos.Read())
                {
                    Curso cur = new Curso();
                    cur.ID = (int)drCursos["id_curso"];
                    cur.IDMateria = (int)drCursos["id_materia"];
                    cur.IDComision = (int)drCursos["id_comision"];
                    cur.AnioCalendario = (int)drCursos["anio_calendario"];
                    cur.Cupo = (int)drCursos["cupo"];
                    cur.DescripcionComision = (string)drCursos["desc_comision"];
                    cur.DescripcionMateria = (string)drCursos["desc_materia"];
                    cursos.Add(cur);
                }
                drCursos.Close();
                return cursos;
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los cursos",ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Curso GetOne(int ID)
        {
            Curso cur = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("SELECT * FROM CURSOS C INNER JOIN materias m on m.id_materia = c.id_materia inner join comisiones co on c.id_comision = co.id_comision WHERE c.id_curso = @id", SqlConn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                if(drCurso.Read())
                {
                    cur.ID = (int)drCurso["id_curso"];
                    cur.IDComision = (int)drCurso["id_comision"];
                    cur.IDMateria = (int)drCurso["id_materia"];
                    cur.AnioCalendario = (int)drCurso["anio_calendario"];
                    cur.DescripcionComision = (string)drCurso["desc_comision"];
                    cur.DescripcionMateria = (string)drCurso["desc_materia"];
                    cur.Cupo = (int)drCurso["cupo"];
                }
                drCurso.Close();
                return cur;
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar curso",ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public int GetOneByIDs(int IDcomision, int IDmateria)
        {
            Curso cur = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("SELECT * FROM CURSOS WHERE id_materia = @IDmateria AND id_comision = @IDcomision", SqlConn);
                cmdCurso.Parameters.Add("@IDmateria", SqlDbType.Int).Value = IDmateria;
                cmdCurso.Parameters.Add("@IDcomision", SqlDbType.Int).Value = IDcomision;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                if (drCurso.Read())
                {
                    cur.ID = (int)drCurso["id_curso"];
                }
                drCurso.Close();
                return cur.ID;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar ID curso", ex);
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
                SqlCommand cmdCurso = new SqlCommand("DELETE FROM CURSOS WHERE id_curso = @id", SqlConn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdCurso.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar curso", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Curso cur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("UPDATE CURSOS set id_materia = @idmateria, id_comision = @idcomision, anio_calendario = @aniocalendario, cupo = @cupo where id_curso = @id", SqlConn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = cur.ID;
                cmdCurso.Parameters.Add("@idmateria", SqlDbType.Int).Value = cur.IDMateria;
                cmdCurso.Parameters.Add("@idcomision", SqlDbType.Int).Value = cur.IDComision;
                cmdCurso.Parameters.Add("@aniocalendario", SqlDbType.Int).Value = cur.AnioCalendario;
                cmdCurso.Parameters.Add("@cupo", SqlDbType.Int).Value = cur.Cupo;
                cmdCurso.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar curso", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Curso cur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("INSERT INTO CURSOS (id_materia,id_comision,anio_calendario,cupo) values(@idmateria,@idcomision,@aniocalendario,@cupo)", SqlConn);
                cmdCurso.Parameters.Add("@idmateria", SqlDbType.Int).Value = cur.IDMateria;
                cmdCurso.Parameters.Add("@idcomision", SqlDbType.Int).Value = cur.IDComision;
                cmdCurso.Parameters.Add("@aniocalendario", SqlDbType.Int).Value = cur.AnioCalendario;
                cmdCurso.Parameters.Add("@cupo", SqlDbType.Int).Value = cur.Cupo;
                cmdCurso.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al insertar un nuevo curso",ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(curso.ID);
            }
            else if (curso.State == BusinessEntity.States.New)
            {
                this.Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                this.Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }
    }
}
