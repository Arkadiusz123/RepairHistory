using Microsoft.EntityFrameworkCore;
using RepairHistory.Cars;
using RepairHistory.Parts;
using RepairHistory.Repairs;

namespace RepairHistory.Database
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=localdatabase.db");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<PartRepair> PartRepairs { get; set; }
    }
}
