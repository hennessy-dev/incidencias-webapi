namespace Dominio;

public class Persona
{
    public string IdPersona { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int IdGeneroFk { get; set; }
    public Genero Genero { get; set; }
    public int IdCiudadFk { get; set; }
    public Ciudad Ciudad { get; set; }
    public int IdTipoPersonaFk { get; set; }
    public TipoPersona TipoPersona { get; set; }
    public ICollection<TrainerSalon> TrainerSalones { get; set; }
    public ICollection<Matricula> Matriculas { get; set; }
    public string Direccion { get; set; }
}
