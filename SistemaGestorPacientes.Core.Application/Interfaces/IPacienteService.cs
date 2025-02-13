using SistemaGestorPacientes.Core.Domain.Entities;

namespace SistemaGestorPacientes.Core.Application.Interfaces
{
    public interface IPacienteService
    {
        Task<IEnumerable<Paciente>> ObtenerTodos();
        Task<Paciente> ObtenerPorId(int id);
        Task Agregar(Paciente paciente);
        Task Actualizar(Paciente paciente);
        Task Eliminar(int id);
    }
}
