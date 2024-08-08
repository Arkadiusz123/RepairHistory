using RepairHistory.Database;
using RepairHistory.Shared;

namespace RepairHistory.Cars
{
    public interface ICarService
    {
        Task<ValueResult<Car>> AddCarAsync(Car car);
        Task<ValueResult<Car>> EditCarAsync(Car car);
        Task<ValueResult<Car>> GetById(int id);
        Task<Result> DeleteCarAsync(int id);
    }

    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;

        public CarService(AppDbContext dbContext)
        {
            _repository = new CarRepository(dbContext);
        }

        public async Task<ValueResult<Car>> AddCarAsync(Car car)
        {
            var carWithLicensePlate = await _repository.GetByLicensePlateAsync(car.LicensePlate);

            if (carWithLicensePlate != null)
                return new ValueResult<Car>(false, "Samochód o podanym numerze rejestracyjnym już istnieje");

            await _repository.AddCarAsync(car);
            return new ValueResult<Car>(car, true);
        }

        public async Task<ValueResult<Car>> EditCarAsync(Car car)
        {
            var carWithLicensePlate = await _repository.GetByLicensePlateAsync(car.LicensePlate);

            if (carWithLicensePlate != null && carWithLicensePlate.CarId != car.CarId)
                return new ValueResult<Car>(false, "Istnieje już inny samochód o tym numerze rejestracyjnym");

            await _repository.EditCarAsync(car);
            return new ValueResult<Car>(car, true);
        }

        public async Task<IEnumerable<Car>> GetCars(CarsTableFilters filters) 
        {
            var list = await _repository.GetList(filters);
            return list;
        }

        public async Task<ValueResult<Car>> GetById(int id)
        {
            var car = await _repository.GetById(id);

            if (car == null)
                return new ValueResult<Car>(false, "Nie znaleziono pojazdu");

            return new ValueResult<Car>(car, true);
        }

        public async Task<Result> DeleteCarAsync(int id)
        {
            var result = await _repository.DeleteCarAsync(id);
            return result;
        }
    }
}
