using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database.context.Mappings
{
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            ToTable("usuarios");
            this.Property(x => x.ID).HasColumnName("id_usuario");
            this.Property(x => x.NombreUsuario).HasColumnName("nombre_usuario");
            this.Property(x => x.Clave).HasColumnName("clave");
            this.Property(x => x.Habilitado).HasColumnName("habilitado");
            this.Property(x => x.Nombre).HasColumnName("nombre");
            this.Property(x => x.Apellido).HasColumnName("apellido");
            this.Property(x => x.EMail).HasColumnName("email");
            this.Property(x => x.CambiaClave).HasColumnName("cambia_clave");
            this.Ignore(x => x.State);
            this.HasOptional(x => x.Persona).WithMany().HasForeignKey(x => x.IDPersona);
        }
    }
}
