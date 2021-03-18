using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database.context.Mappings
{
    public class PersonaMapping : EntityTypeConfiguration<Persona>
    {
        public PersonaMapping()
        {
            ToTable("personas");
            this.Property(x => x.ID).HasColumnName("id_persona");
            this.Property(x => x.Nombre).HasColumnName("nombre");
            this.Property(x => x.Apellido).HasColumnName("apellido");
            this.Property(x => x.Direccion).HasColumnName("direccion");
            this.Property(x => x.Email).HasColumnName("email");
            this.Property(x => x.FechaNacimiento).HasColumnName("fecha_nacimiento");
            this.Property(x => x.Telefono).HasColumnName("telefono");
            this.Property(x => x.TipoPersona).HasColumnName("tipo_persona");
            this.Property(x => x.Legajo).HasColumnName("legajo");
            this.Property(x => x.IDPlan).HasColumnName("id_plan");
            this.Ignore(x => x.State);
            this.HasRequired(x => x.Plan).WithMany().HasForeignKey(x => x.IDPlan);
        }
    }
}
