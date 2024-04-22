using ClientesMvc.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClientesMvc.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        // Add-Migration "Initial Migration"
        // Update-Database
    }
}
