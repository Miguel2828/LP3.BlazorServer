using LP3.BlazorServer.Domain.Entidades;
using LP3.BlazorServer.Domain.Enums;
using LP3.BlazorServer.Shared.DTOs;

namespace MiProyectoAcademico.Shared.Extensions;

public static class EstudianteExtensions
{
    public static EstudianteDto ToDto(this Estudiante estudiante)
    {
        return new EstudianteDto
        {
            Id = estudiante.Id,
            NombreCompleto = $"{estudiante.Nombre} {estudiante.Apellido}",
            NumeroDocumento = estudiante.NumeroDocumento,
            TipoDocumento = estudiante.TipoDocumento.ToString(),
            FechaNacimiento = estudiante.FechaNacimiento,
            Estado = estudiante.Estado.ToString(),
            TotalCursosMatriculados = estudiante.Matriculaciones.Count(m => m.Activa)
        };
    }
}   