namespace LP3.BlazorServer.Domain.Entidades;

public class Curso
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public int Creditos { get; set; }
    public string Descripcion { get; set; } = string.Empty;
    
    // Colección de matriculaciones
    public ICollection<Matriculacion> Matriculaciones { get; set; } = new List<Matriculacion>();
}   