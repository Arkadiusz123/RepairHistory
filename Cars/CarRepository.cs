using Microsoft.EntityFrameworkCore;
using RepairHistory.Database;
using RepairHistory.Shared;

namespace RepairHistory.Cars
{
    public interface ICarRepository
    {
        Task AddCarAsync(Car car);
        Task EditCarAsync(Car car);
        Task<Result> DeleteCarAsync(int id);
        Task<Car> GetByLicensePlateAsync(string licensePlate);
        Task<IEnumerable<Car>> GetList(CarsTableFilters filters);
        Task<Car> GetById(int id);
    }

    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly DbSet<Car> _dbSet;

        public CarRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<Car>();
        }

        public async Task AddCarAsync(Car car)
        {
            _dbSet.Add(car);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditCarAsync(Car car)
        {
            var carDb = await _dbSet.SingleOrDefaultAsync(x => x.CarId == car.CarId);

            carDb.Engine = car.Engine;
            carDb.ManufacturedYear = car.ManufacturedYear;
            carDb.LicensePlate = car.LicensePlate;
            carDb.Brand = car.Brand;
            carDb.Model = car.Model;           

            await _dbContext.SaveChangesAsync();
        }

        public async Task<Result> DeleteCarAsync(int id)
        {
            var car = await _dbSet.SingleOrDefaultAsync(x => x.CarId == id);

            if (car == null)
                return new Result(false, "Nie znaleziono pojazdu");

            _dbSet.Remove(car);
            await _dbContext.SaveChangesAsync();

            return new Result(true);
        }

        public async Task<Car> GetByLicensePlateAsync(string licensePlate)
        {
            return await _dbSet.SingleOrDefaultAsync(x => x.LicensePlate == licensePlate);
        }

        public async Task<Car> GetById(int id)
        {
            return await _dbSet.SingleOrDefaultAsync(x => x.CarId == id);
        }

        public async Task<IEnumerable<Car>> GetList(CarsTableFilters filters)
        {
            IQueryable<Car> query = _dbSet;

            if (!string.IsNullOrEmpty(filters.LicensePlate))
            {
                var licenseFilter = filters.LicensePlate.ToUpper().Trim();
                query = query.Where(x => x.LicensePlate.ToUpper().Contains(licenseFilter));
            }

            var result = await query.ToListAsync();
            return result;
        }
    }
}
