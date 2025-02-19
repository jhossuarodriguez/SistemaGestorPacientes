using Microsoft.EntityFrameworkCore;
using SistemaGestorPacientes.Core.Domain.Entities;
using SistemaGestorPacientes.Infrastructure.Persistence.Context;
using SistemaGestorPacientes.Core.Application.Interfaces.Repositories;

namespace SistemaGestorPacientes.Infrastructure.Persistence.Repositories
{
    public class CitaRepository : ICitaRepository
    {
        private readonly AppDbContext _context;

        public CitaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cita>> ObtenerTodos() => await _context.Citas.ToListAsync();
        public async Task<Cita> ObtenerPorId(int id) => await _context.Citas.FindAsync(id);
        public async Task Agregar(Cita cita)
        {
            _context.Citas.Add(cita);
            await _context.SaveChangesAsync();
        }

        public async Task Actualizar(Cita cita)
        {
            _context.Citas.Update(cita);
            await _context.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var cita = await _context.Citas.FindAsync(id);
            if (cita != null)
            {
                _context.Citas.Remove(cita);
                await _context.SaveChangesAsync();
            }
        }
    }
}
