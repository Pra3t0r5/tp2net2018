using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Plan:BusinessEntity
    {
        private string _Descripcion;
        private int _IDEspecialdad;

        public string Descripcion
        {
            get => _Descripcion;
            set => _Descripcion = value;
        }

        public int IDEspecialdad
        {
            get => _IDEspecialdad;
            set => _IDEspecialdad = value;
        }

        #region Propiedades de otras tablas
            public string DescripcionEspecialidad { get; set; }
        #endregion
    }
}
