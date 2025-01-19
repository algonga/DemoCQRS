

namespace Domain.Entities;

public sealed class AlumnoAsignatura
{
    public Guid AlumnoId { get; set; }
    public Alumno Alumno { get; set; }

    public Guid CursoId { get; set; }
    public Asignatura Asignatura{ get; set; }

    public float Nota { get; set; }
}
