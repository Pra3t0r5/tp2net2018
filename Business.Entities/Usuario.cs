using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario:BusinessEntity //Usuario Hereda de bussiness entities
    {
        private string _nombreUsuario;
        private string _clave;
        private string _nombre;
        private string _apellido;
        private string _email;
        private bool _habilitado;

        public string NombreUsuario
        {
            get => _nombreUsuario;
            set => _nombreUsuario = value; }

        public string Clave
        {
            get => _clave;
            set => _clave = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }

        public string EMail
        {
            get => _email;
            set => _email = value;
        }

        public bool Habilitado
        {
            get => _habilitado;
            set => _habilitado = value;
        }

        public bool CambiaClave { get; set; }

        public int? IDPersona { get; set; }

        public Persona Persona { get; set; }
    }
}
