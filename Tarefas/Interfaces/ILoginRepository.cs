using Tarefas.Models;

namespace Tarefas.Interfaces
{
    public interface ILoginRepository
    {
        public bool NewLogin(User user);
    }
}
