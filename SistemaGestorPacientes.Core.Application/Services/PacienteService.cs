using SistemaGestorPacientes.Core.Application.Interfaces;
using SistemaGestorPacientes.Core.Domain.Entities;
using SistemaGestorPacientes.Infrastructure.Persistence.Repositories;


namespace SistemaGestorPacientes.Core.Application.Services
{
    public class PacienteService : IPacienteService
    { 
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public async Task<IEnumerable<Paciente>> ObtenerTodos() => await _pacienteRepository.ObtenerTodos();
        public async Task<Paciente> ObtenerPorId(int id) => await _pacienteRepository.ObtenerPorId(id);
        public async Task Agregar(Paciente paciente) => await _pacienteRepository.Agregar(paciente);
        public async Task Actualizar(Paciente paciente) => await _pacienteRepository.Actualizar(paciente);
        public async Task Eliminar(int id) => await _pacienteRepository.Eliminar(id);

    }
}
