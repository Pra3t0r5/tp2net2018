using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database.context.Mappings
{
    public class PlanMapping : EntityTypeConfiguration<Plan>
    {
        public PlanMapping()
        {
            this.ToTable("planes");
            this.Property(x => x.ID).HasColumnName("id_plan");
            this.Property(x => x.Descripcion).HasColumnName("desc_plan").IsRequired();
            this.Property(x => x.IDEspecialidad).HasColumnName("id_especialidad");
            this.HasRequired(x => x.Especialidad).WithMany(y => y.Planes)
                .HasForeignKey(f => f.IDEspecialidad);
            this.Ignore(x => x.State);
        }
    }
}
