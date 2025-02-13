using SistemaGestorPacientes.Core.Domain.Entities;

namespace SistemaGestorPacientes.Core.Application.Interfaces
{
    public interface IMedicoService
    {
        Task<IEnumerable<Medico>> ObtenerTodos();
        Task<Medico> ObtenerPorId(int id);
        Task Agregar(Medico medico);
        Task Actualizar(Medico medico);
        Task Eliminar(int id);
    }
}
