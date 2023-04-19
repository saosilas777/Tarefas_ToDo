namespace Tarefas.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public LoginModel(int id, string nome, string senha)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
        }

        public LoginModel()
        {
        }
    }
}
