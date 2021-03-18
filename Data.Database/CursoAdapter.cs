using Business.Entities;
using Data.Database.context;
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
            using (var context = new AcademiaContext())
            {
                return context.Cursos.Include("Materia").Include("Comision").ToList();
            }
        }

        public Curso GetOne(int ID)
        {
            using (var context = new AcademiaContext())
            {
                return context.Cursos.Include("Materia").Include("Comision").FirstOrDefault(x => x.ID == ID);
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
            using (var context = new AcademiaContext())
            {
                var curso = context.Cursos.Find(ID);
                context.Cursos.Remove(curso);
                context.SaveChanges();
            }
        }

        protected void Update(Curso cur)
        {
            using (var context = new AcademiaContext())
            {
                var curso = context.Cursos.Find(cur.ID);
                context.Entry(curso).CurrentValues.SetValues(cur);
                context.SaveChanges();
            }
        }

        protected void Insert(Curso cur)
        {
            using (var context = new AcademiaContext())
            {
                context.Cursos.Add(cur);
                context.SaveChanges();
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

        public List<Curso> GetCursosByMateria(int idmateria, int idplan)
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("SELECT * FROM CURSOS C INNER JOIN materias m on m.id_materia = c.id_materia inner join comisiones co on c.id_comision = co.id_comision WHERE m.id_materia = @id and m.id_plan = @idplan", SqlConn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = idmateria;
                cmdCurso.Parameters.Add("@idplan", SqlDbType.Int).Value = idplan;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                while (drCurso.Read())
                {
                    Curso cur = new Curso();
                    cur.ID = (int)drCurso["id_curso"];
                    cur.IDComision = (int)drCurso["id_comision"];
                    cur.IDMateria = (int)drCurso["id_materia"];
                    cur.AnioCalendario = (int)drCurso["anio_calendario"];
                    cur.Cupo = (int)drCurso["cupo"];
                    cursos.Add(cur);
                }
                drCurso.Close();
                return cursos;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar cursos", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();




            }
        }
    }
}
