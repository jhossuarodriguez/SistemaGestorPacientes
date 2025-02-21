using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaGestorPacientes.WebApp.Models;
using SistemaGestorPacientes.Core.Application.Interfaces;


namespace SistemaGestorPacientes.WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IConsultorioService _consultorioService;


        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConsultorioService consultorioService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _consultorioService = consultorioService;
        }

        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            if (result.Succeeded)
                return RedirectToAction("Index", "Home");

            ModelState.AddModelError("", "Credenciales incorrectas");
            return View(model);
        }

        public async Task<IActionResult> Register()
        {
            ViewBag.Consultorios = new SelectList(await _consultorioService.ObtenerTodos(), "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = new IdentityUser { UserName = model.Email, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }


            foreach (var error in result.Errors)
                ModelState.AddModelError("", error.Description);

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
