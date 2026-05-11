namespace LP3.BlazorServer.Domain.Entidades;
using Enums;
public class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string NumeroDocumento { get; set; } = string.Empty;
    public TipoDocumento TipoDocumento { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public EstadoEstudiante Estado { get; set; }
    
    // Colección de matriculaciones
    public ICollection<Matriculacion> Matriculaciones { get; set; } = new List<Matriculacion>();
}   