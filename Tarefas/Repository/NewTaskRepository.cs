using Microsoft.AspNetCore.Mvc;
using Tarefas.Data;
using Tarefas.Interfaces;
using Tarefas.Models;

namespace Tarefas.Repository
{
    public class NewTaskRepository : INewTaskRepository
    {
        private readonly Context _context;

        public NewTaskRepository(Context context)
        {
            _context = context;
        }

        public NewTask Add(NewTask task)
        {
            _context.Add(task);
            _context.SaveChanges();
            return task;
        }

        public List<NewTask> GetAll()
        {
            return _context.Tasks.ToList();
        }

        public NewTask GetById(int id)
        {
            try
            {
                NewTask task = _context.Tasks.FirstOrDefault(x => x.Id == id);
                if(task != null)
                {
                    return task;
                }
                return new NewTask();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            
            
        }

        public bool Remove(int id)
        {
            NewTask task = GetById(id);

            if (task == null) throw new Exception("Nenhum dado encontrado");

            _context.Tasks.Remove(task);
            _context.SaveChanges();

            return true;
            
        }
    }
}
