using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Modulo:BusinessEntity
    {
        //Declaracion Vars
        private string _Descripcion;

        //Getters & Setters
        public string Descripcion
        {
            get => _Descripcion;
            set => _Descripcion = value;
        }
    }
}
