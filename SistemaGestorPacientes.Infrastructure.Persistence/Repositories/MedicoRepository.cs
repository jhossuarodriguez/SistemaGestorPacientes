using Microsoft.EntityFrameworkCore;
using SistemaGestorPacientes.Core.Domain.Entities;
using SistemaGestorPacientes.Infrastructure.Persistence.Context;
using SistemaGestorPacientes.Core.Application.Interfaces.Repositories;

namespace SistemaGestorPacientes.Infrastructure.Persistence.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly AppDbContext _context;

        public MedicoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Medico>> ObtenerTodos() => await _context.Medicos.ToListAsync();
        public async Task<Medico> ObtenerPorId(int id) => await _context.Medicos.FindAsync(id);
        public async Task Agregar(Medico medico)
        {
            _context.Medicos.Add(medico);
            await _context.SaveChangesAsync();
        }

        public async Task Actualizar(Medico medico)
        {
            _context.Medicos.Update(medico);
            await _context.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var medico = await _context.Medicos.FindAsync(id);
            if (medico != null)
            {
                _context.Medicos.Remove(medico);
                await _context.SaveChangesAsync();
            }
        }
    }
}
