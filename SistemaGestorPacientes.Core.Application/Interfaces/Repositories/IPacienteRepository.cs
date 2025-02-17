using SistemaGestorPacientes.Core.Domain.Entities;


namespace SistemaGestorPacientes.Core.Application.Interfaces.Repositories
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<Paciente>> ObtenerTodos();
        Task<Paciente> ObtenerPorId(int id);
        Task Agregar(Paciente paciente);
        Task Actualizar(Paciente paciente);
        Task Eliminar(int id);
    }
}
