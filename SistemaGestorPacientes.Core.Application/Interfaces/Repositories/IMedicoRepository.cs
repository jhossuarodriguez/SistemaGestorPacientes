using SistemaGestorPacientes.Core.Domain.Entities;

namespace SistemaGestorPacientes.Core.Application.Interfaces.Repositories
{
    public interface IMedicoRepository
    {
        Task<IEnumerable<Medico>> ObtenerTodos();
        Task<Medico> ObtenerPorId(int id);
        Task Agregar(Medico medico);
        Task Actualizar(Medico medico);
        Task Eliminar(int id);
    }
}
