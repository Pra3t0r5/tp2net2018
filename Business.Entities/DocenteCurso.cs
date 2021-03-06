﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        //private TiposCargos Cargos;
        private int _IDCurso;
        private int _IDDocente;

        public int IDCurso
        {
            get => _IDCurso;
            set => _IDCurso = value;
        }

        public int IDDocente
        {
            get => _IDDocente;
            set => _IDDocente = value;
        }

        public Persona Docente { get; set; }

        public Curso Curso { get; set; }

        public int Cargo { get; set; }
    }
}
