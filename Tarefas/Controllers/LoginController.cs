using Microsoft.AspNetCore.Mvc;
using Tarefas.Interfaces;
using Tarefas.Models;
using Tarefas.Repository;

namespace Tarefas.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginRepository _loginRepository;

        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewLogin(User user)
        {
            bool teste = _loginRepository.NewLogin(user);

            if (teste != false)
            {
                return RedirectToAction("Index", "Home");

            }
            return View("Login", "Login");
        }




    }
}
