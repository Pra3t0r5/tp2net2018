using Business.Entities;
using Data.Database.context.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database.context
{
    public class AcademiaContext : DbContext
    {
        public AcademiaContext() : base("ConnStringLocal")
        {
        
        }        
    }
}
