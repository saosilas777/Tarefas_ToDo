using Tarefas.Models;

namespace Tarefas.Interfaces
{
    public interface IUserRepository
    {
        public User AddUser(User user);
        //public User Authentication(User user);
        public User GetById(int id);
        
    }
}
