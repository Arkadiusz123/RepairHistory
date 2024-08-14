using RepairHistory.Database;
using RepairHistory.Shared;

namespace RepairHistory.Repairs
{
    public interface IRepairService
    {
        Task<IEnumerable<RepairTableVm>> GetTableListAsync(int carId);
        Task<ValueResult<Repair>> AddRepairAsync(Repair repair);
        Task<ValueResult<Repair>> EditRepairAsync(Repair repair);
        Task<ValueResult<Repair>> GetByIdAsync(int id);
    }

    public class RepairService : IRepairService
    {
        private readonly IRepairsRepository _repository;

        public RepairService(AppDbContext dbContext)
        {
            _repository = new RepairsRepository(dbContext);
        }

        public async Task<IEnumerable<RepairTableVm>> GetTableListAsync(int carId)
        {
            var result = await _repository.GetTableListAsync(carId);
            return result;
        }

        public async Task<ValueResult<Repair>> AddRepairAsync(Repair repair)
        {
            await _repository.AddRepairAsync(repair);
            return new ValueResult<Repair>(repair, true);
        }

        public async Task<ValueResult<Repair>> EditRepairAsync(Repair repair)
        {
            var repairExists = await _repository.ExistsWithIdAsync(repair.RepairId);

            if (!repairExists)
                return new ValueResult<Repair>(false, "Naprawa o podanym kluczu nie istnieje");

            await _repository.EditRepairAsync(repair);
            return new ValueResult<Repair>(repair, true);
        }

        public async Task<ValueResult<Repair>> GetByIdAsync(int id)
        {
            var repair = await _repository.GetByIdAsync(id);

            if (repair == null)
                return new ValueResult<Repair>(false, "Brak naprawy");

            return new ValueResult<Repair>(repair, true);
        }

        public async Task<Result> DeleteAsync(int id)
        {
            var repairExists = await _repository.ExistsWithIdAsync(id);

            if (!repairExists)
                return new Result(false, "Brak naprawy");

            await _repository.DeleteAsync(id);
            return new Result(true);
        }
    }
}
