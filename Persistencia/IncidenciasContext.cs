using System.Reflection;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;

public class IncidenciasContext : DbContext
{
    public IncidenciasContext(DbContextOptions<IncidenciasContext> options) : base(options)
    {
    }
    public DbSet<Ciudad> Ciudades { get; set; }
    public DbSet<Departamento> Departamentos { get; set; } 
    public DbSet<Genero> Generos { get; set; } 
    public DbSet<Matricula> Matriculas { get; set; } 
    public DbSet<Pais> Paises { get; set; } 
    public DbSet<Persona> Personas { get; set; } 
    public DbSet<Salon> Salones { get; set; } 
    public DbSet<TrainerSalon> TrainerSalones { get; set; } 
    public DbSet<TipoPersona> TipoPersonas { get; set; } 
    //Linea para activar las configurations
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Usuario>().HasIndex(idx => idx.Username).IsUnique();
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
}
