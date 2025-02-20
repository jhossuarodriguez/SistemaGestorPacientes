using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaGestorPacientes.Core.Application.Interfaces;
using SistemaGestorPacientes.Core.Application.Services;
using SistemaGestorPacientes.Core.Domain.Entities;


namespace SistemaGestorPacientes.WebApp.Controllers
{
    public class CitaController : Controller
    {
        private readonly ICitaService _citaService;
        private readonly IMedicoService _medicoService;
        private readonly IPacienteService _pacienteService;

        public CitaController(ICitaService citaService, IMedicoService medicoService, IPacienteService pacienteService)
        {
            _citaService = citaService;
            _medicoService = medicoService;
            _pacienteService = pacienteService;
        }
        public async Task<IActionResult> Index()
        {
           var citas = await _citaService.ObtenerTodos();
            return View(citas);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Medicos = new SelectList(await _medicoService.ObtenerTodos(), "Id", "Nombre");
            ViewBag.Pacientes = new SelectList(await _pacienteService.ObtenerTodos(), "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cita cita)
        {
            if (ModelState.IsValid)
            {
                await _citaService.Agregar(cita);
                return RedirectToAction("Index");
            }
            ViewBag.Medicos = new SelectList(await _medicoService.ObtenerTodos(), "Id", "Nombre");
            ViewBag.Pacientes = new SelectList(await _pacienteService.ObtenerTodos(), "Id", "Nombre");
            return View(cita);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var paciente = await _citaService.ObtenerPorId(id);
            if (paciente == null) return NotFound();
            return View(paciente);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Cita cita)
        {
            if (ModelState.IsValid)
            {
                await _citaService.Actualizar(cita);
                return RedirectToAction("Index");
            }
            return View(cita);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var paciente = await _citaService.ObtenerPorId(id);
            if (paciente == null) return NotFound();
            return View(paciente);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _citaService.Eliminar(id);
            return RedirectToAction("Index");
        }
    }
}
