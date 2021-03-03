using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database.context.Mappings
{
    public class EspecialidadMapping : EntityTypeConfiguration<Especialidad>
    {
        public EspecialidadMapping()
        {
            this.ToTable("especialidades");
            this.HasKey(x => x.ID);
            this.Property(x => x.ID).HasColumnName("id_especialidad");
            this.Property(x => x.Descripcion).HasColumnName("desc_especialidad").IsRequired();
            this.Ignore(x => x.State);
        }
    }
}
