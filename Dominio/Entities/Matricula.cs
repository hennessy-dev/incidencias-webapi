namespace Dominio;
public class Matricula
{
    public int IdMatricula { get; set; }
    public int IdPersonaFk { get; set; }
    public Persona Përsona { get; set; }
    public int IdSalonFk { get; set; }
    public Salon Salon { get; set; }
}