using Microsoft.EntityFrameworkCore;
using StarChart.Data.Models;

namespace StarChart.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<CelestialObject> CelestialObjects { get; set; }
    }

}
