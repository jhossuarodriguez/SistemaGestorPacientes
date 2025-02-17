
namespace SistemaGestorPacientes.Core.Domain.Entities
{
    public class Paciente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }

        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}
