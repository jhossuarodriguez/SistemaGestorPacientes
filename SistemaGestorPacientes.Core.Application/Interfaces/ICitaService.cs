using SistemaGestorPacientes.Core.Domain.Entities;

namespace SistemaGestorPacientes.Core.Application.Interfaces
{
    public interface ICitaService
    {
        Task<IEnumerable<Cita>> ObtenerTodos();
        Task<Cita> ObtenerPorId(int id);
        Task Agregar(Cita cita);
        Task Actualizar(Cita cita);
        Task Eliminar(int id);
    }
}
