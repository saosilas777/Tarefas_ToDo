using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using Tarefas.Data;
using Tarefas.Interfaces;
using Tarefas.Models;
using Tarefas.Models.ViewModels;

namespace Tarefas.Controllers
{
    public class HomeController : Controller
    {
        private readonly INewTaskRepository _taskRepository;

        public HomeController(INewTaskRepository repository)
        {
            _taskRepository = repository;
        }

        public IActionResult Index()
        {
            List<NewTask> tasks = _taskRepository.GetAll();
            return View(tasks);
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Deletar(int id)
        {
            NewTask task = _taskRepository.GetById(id);
            return View(task);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(NewTask task)
        {
            _taskRepository.Add(task);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            _taskRepository.Remove(id);
            return RedirectToAction("Index");
        }

        

    }
}