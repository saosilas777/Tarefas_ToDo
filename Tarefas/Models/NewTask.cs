namespace Tarefas.Models
{
    public class NewTask
    {
        public int Id { get; set; }
        public string Tarefa { get; set; }
        public NewTask(string task)
        {
            Tarefa = task;
        }

        public NewTask()
        {
        }
    }
}
