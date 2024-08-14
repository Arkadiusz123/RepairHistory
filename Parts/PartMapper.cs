namespace RepairHistory.Parts
{
    public class PartMapper
    {
        public static Part FormVmToPart(PartFormVm formVm)
        {
            return new Part
            {
                PartId = formVm.Id ?? 0,
                Description = formVm.Description,
                PartNumber = formVm.PartNumber.Replace(" ", "").ToUpper(),
            };
        }
    }
}
