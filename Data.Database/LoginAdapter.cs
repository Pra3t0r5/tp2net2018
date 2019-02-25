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
                SqlCommand cmdLogin = new SqlCommand("select * from usuarios u inner join personas p on p.id_persona = u.id_persona where nombre_usuario = @nombre and clave = @clave",SqlConn);
                cmdLogin.Parameters.Add("@nombre",SqlDbType.VarChar,50).Value = usuario;
                cmdLogin.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = pw;
                SqlDataReader drLogin = cmdLogin.ExecuteReader();
                  if(drLogin.Read())
                  {

                    usr.ID = (int)drLogin["id_usuario"];
                    usr.NombreUsuario = (string)drLogin["nombre_usuario"];
                    usr.Habilitado = (bool)drLogin["habilitado"];
                    usr.Nombre = (string)drLogin["nombre"];
                    usr.Apellido = (string)drLogin["apellido"];
                    if (drLogin["email"] != DBNull.Value)
                    {
                        usr.EMail = (string)drLogin["email"];
                    }
                    else
                    {
                        usr.EMail = null;
                    }
                    usr.IDPersona = (int)drLogin["id_persona"];
                    usr.TipoPersona = (int)drLogin["tipo_persona"];
              
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
