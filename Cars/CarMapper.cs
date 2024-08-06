using RepairHistory.Shared;

namespace RepairHistory.Cars
{
    public static class CarMapper
    {
        public static Car FormVmToCar(CarForm formVm)
        {
            return new Car
            {
                CarId = formVm.Id ?? 0,
                Brand = formVm.Brand.ToTitleCase(),
                Engine = formVm.Engine,
                LicensePlate = formVm.LicensePlate.ToUpper().Replace("-", "").Replace(" ", ""),
                ManufacturedYear = formVm.ManufacturedYear ?? 0,
                Model = formVm.Model.ToTitleCase(),
            };
        }

        public static CarForm CarToFromVm(Car car)
        {
            return new CarForm
            {
                Id = car.CarId,
                Brand = car.Brand,
                Engine = car.Engine,
                LicensePlate = car.LicensePlate,
                ManufacturedYear = car.ManufacturedYear,
                Model = car.Model
            };
        }
    }
}
