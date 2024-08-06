using RepairHistory.Cars;

namespace RepairHistory.Repairs
{
    public class Repair
    {
        public int RepairId { get; set; }
        public required DateTime Date { get; set; }
        public required int Mileage { get; set; }
        public string Description { get; set; } = "";

        public required Car Car { get; set; }
        public int CarId { get; set; }

        public List<PartRepair> PartRepairs { get; set; } = [];
    }
}
