using SistemaGestorPacientes.Core.Application.Interfaces;
using SistemaGestorPacientes.Core.Domain.Entities;
using SistemaGestorPacientes.Core.Application.Interfaces.Repositories;


namespace SistemaGestorPacientes.Core.Application.Services
{
    public class CitaService : ICitaService
    {
        private readonly ICitaRepository _citaRepository;

        public CitaService(ICitaRepository citaRepository)
        {
            _citaRepository = citaRepository;
        }

        public async Task<IEnumerable<Cita>> ObtenerTodos() => await _citaRepository.ObtenerTodos();
        public async Task<Cita> ObtenerPorId(int id) => await _citaRepository.ObtenerPorId(id);
        public async Task Agregar(Cita cita) => await _citaRepository.Agregar(cita);
        public async Task Actualizar(Cita cita) => await _citaRepository.Actualizar(cita);
        public async Task Eliminar(int id) => await _citaRepository.Eliminar(id);

    }
}
