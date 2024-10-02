using Microsoft.EntityFrameworkCore;
using SportTrackerAPI.Models;

namespace SportTrackerAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Activity> Activities { get; set; }
    }
}
