using Microsoft.EntityFrameworkCore;
using RepairHistory.Database;

namespace RepairHistory.Parts
{
    public interface IPartRepository
    {
        Task<IEnumerable<Part>> GetListAsync(PartFilterModel filter);
        Task AddPartAsync(Part part);
        Task<Part> GetByPartNumberAsync(string partNumber);
        Task EditPartAsync(Part part);
        Task DeleteAsync(int id);
        Task<Part> GetByIdAsync(int id);
    }

    public class PartRepository : IPartRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly DbSet<Part> _dbSet;

        public PartRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Parts;
        }

        public async Task<IEnumerable<Part>> GetListAsync(PartFilterModel filter)
        {
            IQueryable<Part> query = _dbSet.AsNoTracking();

            if (!string.IsNullOrEmpty(filter.Number))
                query = query.Where(x => x.PartNumber.ToLower().Contains(filter.Number));

            if (!string.IsNullOrEmpty(filter.Description))
                query = query.Where(x => x.Description.ToLower().Contains(filter.Description));

            var result = await query.ToListAsync();
            return result;
        }

        public async Task AddPartAsync(Part part)
        {
            _dbContext.Parts.Add(part);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditPartAsync(Part part)
        {
            var partDb = await _dbSet.SingleAsync(x => x.PartId == part.PartId);

            partDb.PartNumber = part.PartNumber;
            partDb.Description = part.Description;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var part = await _dbSet.SingleAsync(x => x.PartId == id);

            _dbSet.Remove(part);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Part> GetByPartNumberAsync(string partNumber) 
        {
            var result = await _dbSet
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.PartNumber == partNumber);

            return result;
        }

        public async Task<Part> GetByIdAsync(int id)
        {
            var result = await _dbSet
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.PartId == id);

            return result;
        }
    }
}
