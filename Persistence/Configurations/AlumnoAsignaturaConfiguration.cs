

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Constants;

namespace Persistence.Configurations;

public sealed class AlumnoAsignaturaConfiguration :  IEntityTypeConfiguration<AlumnoAsignatura>
{
    public void Configure(EntityTypeBuilder<AlumnoAsignatura> builder)
    {
        builder.ToTable(TableNames.AlumnoAsignatura);

        builder.HasKey(x => new {x.AlumnoId, x.AsignaturaId});
    }
}
