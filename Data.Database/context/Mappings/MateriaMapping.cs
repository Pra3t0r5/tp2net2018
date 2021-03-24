using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database.context.Mappings
{
    public class MateriaMapping : EntityTypeConfiguration<Materia>
    {
        public MateriaMapping()
        {
            ToTable("materias");
            Property(x => x.ID).HasColumnName("id_materia");
            Property(x => x.Descripcion).HasColumnName("desc_materia");
            Property(x => x.HSSemanales).HasColumnName("hs_semanales");
            Property(x => x.HSTotales).HasColumnName("hs_totales");
            Property(x => x.IDPlan).HasColumnName("id_plan");
            HasRequired(x => x.Plan).WithMany(x => x.Materias).HasForeignKey(x => x.IDPlan);
            this.Ignore(x => x.State);
        }
    }
}
