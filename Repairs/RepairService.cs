using RepairHistory.Database;

namespace RepairHistory.Repairs
{
    public interface IRepairService
    {
        Task<IEnumerable<RepairTableVm>> GetTableList(int carId);
    }

    public class RepairService
    {
        private readonly IRepairsRepository _repository;

        public RepairService(AppDbContext dbContext)
        {
            _repository = new RepairsRepository(dbContext);
        }

        public async Task<IEnumerable<RepairTableVm>> GetTableList(int carId)
        {
            var result = await _repository.GetTableList(carId);
            return result;
        }
    }
}
