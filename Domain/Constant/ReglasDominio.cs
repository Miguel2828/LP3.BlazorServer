namespace LP3.BlazorServer.Domain.Constants;

public static class ReglasDominio
{
    public const int LongitudMaximaNombre = 100;
    public const int LongitudMaximaDocumento = 20;
    public const int EdadMinimaMatriculacion = 16;
    
    public const string MensajeEstudianteInactivo = "No se puede matricular un estudiante inactivo.";
    public const string MensajeCursoLleno = "El curso ha alcanzado su capacidad máxima.";
}   