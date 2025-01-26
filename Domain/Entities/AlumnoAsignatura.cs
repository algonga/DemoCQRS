

namespace Domain.Entities;

public sealed class AlumnoAsignatura
{
    public Guid AlumnoId { get; set; }
    public Alumno Alumno { get; set; }

    public Guid AsignaturaId { get; set; }
    public Asignatura Asignatura{ get; set; }

    public float Nota { get; set; }
}
