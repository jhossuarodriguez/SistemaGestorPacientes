using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaGestorPacientes.Core.Application.Interfaces;
using SistemaGestorPacientes.Core.Domain.Entities;

namespace SistemaGestorPacientes.WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MedicoController : Controller
    {
        private readonly IMedicoService _medicoService;

        public MedicoController(IMedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        public async Task<IActionResult> Index()
        {
            var medicos = await _medicoService.ObtenerTodos();
            return View(medicos);
        }

        public IActionResult Crear() => View();

        [HttpPost]
        public async Task<IActionResult> Crear(Medico medico)
        {
            if (!ModelState.IsValid) return View(medico);

            await _medicoService.Agregar(medico);
            return RedirectToAction(nameof(Index));
        }
    }
}
