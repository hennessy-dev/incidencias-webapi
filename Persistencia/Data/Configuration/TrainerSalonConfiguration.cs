using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace Persistencia.Data.Configuration
{
    public class TrainerSalonConfiguration : IEntityTypeConfiguration<TrainerSalon>
    {
        public void Configure(EntityTypeBuilder<TrainerSalon> builder)
        {
            builder.ToTable("trainersalon");

            builder.Property(e => e.IdPersonaTrainerFk)
            .HasMaxLength(20);

            builder.Property(e => e.IdSalonFk)
            .HasColumnType("int");

            builder.HasOne(e => e.Persona)
            .WithMany(p => p.TrainerSalones)
            .HasForeignKey(e => e.IdPersonaTrainerFk);

            builder.HasOne(e => e.Salon)
            .WithMany(p => p.TrainerSalones)
            .HasForeignKey(p => p.IdSalonFk);
        }
    }
}