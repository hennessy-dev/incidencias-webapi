namespace Dominio;
public class Departamento
{
    public string IdDepartamento { get; set; }
    public string NombreDepartamento { get; set; }
    public string IdPaisFk { get; set; }
    public Pais Pais { get; set; }
    public ICollection<Ciudad> Ciudades { get; set;}
}