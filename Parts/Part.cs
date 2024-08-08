using RepairHistory.Repairs;

namespace RepairHistory.Parts
{
    public class Part
    {
        public int PartId { get; set; }
        public required string Description { get; set; }
        public required string PartNumber { get; set; }

        public List<PartRepair> PartRepairs { get; set; } = [];

        public override string ToString()
        {
            return $"{PartNumber} ({Description})";
        }
    }
}
