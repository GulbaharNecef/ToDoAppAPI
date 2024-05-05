using Microsoft.EntityFrameworkCore;

namespace ToDoAppAPI
{
    public class TodoDb:DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options): base(options)
        {
            
        }

        //public DbSet<Todo> Todos { get; set; }
        public DbSet<Todo> Todos => Set<Todo>();
    }
}
