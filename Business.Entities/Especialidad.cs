﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Especialidad:BusinessEntity
    {
        public string Descripcion { get; set; }

        public ICollection<Plan> Planes { get; set; }
    }
}
