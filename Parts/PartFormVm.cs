using System.ComponentModel.DataAnnotations;

namespace RepairHistory.Parts
{
    public class PartFormVm
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Opis części wymagany")]
        public string Description { get; set; } = "";

        [Required(ErrorMessage = "Numer części wymagany")]
        public string PartNumber { get; set; } = "";
    }
}
