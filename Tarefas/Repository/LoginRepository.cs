using Tarefas.Data;
using Tarefas.Interfaces;
using Tarefas.Models;

namespace Tarefas.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private Context _context;


        public LoginRepository(Context context)
        {
            _context = context;
        }

        public bool NewLogin(User user)
        {
            User _user = _context.Users.FirstOrDefault(x => x.UserName == user.UserName);

            if (_user.Password == user.Password && _user.UserName == user.UserName)
            {
                return true;
            }
            return false;

        }

    }
}
