using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Persistence;

public sealed class ApplicationDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public ApplicationDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(Configuration.GetConnectionString("Database"));
    }

    public DbSet<Alumno> Alumno { get; set; }
    public DbSet<Asignatura> Asignatura { get; set; }

    public DbSet<AlumnoAsignatura> AlumnoAsignaturas { get; set; }
}
