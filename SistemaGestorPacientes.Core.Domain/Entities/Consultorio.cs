namespace SistemaGestorPacientes.Core.Domain.Entities
{
    public class Consultorio
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public ICollection<Paciente> Pacientes { get; set; } = new List<Paciente>();
        public ICollection<Medico> Medicos { get; set; } = new List<Medico>();
    }
}
