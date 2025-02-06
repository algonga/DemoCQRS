
using Domain.Entities;
using Domain.Repositories;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repository
{
    internal class AlumnoRepository : IAlumnoRepository
    {

        private readonly ApplicationDbContext _dbContext;

        public AlumnoRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public void AddAlumno(Alumno alumno)
        {
            _dbContext.Set<Alumno>().Add(alumno);
        }

        public async Task<Alumno?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Set<Alumno>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<bool> IsEmailUniqueAsync(Email email, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Set<Alumno>().AnyAsync(x => x.Email == email.Value, cancellationToken);
        }
    }
}
