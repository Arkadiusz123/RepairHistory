using Microsoft.EntityFrameworkCore;
using RepairHistory.Database;

namespace RepairHistory.Parts
{
    public interface IPartRepository
    {
        Task<IEnumerable<Part>> GetList();
        Task AddPart(Part part);
        Task<Part> GetByPartNumber(string partNumber);
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

        public async Task<IEnumerable<Part>> GetList()
        {
            var result = await _dbSet.ToListAsync();
            return result;
        }

        public async Task AddPart(Part part)
        {
            _dbContext.Parts.Add(part);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Part> GetByPartNumber(string partNumber) 
        {
            var result = await _dbSet.SingleOrDefaultAsync(x => x.PartNumber == partNumber);
            return result;
        }
    }
}
