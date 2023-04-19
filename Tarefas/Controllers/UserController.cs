using Microsoft.AspNetCore.Mvc;
using Tarefas.Interfaces;
using Tarefas.Models;
using Tarefas.Repository;

namespace Tarefas.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _iUserRepository;

        public UserController(IUserRepository iUserRepository)
        {
            _iUserRepository = iUserRepository;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            _iUserRepository.AddUser(user);
            return RedirectToAction("Login", "Login");

        }


    }
}
