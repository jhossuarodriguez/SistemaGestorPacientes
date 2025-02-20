using Microsoft.AspNetCore.Mvc;
using SistemaGestorPacientes.Core.Application.Interfaces;
using SistemaGestorPacientes.Core.Domain.Entities;

namespace SistemaGestorPacientes.WebApp.Controllers
{
    public class ConsultorioController : Controller
    {
        private readonly IConsultorioService _consultorioService;

        public ConsultorioController(IConsultorioService consultorioService)
        {
            _consultorioService = consultorioService;
        }

        public async Task<IActionResult> Index()
        {
            var consultorios = await _consultorioService.ObtenerTodos();
            return View(consultorios);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Consultorio consultorio)
        {
            if (ModelState.IsValid)
            {
                await _consultorioService.Agregar(consultorio);
                return RedirectToAction("Index");
            }
            return View(consultorio);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var consultorio = await _consultorioService.ObtenerPorId(id);
            if (consultorio == null) return NotFound();
            return View(consultorio);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Consultorio consultorio)
        {
            if (ModelState.IsValid)
            {
                await _consultorioService.Actualizar(consultorio);
                return RedirectToAction("Index");
            }
            return View(consultorio);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var consultorio = await _consultorioService.ObtenerPorId(id);
            if (consultorio == null) return NotFound();
            return View(consultorio);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _consultorioService.Eliminar(id);
            return RedirectToAction("Index");
        }
    }
}
