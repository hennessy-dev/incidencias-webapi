using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace Persistencia.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("persona");

            builder.HasKey(e => e.IdPersona);
            builder.Property(e => e.IdPersona)
            .HasMaxLength(20);

            builder.Property(e => e.Nombre)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(e => e.Genero)
            .WithMany(p => p.Personas)
            .HasForeignKey(e => e.IdGeneroFk);

            builder.HasOne(p => p.Ciudad)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdCiudadFk);

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdTipoPersonaFk);
        }
    }
}