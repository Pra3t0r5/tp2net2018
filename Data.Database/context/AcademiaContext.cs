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
        public DbSet<Especialidad> Especialidades { get; set; }

        public DbSet<Plan> Planes { get; set; }

        public AcademiaContext() : base("ConnStringLocal")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EspecialidadMapping());
            modelBuilder.Configurations.Add(new PlanMapping());
        }
    }
}
