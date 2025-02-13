using SistemaGestorPacientes.Core.Domain.Entities;

namespace SistemaGestorPacientes.Core.Application.Interfaces
{
    interface ICitaService
    {
        Task<IEnumerable<Cita>> ObtenerTodas();
        Task<Cita> ObtenerPorId(int id);
        Task Agregar(Cita cita);
        Task Actualizar(Cita cita);
        Task Eliminar(int id);
    }
}
