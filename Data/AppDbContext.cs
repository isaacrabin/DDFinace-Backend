using DDFinace_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace DDFinace_Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Policy> Policies { get; set; }
    }
}
