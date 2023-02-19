using Microsoft.EntityFrameworkCore;
using StarChart.Data.Models;

namespace StarChart.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CelestialObject> CelestialObjects { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {


        }

    }
}

