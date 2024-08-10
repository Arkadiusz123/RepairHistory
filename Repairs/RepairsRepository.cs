using Microsoft.EntityFrameworkCore;
using RepairHistory.Database;

namespace RepairHistory.Repairs
{
    public interface IRepairsRepository
    {
        Task<IEnumerable<RepairTableVm>> GetTableListAsync(int carId);
        Task AddRepairAsync(Repair repair);
        Task EditRepairAsync(Repair repair);
        Task<bool> ExistsWithIdAsync(int id);
        Task<Repair> GetByIdAsync(int id);
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

        public async Task<IEnumerable<RepairTableVm>> GetTableListAsync(int carId)
        {
            var query = _dbSet
                .Where(x => x.CarId == carId)
                .OrderByDescending(x => x.Date)
                .ThenByDescending(x => x.RepairId)
                .Select(x => new RepairTableVm 
                {
                    Id = x.RepairId,
                    Date = x.Date,
                    Mileage = x.Mileage
                });

            return await query.ToListAsync();
        }

        public async Task<bool> ExistsWithIdAsync(int id)
        {
            return await _dbSet.AnyAsync(x => x.RepairId == id);
        }

        public async Task<Repair> GetByIdAsync(int id)
        {
            return await _dbSet
                .AsNoTracking()
                .Include(x => x.PartRepairs)
                .ThenInclude(x => x.Part)
                .SingleOrDefaultAsync(x => x.RepairId == id);
        }

        public async Task AddRepairAsync(Repair repair)
        {
            _dbSet .Add(repair);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditRepairAsync(Repair repair)
        {
            var repairDb = await _dbSet
                .Include(x => x.PartRepairs)
                .SingleAsync(x => x.RepairId == repair.RepairId);

            repairDb.Date = repair.Date;
            repairDb.Mileage = repair.Mileage;
            repairDb.Description = repair.Description;

            repairDb.PartRepairs.Clear();
            repairDb.PartRepairs = repair.PartRepairs;

            await _dbContext.SaveChangesAsync();
        }
    }
}
