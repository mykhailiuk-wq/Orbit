using Microsoft.EntityFrameworkCore;
namespace Orbit.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options){}

        public DbSet<User> Users { get; set; }
    }
}