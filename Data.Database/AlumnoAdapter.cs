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
    public class AlumnoAdapter: Adapter
    {
        public List<Persona> GetAll()
        {
            List<Persona> alumnos = new List<Persona>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnos = new SqlCommand("SELECT * FROM PERSONAS where tipo_persona = 2",SqlConn);
                SqlDataReader drAlumnos = cmdAlumnos.ExecuteReader();
                while(drAlumnos.Read())
                {
                    Persona psr = new Persona();
                    psr.ID = (int)drAlumnos["id_persona"];
                    psr.Nombre = (string)drAlumnos["nombre"];
                    psr.Apellido = (string)drAlumnos["apellido"];
                    psr.Direccion = drAlumnos["direccion"] != DBNull.Value? (string)drAlumnos["direccion"] : null;
                    psr.Email = drAlumnos["email"] != DBNull.Value ? (string)drAlumnos["email"] : null ;
                    psr.Telefono = drAlumnos["telefono"] != DBNull.Value ? (string)drAlumnos["telefono"] : null;
                    psr.FechaNacimiento = (DateTime)drAlumnos["fecha_nac"];
                    psr.Legajo = drAlumnos["legajo"] != DBNull.Value? (int)drAlumnos["legajo"] : 0;
                    psr.TipoPersona = drAlumnos["tipo_persona"] != DBNull.Value ? (int)drAlumnos["tipo_persona"] : 0;
                    psr.IDPlan = (int)drAlumnos["id_plan"];
                    alumnos.Add(psr);
                }
                drAlumnos.Close();
                this.CloseConnection();
                return alumnos;
            }
            catch(Exception Ex)
            {
                Exception ExcepcionControlada = new Exception("Error al traer datos de alumnos",Ex);
                throw ExcepcionControlada;
            }

        }

        public Persona GetOne(int ID)
        {
            Persona psr = new Persona();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("SELECT * FROM PERSONAS WHERE id_persona=@id and tipo_persona = 2",SqlConn);
                cmdUsuario.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drAlumnos = cmdUsuario.ExecuteReader();
                if (drAlumnos.Read())
                {
                    
                    psr.ID = (int)drAlumnos["id_persona"];
                    psr.Nombre = (string)drAlumnos["nombre"];
                    psr.Apellido = (string)drAlumnos["apellido"];
                    psr.Direccion = (string)drAlumnos["direccion"];
                    psr.Email = (string)drAlumnos["email"];
                    psr.Telefono = (string)drAlumnos["telefono"];
                    psr.FechaNacimiento = (DateTime)drAlumnos["fecha_nac"];
                    psr.Legajo = (int)drAlumnos["legajo"];
                    psr.TipoPersona = (int)drAlumnos["legajo"];
                    psr.IDPlan = (int)drAlumnos["id_plan"];
                }
                drAlumnos.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionControlada = new Exception("Error al recuperar alumno", Ex);
                throw ExcepcionControlada;
            }
            finally
            {
                this.CloseConnection();
            }
            return psr;
        }
        public Persona GetOneByLegajo(int Legajo)
        {
            Persona psr = new Persona();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("SELECT * FROM PERSONAS WHERE legajo=@legajo and tipo_persona = 2", SqlConn);
                cmdUsuario.Parameters.Add("@legajo", SqlDbType.Int).Value = Legajo;
                SqlDataReader drAlumnos = cmdUsuario.ExecuteReader();
                if (drAlumnos.Read())
                {

                    psr.ID = (int)drAlumnos["id_persona"];
                    psr.Nombre = (string)drAlumnos["nombre"];
                    psr.Apellido = (string)drAlumnos["apellido"];
                    psr.Direccion = (string)drAlumnos["direccion"];
                    psr.Email = (string)drAlumnos["email"];
                    psr.Telefono = (string)drAlumnos["telefono"];
                    psr.FechaNacimiento = (DateTime)drAlumnos["fecha_nac"];
                    psr.Legajo = (int)drAlumnos["legajo"];
                    psr.TipoPersona = (int)drAlumnos["legajo"];
                    psr.IDPlan = (int)drAlumnos["id_plan"];
                }
                drAlumnos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionControlada = new Exception("Error al recuperar alumno", Ex);
                throw ExcepcionControlada;
            }
            finally
            {
                this.CloseConnection();
            }
            return psr;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnos = new SqlCommand("DELETE FROM PERSONAS WHERE id_persona = @id",SqlConn);
                cmdAlumnos.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdAlumnos.ExecuteNonQuery();

            }
            catch(Exception Ex)
            {
                Exception ExcepcionControlada = new Exception("Error al recuperar alumno", Ex);
                throw ExcepcionControlada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Persona psr)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnos = new SqlCommand("UPDATE PERSONAS set nombre = @nombre, apellido = @apellido, " +
                    "direccion = @direccion, email = @email, telefono = @telefono , fecha_nac = @fechanac, legajo = @legajo, tipo_persona = @tipopersona, id_plan = @idplan where id_persona = @id "
                    ,SqlConn);
                cmdAlumnos.Parameters.Add("@id", SqlDbType.Int).Value = psr.ID;
                cmdAlumnos.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = psr.Nombre;
                cmdAlumnos.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = psr.Apellido;
                cmdAlumnos.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = psr.Direccion;
                cmdAlumnos.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = psr.Email;
                cmdAlumnos.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = psr.Telefono;
                cmdAlumnos.Parameters.Add("@fechanac", SqlDbType.DateTime).Value = psr.FechaNacimiento;
                cmdAlumnos.Parameters.Add("@legajo", SqlDbType.Int).Value = psr.Legajo;
                cmdAlumnos.Parameters.Add("@tipopersona", SqlDbType.Int).Value = psr.TipoPersona;
                cmdAlumnos.Parameters.Add("@idplan", SqlDbType.Int).Value = psr.IDPlan;
                cmdAlumnos.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Persona psr)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnos = new SqlCommand("INSERT INTO PERSONAS(nombre,apellido,direccion,email,telefono,fecha_nac,legajo,tipo_persona,id_plan)" +
                    "values (@nombre,@apellido,@direccion,@email,@telefono,@fechanac,@legajo,@tipopersona,@idplan)", SqlConn);
                cmdAlumnos.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = psr.Nombre;
                cmdAlumnos.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = psr.Apellido;
                cmdAlumnos.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = psr.Direccion;
                cmdAlumnos.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = psr.Email;
                cmdAlumnos.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = psr.Telefono;
                cmdAlumnos.Parameters.Add("@fechanac", SqlDbType.DateTime).Value = psr.FechaNacimiento;
                cmdAlumnos.Parameters.Add("@legajo", SqlDbType.Int).Value = psr.Legajo;
                cmdAlumnos.Parameters.Add("@tipopersona", SqlDbType.Int).Value = 2;
                cmdAlumnos.Parameters.Add("@idplan", SqlDbType.Int).Value = 1;
                cmdAlumnos.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al agregar alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(persona.ID);
            }
            else if (persona.State == BusinessEntity.States.New)
            {
                this.Insert(persona);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                this.Update(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }

    }
}
