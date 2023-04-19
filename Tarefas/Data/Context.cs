using Microsoft.EntityFrameworkCore;
using Tarefas.Models;

namespace Tarefas.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<NewTask> Tasks { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<LoginModel> Login { get; set; } = default!;
    }
}
