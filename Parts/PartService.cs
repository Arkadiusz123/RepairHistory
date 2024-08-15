using RepairHistory.Database;
using RepairHistory.Shared;

namespace RepairHistory.Parts
{
    public interface IPartService
    {
        Task<IEnumerable<Part>> GetPartsAsync(PartFilterModel filter);
        Task<ValueResult<Part>> GetByIdAsync(int id);
        Task<ValueResult<Part>> AddPartAsync(Part part);
        Task<ValueResult<Part>> EditPartAsync(Part part);
        Task<Result> DeleteAsync(int id);
    }

    public class PartService : IPartService
    {
        private readonly IPartRepository _partRepository;

        public PartService(AppDbContext dbContext)
        {
            _partRepository = new PartRepository(dbContext);
        }

        public async Task<IEnumerable<Part>> GetPartsAsync(PartFilterModel filter)
        {
            var result = await _partRepository.GetListAsync(filter);
            return result;
        }

        public async Task<ValueResult<Part>> GetByIdAsync(int id)
        {
            var part = await _partRepository.GetByIdAsync(id);

            if (part == null)
                return new ValueResult<Part>(false, "Nie znaleziono części");

            return new ValueResult<Part>(part, true);
        }

        public async Task<ValueResult<Part>> AddPartAsync(Part part)
        {
            var partDb = await _partRepository.GetByPartNumberAsync(part.PartNumber);

            if (partDb != null)
                return new ValueResult<Part>(false, "Część o podanym numerze już istnieje");

            await _partRepository.AddPartAsync(part);
            return new ValueResult<Part>(part, true);
        }

        public async Task<ValueResult<Part>> EditPartAsync(Part part)
        {
            var partDb = await _partRepository.GetByIdAsync(part.PartId);

            if (partDb == null)
                return new ValueResult<Part>(false, "Część nie istnieje");

            partDb = await _partRepository.GetByPartNumberAsync(part.PartNumber);

            if (partDb != null && partDb.PartId != part.PartId)
                return new ValueResult<Part>(false, "Część o podanym numerze już istnieje");

            await _partRepository.EditPartAsync(part);
            return new ValueResult<Part>(part, true);
        }

        public async Task<Result> DeleteAsync(int id)
        {
            var part = await _partRepository.GetByIdAsync(id);

            if (part == null)
                return new Result(false, "Nie znaleziono części");

            await _partRepository.DeleteAsync(id);
            return new Result(true);
        }
    }
}
