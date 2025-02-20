using SistemaGestorPacientes.Core.Application.Interfaces;
using SistemaGestorPacientes.Core.Domain.Entities;
using SistemaGestorPacientes.Core.Application.Interfaces.Repositories;



namespace SistemaGestorPacientes.Core.Application.Services
{
    public class ConsultorioService : IConsultorioService
    {
        private readonly IConsultorioRepository _consultorioRepository;

        public ConsultorioService(IConsultorioRepository consultorioRepository)
        {
            _consultorioRepository = consultorioRepository;
        }

        public async Task<IEnumerable<Consultorio>> ObtenerTodos() => await _consultorioRepository.ObtenerTodos();
        public async Task<Consultorio> ObtenerPorId(int id) => await _consultorioRepository.ObtenerPorId(id);
        public async Task Agregar(Consultorio consultorio) => await _consultorioRepository.Agregar(consultorio);
        public async Task Actualizar(Consultorio consultorio) => await _consultorioRepository.Actualizar(consultorio);
        public async Task Eliminar(int id) => await _consultorioRepository.Eliminar(id);

    }
}
