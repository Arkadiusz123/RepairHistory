using System.ComponentModel.DataAnnotations;

namespace RepairHistory.Repairs
{
    public class RepairFormVm
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Data naprawy wymagana")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Przebieg wymagany")]
        public int? Mileage { get; set; }

        public string Description { get; set; }

        public int CarId { get; set; }

        public List<RepairFormVmPart> PartRepairs { get; set; } = [];
    }

    public class RepairFormVmPart
    {
        public int PartId { get; set; }
        public int PartQuantity { get; set; }
    }
}
