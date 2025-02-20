using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaGestorPacientes.Core.Application.Interfaces;
using SistemaGestorPacientes.Core.Domain.Entities;


namespace SistemaGestorPacientes.WebApp.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPacienteService _pacienteService;
        private readonly IConsultorioService _consultorioService;

        public PacienteController(IPacienteService pacienteService, IConsultorioService consultorioService)
        {
            _pacienteService = pacienteService;
            _consultorioService = consultorioService;
        }

        public async Task<IActionResult> Index()
        {
            var pacientes = await _pacienteService.ObtenerTodos();
            return View(pacientes);
        }

        public async Task<IActionResult> Create() 
        {

            ViewBag.Consultorios = new SelectList(await _consultorioService.ObtenerTodos(), "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Paciente paciente, IFormFile imagen)
        {
            if (imagen != null && imagen.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(imagen.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imagen.CopyToAsync(stream);
                }

                paciente.Foto = fileName;
            }

            if (ModelState.IsValid)
            {
                await _pacienteService.Agregar(paciente);
                return RedirectToAction("Index");
            }

            ViewBag.Consultorios = new SelectList(await _consultorioService.ObtenerTodos(), "Id", "Nombre");
            return View(paciente);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var paciente = await _pacienteService.ObtenerPorId(id);
            if (paciente == null) return NotFound();
            return View(paciente);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                await _pacienteService.Actualizar(paciente);
                return RedirectToAction("Index");
            }
            return View(paciente);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var paciente = await _pacienteService.ObtenerPorId(id);
            if (paciente == null) return NotFound();
            return View(paciente);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _pacienteService.Eliminar(id);
            return RedirectToAction("Index");
        }
    }
}
