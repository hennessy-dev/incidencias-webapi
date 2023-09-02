namespace Dominio;
public class Ciudad
{
    public int IdCiudad { get; set; }
    public string NombreCiudad { get; set; }
    public string IdDepartamentoFk { get; set; }
    public Departamento Departamento { get; set; }
    public ICollection<Persona> Personas { get; set; }
}