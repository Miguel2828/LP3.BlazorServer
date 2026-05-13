namespace LP3.BlazorServer.Shared.DTOs;

public class EstudianteDto
{
    public int Id { get; set; }
    public string NombreCompleto { get; set; } = string.Empty;
    public string NumeroDocumento { get; set; } = string.Empty;
    public string TipoDocumento { get; set; } = string.Empty;
    public DateTime FechaNacimiento { get; set; }
    public string Estado { get; set; } = string.Empty;
    public int TotalCursosMatriculados { get; set; }
}   