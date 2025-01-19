using System;
using Domain.Primitives;


namespace Domain.Entities;

public sealed class Alumno : Entity
{
    public Alumno(Guid id,string firstName, string lastName, string email, ICollection<AlumnoAsignatura> alumnoAsignaturas) 
        :base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        AlumnoAsignaturas = alumnoAsignaturas;
    }

    private Alumno() 
    {
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public ICollection<AlumnoAsignatura> AlumnoAsignaturas { get; set; }
}
