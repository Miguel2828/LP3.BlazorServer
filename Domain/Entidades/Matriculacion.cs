namespace LP3.BlazorServer.Domain.Entidades;

public class Matriculacion
{
    public int Id { get; set; }
    public int EstudianteId { get; set; }
    public int CursoId { get; set; }
    public DateTime FechaMatriculacion { get; set; }
    public bool Activa { get; set; }

    // Navegaciones
    public Estudiante Estudiante { get; set; } = default!;
    public Curso Curso { get; set; } = default!;
}   