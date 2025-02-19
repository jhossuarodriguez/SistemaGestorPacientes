using SistemaGestorPacientes.Core.Application.Interfaces;
using SistemaGestorPacientes.Core.Domain.Entities;
using SistemaGestorPacientes.Core.Application.Interfaces.Repositories;


namespace SistemaGestorPacientes.Core.Application.Services
{
    public class MedicoService : IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoService(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        public async Task<IEnumerable<Medico>> ObtenerTodos() => await _medicoRepository.ObtenerTodos();
        public async Task<Medico> ObtenerPorId(int id) => await _medicoRepository.ObtenerPorId(id);
        public async Task Agregar(Medico medico) => await _medicoRepository.Agregar(medico);
        public async Task Actualizar(Medico medico) => await _medicoRepository.Actualizar(medico);
        public async Task Eliminar(int id) => await _medicoRepository.Eliminar(id);

    }
}
