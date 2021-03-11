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
    public class AlumnoAdapter: Adapter
    {
        public List<Persona> GetAll()
        {
            using (var context = new AcademiaContext())
            {
                var parametros = "@TipoPersona=2";
                return context.Database.SqlQuery<Persona>($"PersonaGetAll {parametros}").ToList();
            }

        }

        public Persona GetOne(int ID)
        {
            using (var context = new AcademiaContext())
            {
                var parametros = $"@Id={ID}";
                return context.Database.SqlQuery<Persona>($"PersonaGetOne {parametros}").FirstOrDefault();
            }
        }

        public void Delete(int ID)
        {
            using (var context = new AcademiaContext())
            {
                var parametros = $"@Id={ID}";
                context.Database.SqlQuery<Persona>($"PersonaDelete {parametros}").FirstOrDefault();
            }
        }

        protected void Update(Persona psr)
        {
            using (var context = new AcademiaContext())
            {
                var parametros = $"@Id={psr.ID},@Nombre='{psr.Nombre}', @Apellido='{psr.Apellido}', @Direccion='{psr.Direccion}'," +
                    $"@FechaNacimiento={psr.FechaNacimiento}, @Email='{psr.Email}', @Telefono='{psr.Telefono}, @IdPlan={psr.IDPlan}' ";
                context.Database.SqlQuery<Persona>($"PersonaUpdate {parametros}").FirstOrDefault();
            }
        }

        protected void Insert(Persona psr)
        {
            using (var context = new AcademiaContext())
            {
                var parametros = $"@Id={psr.ID},@Nombre='{psr.Nombre}', @Apellido='{psr.Apellido}', @Direccion='{psr.Direccion}'," +
                    $"@FechaNacimiento={psr.FechaNacimiento}, @Email='{psr.Email}', @Telefono='{psr.Telefono}, @IdPlan={psr.IDPlan}', @TipoPersona=2 ";
                context.Database.SqlQuery<Persona>($"PersonaUpdate {parametros}").FirstOrDefault();
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

       

    }
}
