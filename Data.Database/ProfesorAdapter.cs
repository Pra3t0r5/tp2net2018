using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class ProfesorAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            List<Persona> profesores = new List<Persona>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdProfesores = new SqlCommand("SELECT * FROM PERSONAS pe inner join planes p on p.id_plan = pe.id_plan where tipo_persona = 1", SqlConn);
                SqlDataReader drProfesores = cmdProfesores.ExecuteReader();
                while (drProfesores.Read())
                {
                    Persona psr = new Persona();
                    psr.ID = (int)drProfesores["id_persona"];
                    psr.Nombre = (string)drProfesores["nombre"];
                    psr.Apellido = (string)drProfesores["apellido"];
                    psr.TipoPersona = (int)drProfesores["tipo_persona"];
                    psr.IDPlan = (int)drProfesores["id_plan"];
                    psr.DescripcionPlan = (string)drProfesores["desc_plan"];
                    psr.FechaNacimiento = (DateTime)drProfesores["fecha_nac"];
                    psr.Direccion = drProfesores["direccion"] != DBNull.Value ? (string)drProfesores["direccion"] : null;
                    psr.Telefono = drProfesores["telefono"] != DBNull.Value ? (string)drProfesores["telefono"] : null;
                    psr.Legajo = drProfesores["legajo"] != DBNull.Value ? (int)drProfesores["legajo"] : 0;
                    psr.Email = drProfesores["email"] != DBNull.Value ? (string)drProfesores["email"] : null;
                    profesores.Add(psr);
                }
                drProfesores.Close();               
                return profesores;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionControlada = new Exception("Error al traer datos de profesores", Ex);
                throw ExcepcionControlada;
            }
            finally
            {
                this.CloseConnection();
            }

        }

        public Persona GetOne(int ID)
        {
            Persona psr = new Persona();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("SELECT * FROM PERSONAS WHERE id_persona=@id and tipo_persona = 1", SqlConn);
                cmdUsuario.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drProfesores = cmdUsuario.ExecuteReader();
                if (drProfesores.Read())
                {

                    psr.ID = (int)drProfesores["id_persona"];
                    psr.Nombre = (string)drProfesores["nombre"];
                    psr.Apellido = (string)drProfesores["apellido"];
                    psr.Direccion = (string)drProfesores["direccion"];
                    psr.Email = (string)drProfesores["email"];
                    psr.Telefono = (string)drProfesores["telefono"];
                    psr.FechaNacimiento = (DateTime)drProfesores["fecha_nac"];
                    psr.Legajo = (int)drProfesores["legajo"];
                    psr.TipoPersona = (int)drProfesores["legajo"];
                    psr.IDPlan = (int)drProfesores["id_plan"];
                }
                drProfesores.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionControlada = new Exception("Error al recuperar profesor", Ex);
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
                SqlCommand cmdProfesores = new SqlCommand("DELETE FROM PERSONAS WHERE id_persona = @id", SqlConn);
                cmdProfesores.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdProfesores.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionControlada = new Exception("Error al recuperar profesores", Ex);
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
                SqlCommand cmdProfesores = new SqlCommand("UPDATE PERSONAS set nombre = @nombre, apellido = @apellido, " +
                    "direccion = @direccion, email = @email, telefono = @telefono , fecha_nac = @fechanac, legajo = @legajo, tipo_persona = @tipopersona, id_plan = @idplan where id_persona = @id "
                    , SqlConn);
                cmdProfesores.Parameters.Add("@id", SqlDbType.Int).Value = psr.ID;
                cmdProfesores.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = psr.Nombre;
                cmdProfesores.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = psr.Apellido;
                cmdProfesores.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = psr.Direccion;
                cmdProfesores.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = psr.Email;
                cmdProfesores.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = psr.Telefono;
                cmdProfesores.Parameters.Add("@fechanac", SqlDbType.DateTime).Value = psr.FechaNacimiento;
                cmdProfesores.Parameters.Add("@legajo", SqlDbType.Int).Value = psr.Legajo;
                cmdProfesores.Parameters.Add("@tipopersona", SqlDbType.Int).Value = psr.TipoPersona;
                cmdProfesores.Parameters.Add("@idplan", SqlDbType.Int).Value = psr.IDPlan;
                cmdProfesores.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar profesor", Ex);
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
                SqlCommand cmdProfesores = new SqlCommand("INSERT INTO PERSONAS(nombre,apellido,direccion,email,telefono,fecha_nac,legajo,tipo_persona,id_plan)" +
                    "values (@nombre,@apellido,@direccion,@email,@telefono,@fechanac,@legajo,@tipopersona,@idplan)", SqlConn);
                cmdProfesores.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = psr.Nombre;
                cmdProfesores.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = psr.Apellido;
                cmdProfesores.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = psr.Direccion;
                cmdProfesores.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = psr.Email;
                cmdProfesores.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = psr.Telefono;
                cmdProfesores.Parameters.Add("@fechanac", SqlDbType.DateTime).Value = psr.FechaNacimiento;
                cmdProfesores.Parameters.Add("@legajo", SqlDbType.Int).Value = psr.Legajo;
                cmdProfesores.Parameters.Add("@tipopersona", SqlDbType.Int).Value = 1;
                cmdProfesores.Parameters.Add("@idplan", SqlDbType.Int).Value = psr.IDPlan;
                cmdProfesores.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al agregar profesor", Ex);
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
