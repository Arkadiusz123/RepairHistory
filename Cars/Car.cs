using Microsoft.EntityFrameworkCore;

namespace RepairHistory.Cars
{
    [Index(nameof(LicensePlate), IsUnique = true)]
    public class Car
    {
        public int CarId { get; set; }
        public required string LicensePlate { get; set; }
        public required string Brand { get; set; }
        public required string Model { get; set; }
        public required string Engine { get; set; }
        public required int ManufacturedYear { get; set; }
    }
}
