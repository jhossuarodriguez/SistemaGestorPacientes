using Microsoft.EntityFrameworkCore;
using SistemaGestorPacientes.Core.Domain.Entities;
using SistemaGestorPacientes.Infrastructure.Persistence.Context;

namespace SistemaGestorPacientes.Infrastructure.Persistence.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly AppDbContext _context;

        public PacienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Paciente>> ObtenerTodos() => await _context.Pacientes.ToListAsync();
        public async Task<Paciente> ObtenerPorId(int id) => await _context.Pacientes.FindAsync(id);
        public async Task Agregar(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            await _context.SaveChangesAsync();
        }
    }
}
