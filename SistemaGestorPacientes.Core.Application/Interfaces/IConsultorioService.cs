using SistemaGestorPacientes.Core.Domain.Entities;

namespace SistemaGestorPacientes.Core.Application.Interfaces
{
    public interface IConsultorioService
    {
        Task<IEnumerable<Consultorio>> ObtenerTodos();
        Task<Consultorio> ObtenerPorId(int id);
        Task Agregar(Consultorio consultorio);
        Task Actualizar(Consultorio consultorio);
        Task Eliminar(int id);
    }
}
