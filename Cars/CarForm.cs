using System.ComponentModel.DataAnnotations;

namespace RepairHistory.Cars
{
    public class CarForm
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Numer rejestracyjny wymagany")]
        public string LicensePlate { get; set; }

        [Required(ErrorMessage = "Marka wymagana")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Model wymagany")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Silnik wymagany")]
        public string Engine { get; set; }

        [Required(ErrorMessage = "Rok produkcji wymagany")]
        public int? ManufacturedYear { get; set; }
    }
}
