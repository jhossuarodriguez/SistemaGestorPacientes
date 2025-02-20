using Microsoft.EntityFrameworkCore;
using SistemaGestorPacientes.Core.Domain.Entities;
using SistemaGestorPacientes.Infrastructure.Persistence.Context;
using SistemaGestorPacientes.Core.Application.Interfaces.Repositories;

namespace SistemaGestorPacientes.Infrastructure.Persistence.Repositories
{
    public class ConsultorioRepository : IConsultorioRepository
    {
        private readonly AppDbContext _context;

        public ConsultorioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Consultorio>> ObtenerTodos() => await _context.Consultorios.ToListAsync();
        public async Task<Consultorio> ObtenerPorId(int id) => await _context.Consultorios.FindAsync(id);
        public async Task Agregar(Consultorio consultorio)
        {
            _context.Consultorios.Add(consultorio);
            await _context.SaveChangesAsync();
        }

        public async Task Actualizar(Consultorio consultorio)
        {
            _context.Consultorios.Update(consultorio);
            await _context.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var consultorio = await _context.Consultorios.FindAsync(id);
            if (consultorio != null)
            {
                _context.Consultorios.Remove(consultorio);
                await _context.SaveChangesAsync();
            }
        }
    }
}
