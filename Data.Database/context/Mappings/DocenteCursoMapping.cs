using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database.context.Mappings
{
    public class DocenteCursoMapping : EntityTypeConfiguration<DocenteCurso>
    {
        public DocenteCursoMapping()
        {
            ToTable("docente_cursos");
            this.Property(x => x.ID).HasColumnName("id_dictado");
            this.Property(x => x.IDCurso).HasColumnName("id_curso");
            this.Property(x => x.IDDocente).HasColumnName("id_docente");
            this.Property(x => x.Cargo).HasColumnName("cargo");
            HasRequired(x => x.Curso).WithMany().HasForeignKey(x => x.IDCurso);
            HasRequired(x => x.Docente).WithMany().HasForeignKey(x => x.IDDocente);
            this.Ignore(x => x.State);
        }
    }
}
