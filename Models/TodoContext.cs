using Microsoft.EntityFrameworkCore;


namespace CodeFirstApproach.Models
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options): base(options)
        {
        }

        public DbSet<TodoItem> TodoItem { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem() { Id = 1, Name = "Meeting with management", IsComplete = true, Description = "In meeting need to discus some points." },
                new TodoItem() { Id = 2, Name = "Go for Shopping", IsComplete = false, Description = "List of the items to buy." },
                new TodoItem() { Id = 3, Name = "Call someone to do some task", IsComplete = true, Description = "Here is task to ask to do on call" });
        }
    }
}
