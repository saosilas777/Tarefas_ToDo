using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Models;
using Tarefas.Services;

namespace Tarefas.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly AuthService _authService;


        public AuthenticationController()
        {
            _authService = new AuthService();
        }

        //[AllowAnonymous]
        [HttpPost]
        public IActionResult Auth([FromForm] LoginModel login)
        {
            var response = _authService.Authentication(login);
            if (response.UserName == login.Nome)
                return RedirectToAction("Index", "Home");
            return RedirectToAction("Login", "Login", new { response = "Fail" });

        }



    }
}
