using Microsoft.EntityFrameworkCore;

namespace ExAPI.Models
{
    public class TodoContext : DbContext
    {
        // 데이터 베이스 컨텍스트
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options) 
        { 
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
