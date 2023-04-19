using Newtonsoft.Json;
using Tarefas.Helpers;
using Tarefas.Models;

namespace Tarefas.Services
{
    public class AuthService
    {
        public User Authentication(LoginModel login)
        {
            User userModel;

            var Json = JsonConvert.SerializeObject(login);
            //string url = "https://localhost:5001/Authentication";
            string url = "http://192.168.15.100:9999/Authentication";
            var content = HttpHelper.POST(url, Json).Content;

           

            if (!content.Contains("Usuário ou senha inválida"))
            {
                var _userModel = JsonConvert.DeserializeObject<User>(content);
                userModel= new User { UserName = login.Nome  };
                return userModel;
            }
            return new User();
        }
    }
}
