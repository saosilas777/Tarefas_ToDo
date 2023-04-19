using Tarefas.Models;

namespace Tarefas.Interfaces
{
    public interface INewTaskRepository
    {
        NewTask GetById(int id);
        List<NewTask> GetAll();
        NewTask Add(NewTask task);
        bool Remove(int id);
        
    }
}
