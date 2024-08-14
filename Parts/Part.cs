using RepairHistory.Repairs;
using System.ComponentModel.DataAnnotations;

namespace RepairHistory.Parts
{
    public class Part
    {
        public int PartId { get; set; }

        [Required(ErrorMessage = "Numer części wymagany")]
        public required string Description { get; set; }

        [Required(ErrorMessage = "Opis części wymagany")]
        public required string PartNumber { get; set; }

        public List<PartRepair> PartRepairs { get; set; } = [];

        public override string ToString()
        {
            return $"{PartNumber} ({Description})";
        }
    }
}
