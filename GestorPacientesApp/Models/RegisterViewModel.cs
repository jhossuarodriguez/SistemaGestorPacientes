﻿
using System.ComponentModel.DataAnnotations;

namespace SistemaGestorPacientes.WebApp.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Apellido { get; set; }

        [Required, EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? UserName { get; set; }

        [Required]
        public int ConsultorioId { get; set; }

        [Required, DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required, DataType(DataType.Password), Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
        public string? ConfirmPassword { get; set; }
    }
}

