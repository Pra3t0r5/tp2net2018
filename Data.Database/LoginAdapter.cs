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
    public class LoginAdapter : Adapter
    {
        public Usuario ValidateUser(string usuario, string pw)
        {
            Usuario usr = new Usuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdLogin = new SqlCommand("select * from usuarios where nombre_usuario = @nombre and clave = @clave",SqlConn);
                cmdLogin.Parameters.Add("@nombre",SqlDbType.VarChar,50).Value = usuario;
                cmdLogin.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = pw;
                SqlDataReader drLogin = cmdLogin.ExecuteReader();
                  if(drLogin.Read())
                  {

                    usr.NombreUsuario = (string)drLogin["nombre_usuario"];
                      usr.Habilitado = (bool)drLogin["habilitado"];
                      
                      
                  }
                drLogin.Close();
                return usr;
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al validar usuario",ex);
                throw ExcepcionManejada;


            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
