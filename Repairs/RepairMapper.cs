using RepairHistory.Cars;

namespace RepairHistory.Repairs
{
    public class RepairMapper
    {
        public static Repair FormVmToRepair(RepairFormVm formVm, Car car)
        {
            var partRepairs = new List<PartRepair>();

            foreach (var part in formVm.PartRepairs) 
            {
                var partRepair = new PartRepair
                {
                    PartId = part.PartId,
                    PartQuantity = part.PartQuantity,
                };

                partRepairs.Add(partRepair);
            }

            return new Repair
            {
                RepairId = formVm.Id ?? 0,
                Car = car,
                Date = formVm.Date.Value,
                Mileage = formVm.Mileage.Value,
                Description = formVm.Description,
                PartRepairs = partRepairs
            };
        }
    }
}
