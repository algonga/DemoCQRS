using System;
using System.Collections.Generic;
using Domain.Primitives;


namespace Domain.Entities;

public sealed class Asignatura : Entity
{
    public Asignatura(Guid id, string name, int cuatrimestre, int creditos, ICollection<AlumnoAsignatura> alumnoAsignaturas)
        : base(id)
    {
        Name = name;
        Cuatrimestre = cuatrimestre;
        Creditos = creditos;
        AlumnoAsignaturas = alumnoAsignaturas;
    }

    private Asignatura() { }

    public string Name { get; set; }
    public int Cuatrimestre { get; set; }
    public int Creditos { get; set; }
    public ICollection<AlumnoAsignatura> AlumnoAsignaturas { get; set; }

}
