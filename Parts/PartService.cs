using RepairHistory.Database;
using RepairHistory.Shared;

namespace RepairHistory.Parts
{
    public interface IPartService
    {
        Task<IEnumerable<Part>> GetParts();
        Task<ValueResult<Part>> AddPart(Part part);
    }

    public class PartService : IPartService
    {
        private readonly IPartRepository _partRepository;

        public PartService(AppDbContext dbContext)
        {
            _partRepository = new PartRepository(dbContext);
        }

        public async Task<IEnumerable<Part>> GetParts()
        {
            var result = await _partRepository.GetList();
            return result;
        }

        public async Task<ValueResult<Part>> AddPart(Part part)
        {
            var partDb = await _partRepository.GetByPartNumber(part.PartNumber);

            if (partDb != null)
                return new ValueResult<Part>(false, "Część o podanym numerze już istnieje");

            await _partRepository.AddPart(part);
            return new ValueResult<Part>(part, true);
        }
    }
}
