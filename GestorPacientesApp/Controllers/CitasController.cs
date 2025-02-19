using Microsoft.AspNetCore.Mvc;
using SistemaGestorPacientes.Core.Application.Interfaces;
using SistemaGestorPacientes.Core.Domain.Entities;

namespace GestorPacientesApp.Controllers
{
    public class CitasController : Controller
    {
        private readonly ICitaService _citaService;

        public CitasController(ICitaService citaService)
        {
            _citaService = citaService;
        }
        public async Task<IActionResult> Index()
        {
           var citas = await _citaService.ObtenerTodos();
            return View(citas);
        }
        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Cita cita)
        {
            if (ModelState.IsValid)
            {
                await _citaService.Agregar(cita);
                return RedirectToAction("Index");
            }
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
