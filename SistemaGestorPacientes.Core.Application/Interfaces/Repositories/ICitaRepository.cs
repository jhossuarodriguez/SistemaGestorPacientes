using SistemaGestorPacientes.Core.Domain.Entities;

namespace SistemaGestorPacientes.Core.Application.Interfaces.Repositories
{
    public interface ICitaRepository
    {
        Task<IEnumerable<Cita>> ObtenerTodas();
        Task<Cita> ObtenerPorId(int id);
        Task Agregar(Cita cita);
        Task Actualizar(Cita cita);
        Task Eliminar(int id);
    }
}
