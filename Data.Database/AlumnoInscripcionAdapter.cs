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
    public class AlumnoInscripcionAdapter : Adapter
    {

        public List<AlumnoInscripcion> GetAllInscripciones()
        {
            List<AlumnoInscripcion> alumnoInscripcions = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripcion = new SqlCommand("SELECT al.id_inscripcion,al.id_alumno,al.id_curso,al.condicion,al.nota,p.legajo,p.nombre,p.apellido,com.desc_comision,mat.desc_materia from alumnos_inscripciones al " +
                "inner join personas p on p.id_persona = al.id_alumno "+
                "inner join cursos c on c.id_curso = al.id_curso "+
                "inner join materias mat on mat.id_materia = c.id_materia " +
                "inner join comisiones com on com.id_comision = c.id_comision where c.cupo > 0", SqlConn);
                SqlDataReader drInscripciones = cmdInscripcion.ExecuteReader();
                while (drInscripciones.Read())
                {
                    AlumnoInscripcion ains = new AlumnoInscripcion();
                    ains.ID = (int)drInscripciones["id_inscripcion"];
                    ains.IDAlumno = (int)drInscripciones["id_alumno"];
                    ains.IDCurso = (int)drInscripciones["id_curso"];
                    ains.Condicion = (string)drInscripciones["condicion"];
                    if (drInscripciones["legajo"] != DBNull.Value)
                    {
                        ains.LegajoAlumno = (int)drInscripciones["legajo"];
                    }
                    else
                    {
                        ains.LegajoAlumno = 0;
                    }
                   
           
                    if (drInscripciones["nombre"] != DBNull.Value)
                    {
                        ains.NombreAlumno = (string)drInscripciones["nombre"];
                    }
                    else
                    {
                        ains.NombreAlumno = null;
                    }
             
                    if (drInscripciones["apellido"] != DBNull.Value)
                    {
                        ains.ApellidoAlumno = (string)drInscripciones["apellido"];
                    }
                    else
                    {
                        ains.ApellidoAlumno = null;
                    }
                   
                    if (drInscripciones["desc_comision"] != DBNull.Value)
                    {
                        ains.DescripcionComision = (string)drInscripciones["desc_comision"];
                    }
                    else
                    {
                        ains.DescripcionComision = null;
                    }
                   
                    if (drInscripciones["desc_materia"] != DBNull.Value)
                    {
                        ains.DescripcionMateria = (string)drInscripciones["desc_materia"];
                    }
                    else
                    {
                        ains.DescripcionMateria = null;
                    }
                    if (drInscripciones["nota"] != DBNull.Value)
                    {
                        ains.Nota = (int?)drInscripciones["nota"];
                    }
                    else
                    {
                        ains.Nota = null;
                    }
                    alumnoInscripcions.Add(ains);
                }
                drInscripciones.Close();
                return alumnoInscripcions;
            }

            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer datos de inscripciones", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public List<AlumnoInscripcion> GetAlumnoInscripcionsWithDates(int desde, int hasta)
        {
            List<AlumnoInscripcion> alumnoInscripcions = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripcion = new SqlCommand("SELECT al.id_inscripcion,al.id_alumno,al.id_curso,al.condicion,al.nota,p.legajo,p.nombre,p.apellido,com.desc_comision,mat.desc_materia from alumnos_inscripciones al " +
                "inner join personas p on p.id_persona = al.id_alumno " +
                "inner join cursos c on c.id_curso = al.id_curso " +
                "inner join materias mat on mat.id_materia = c.id_materia " +
                "inner join comisiones com on com.id_comision = c.id_comision" +
                " where c.anio_calendario >= @desde and c.anio_calendario <= @hasta", SqlConn);
                cmdInscripcion.Parameters.Add("@desde", SqlDbType.Int).Value = desde;
                cmdInscripcion.Parameters.Add("@hasta", SqlDbType.Int).Value = hasta;
                SqlDataReader drInscripciones = cmdInscripcion.ExecuteReader();
                while (drInscripciones.Read())
                {
                    AlumnoInscripcion ains = new AlumnoInscripcion();
                    ains.ID = (int)drInscripciones["id_inscripcion"];
                    ains.IDAlumno = (int)drInscripciones["id_alumno"];
                    ains.IDCurso = (int)drInscripciones["id_curso"];
                    ains.Condicion = (string)drInscripciones["condicion"];
                    ains.LegajoAlumno = (int)drInscripciones["legajo"];
                    ains.NombreAlumno = (string)drInscripciones["nombre"];
                    ains.ApellidoAlumno = (string)drInscripciones["apellido"];
                    ains.DescripcionComision = (string)drInscripciones["desc_comision"];
                    ains.DescripcionMateria = (string)drInscripciones["desc_materia"];
                    alumnoInscripcions.Add(ains);
                }
                drInscripciones.Close();
                return alumnoInscripcions;
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer datos de inscripciones", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        public void InsertAlumnoInscripcion(int IDpersona, int IDCurso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripcion = new SqlCommand("INSERT INTO alumnos_inscripiones values (@idalumno,@idcurso,'Inscripto',null)",SqlConn);
                cmdInscripcion.Parameters.Add("@idalumno",SqlDbType.Int).Value = IDpersona;
                cmdInscripcion.Parameters.Add("@idcurso", SqlDbType.Int).Value = IDCurso;
                cmdInscripcion.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al inscribir alumno",ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public List<AlumnoInscripcion> GetAllInscripcionesDeAlumno()
        {
            List<AlumnoInscripcion> alumnoInscripcions = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripcion = new SqlCommand("SELECT al.id_inscripcion,al.id_alumno,al.id_curso,al.condicion,al.nota,p.legajo,p.nombre,p.apellido,com.desc_comision,mat.desc_materia from alumnos_inscripciones al " +
                "inner join personas p on p.id_persona = al.id_alumno " +
                "inner join cursos c on c.id_curso = al.id_curso " +
                "inner join materias mat on mat.id_materia = c.id_materia " +
                "inner join comisiones com on com.id_comision = c.id_comision where c.cupo > 0", SqlConn);
                SqlDataReader drInscripciones = cmdInscripcion.ExecuteReader();
                while (drInscripciones.Read())
                {
                    AlumnoInscripcion ains = new AlumnoInscripcion();
                    ains.ID = (int)drInscripciones["id_inscripcion"];
                    ains.IDAlumno = (int)drInscripciones["id_alumno"];
                    ains.IDCurso = (int)drInscripciones["id_curso"];
                    ains.Condicion = (string)drInscripciones["condicion"];
                    if (drInscripciones["legajo"] != DBNull.Value)
                    {
                        ains.LegajoAlumno = (int)drInscripciones["legajo"];
                    }
                    else
                    {
                        ains.LegajoAlumno = 0;
                    }


                    if (drInscripciones["nombre"] != DBNull.Value)
                    {
                        ains.NombreAlumno = (string)drInscripciones["nombre"];
                    }
                    else
                    {
                        ains.NombreAlumno = null;
                    }

                    if (drInscripciones["apellido"] != DBNull.Value)
                    {
                        ains.ApellidoAlumno = (string)drInscripciones["apellido"];
                    }
                    else
                    {
                        ains.ApellidoAlumno = null;
                    }

                    if (drInscripciones["desc_comision"] != DBNull.Value)
                    {
                        ains.DescripcionComision = (string)drInscripciones["desc_comision"];
                    }
                    else
                    {
                        ains.DescripcionComision = null;
                    }

                    if (drInscripciones["desc_materia"] != DBNull.Value)
                    {
                        ains.DescripcionMateria = (string)drInscripciones["desc_materia"];
                    }
                    else
                    {
                        ains.DescripcionMateria = null;
                    }
                    if (drInscripciones["nota"] != DBNull.Value)
                    {
                        ains.Nota = (int?)drInscripciones["nota"];
                    }
                    else
                    {
                        ains.Nota = null;
                    }
                    alumnoInscripcions.Add(ains);
                }
                drInscripciones.Close();
                return alumnoInscripcions;
            }

            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer datos de inscripciones", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
