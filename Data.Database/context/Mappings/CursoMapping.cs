using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database.context.Mappings
{
    public class CursoMapping : EntityTypeConfiguration<Curso>
    {
        public CursoMapping()
        {
            this.Property(x => x.ID).HasColumnName("id_curso");
            this.Property(x => x.Cupo).HasColumnName("cupo");
            this.Property(x => x.Descripcion).HasColumnName("desc_curso");
            this.Property(x => x.AnioCalendario).HasColumnName("anio_calendario");
            this.Property(x => x.IDComision).HasColumnName("id_comision");
            this.Property(x => x.IDMateria).HasColumnName("id_materia");
            this.HasRequired(x => x.Materia).WithMany().HasForeignKey(x => x.IDMateria);
            this.HasRequired(x => x.Comision).WithMany().HasForeignKey(x => x.IDComision);
            this.Ignore(x => x.State);
        }
    }
}
