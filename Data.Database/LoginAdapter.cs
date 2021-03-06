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
    public class LoginAdapter : Adapter
    {
        public Usuario ValidateUser(string usuario, string pw)
        {
            using (var context = new AcademiaContext())
            {
                var parametros = $"@NombreUsuario='{usuario}', @Clave='{pw}'";
                return context.Database.SqlQuery<Usuario>($"UsuarioLogin {parametros}").FirstOrDefault();
            }
        }
    }
}
