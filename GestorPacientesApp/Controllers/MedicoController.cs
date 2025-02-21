using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaGestorPacientes.Core.Application.Interfaces;
using SistemaGestorPacientes.Core.Domain.Entities;

namespace SistemaGestorPacientes.WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MedicoController : Controller
    {
        private readonly IMedicoService _medicoService;
        private readonly IConsultorioService _consultorioService;

        public MedicoController(IMedicoService medicoService, IConsultorioService consultorioService)
        {
            _medicoService = medicoService;
            _consultorioService = consultorioService;
        }

        public async Task<IActionResult> Index()
        {
            var medicos = await _medicoService.ObtenerTodos();
            return View(medicos);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Consultorios = new SelectList(await _consultorioService.ObtenerTodos(), "Id", "Nombre");
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(Medico medico)
        {

            if (ModelState.IsValid)
            {
                await _medicoService.Agregar(medico);
                return RedirectToAction("Index");
            }

            ViewBag.Consultorios = new SelectList(await _consultorioService.ObtenerTodos(), "Id", "Nombre");
            return View(medico);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var medico = await _medicoService.ObtenerPorId(id);
            if (medico == null) return NotFound();

            ViewBag.Consultorios = new SelectList(await _consultorioService.ObtenerTodos(), "Id", "Nombre");
            return View(medico);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Medico medico)
        {
            if (ModelState.IsValid)
            {
                await _medicoService.Actualizar(medico);
                return RedirectToAction("Index");
            }
            return View(medico);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var medico = await _medicoService.ObtenerPorId(id);
            if (medico == null) return NotFound();
            return View(medico);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _medicoService.Eliminar(id);
            return RedirectToAction("Index");
        }

    }
}
