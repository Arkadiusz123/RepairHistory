using RepairHistory.Database;
using RepairHistory.Shared;

namespace RepairHistory.Cars
{
    public interface ICarService
    {
        Task<ValueResult<Car>> AddCarAsync(Car car);
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
    }
}
