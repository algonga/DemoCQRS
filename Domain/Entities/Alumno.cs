using System;
using System.Diagnostics.Metrics;
using Domain.Primitives;
using Domain.ValueObjects;


namespace Domain.Entities;

public sealed class Alumno : Entity
{
    private Email email;
    private FirstName firstName;
    private LastName lastName;

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

    public Alumno(Guid id, Email email, FirstName firstName, LastName lastName) : base(id)
    {
        this.email = email;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public static Alumno Create(
        Guid id,
        Email email,
        FirstName firstName,
        LastName lastName)
    {
        var alumno = new Alumno(
            id,
            email,
            firstName,
            lastName);

        return alumno;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public ICollection<AlumnoAsignatura> AlumnoAsignaturas { get; set; }
}
