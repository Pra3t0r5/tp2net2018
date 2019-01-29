using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class LoginLogic
    {
        public enum Errores {OK,Habilitado,NoHabilitado,ErrorDatos}
        LoginAdapter LoginData = new LoginAdapter();

        private Usuario usuario { get; set; }

        public LoginLogic()
        {
            this.LoginData = new LoginAdapter();
            this.usuario = new Usuario();
        }

        public Usuario ValidateUser(string nombre,string clave)
        {
            usuario = this.LoginData.ValidateUser(nombre,clave);
            return usuario;
        }
        
            
    }
}
