using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database.context.Mappings
{
    public class ComisionMapping : EntityTypeConfiguration<Comision>
    {
        public ComisionMapping()
        {
            this.ToTable("comisiones");
            this.Property(x => x.ID).HasColumnName("id_comision");
            this.Property(x => x.Descripcion).HasColumnName("desc_comision");
            this.Property(x => x.AnioEspecialidad).HasColumnName("anio_especialidad");
            this.Property(x => x.IDPlan).HasColumnName("id_plan");
            this.HasRequired(x => x.Plan).WithMany().HasForeignKey(x => x.IDPlan);
            this.Ignore(x => x.State);
        }
    }
}
