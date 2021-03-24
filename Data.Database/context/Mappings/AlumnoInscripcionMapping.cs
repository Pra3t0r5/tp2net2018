using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database.context.Mappings
{
    public class AlumnoInscripcionMapping : EntityTypeConfiguration<AlumnoInscripcion>
    {
        public AlumnoInscripcionMapping()
        {
            ToTable("alumno_inscripciones");
            this.Property(x => x.ID).HasColumnName("id_inscripcion");
            this.Property(x => x.IDAlumno).HasColumnName("id_alumno");
            this.Property(x => x.IDCurso).HasColumnName("id_curso");
            this.Property(x => x.Condicion).HasColumnName("condicion");
            this.Property(x => x.Nota).HasColumnName("nota");
            this.HasRequired(x => x.Alumno).WithMany().HasForeignKey(x => x.IDAlumno);
            this.HasRequired(x => x.Curso).WithMany().HasForeignKey(x => x.IDCurso);
        }
    }
}
