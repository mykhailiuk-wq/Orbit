using Microsoft.EntityFrameworkCore;
namespace Orbit.Models
{
    public class UserTaskContext : DbContext
    {
        public UserTaskContext(DbContextOptions<UserTaskContext> options) : base(options) { }

        public DbSet<UserTask> Tasks { get; set; }
    }
}