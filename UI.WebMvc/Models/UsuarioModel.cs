using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.WebMvc.Models
{
    public class UsuarioModel
    {
        private int _ID;
        private string _nombreUsuario;
        private string _clave;
        private string _nombre;
        private string _apellido;
        private string _email;
        private bool _habilitado;

        public  UsuarioModel(Usuario usuario)
        {
            this.Nombre = usuario.Nombre;
            this.NombreUsuario = usuario.NombreUsuario;
            this.ID = usuario.ID;
            this.Clave = usuario.Clave;
            this.Apellido = usuario.Apellido;
            this.EMail = usuario.EMail;
            this.Habilitado = usuario.Habilitado;
            this.IDPersona = usuario.IDPersona;
        }

        public string NombreUsuario
        {
            get => _nombreUsuario;
            set => _nombreUsuario = value;
        }

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

        public int? IDPersona { get; set; }
        public int ID { get => _ID; set => _ID = value; }
    }
}