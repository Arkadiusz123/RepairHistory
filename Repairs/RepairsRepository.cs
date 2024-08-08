using Microsoft.EntityFrameworkCore;
using RepairHistory.Database;

namespace RepairHistory.Repairs
{
    public interface IRepairsRepository
    {
        Task<IEnumerable<RepairTableVm>> GetTableList(int carId);
    }

    public class RepairsRepository : IRepairsRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly DbSet<Repair> _dbSet;

        public RepairsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Repairs;
        }

        public async Task<IEnumerable<RepairTableVm>> GetTableList(int carId)
        {
            var query = _dbSet
                .Where(x => x.CarId == carId)
                .OrderByDescending(x => x.Date)
                .ThenByDescending(x => x.RepairId)
                .Select(x => new RepairTableVm 
                {
                    Id = x.CarId,
                    Date = x.Date,
                    Mileage = x.Mileage
                });

            return await query.ToListAsync();
        }
    }
}
