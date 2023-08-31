namespace Dominio.Entities;

public class Persona
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int IdGeneroFk { get; set; }
    public int IdCiudadFk { get; set; }
    public int IdTipoPersonaFk { get; set; }
    public string Direccion { get; set; }
}
