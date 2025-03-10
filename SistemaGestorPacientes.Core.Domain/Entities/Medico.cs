﻿
namespace SistemaGestorPacientes.Core.Domain.Entities
{
    public class Medico
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Cedula { get; set; }

        public string? Especialidad { get; set; }
        public string? Telefono { get; set; }
        public int ConsultorioId { get; set; }
        public Consultorio? Consultorio { get; set; }
        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}
