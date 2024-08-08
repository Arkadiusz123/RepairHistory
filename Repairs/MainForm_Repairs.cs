using RepairHistory.Database;
using RepairHistory.Parts;
using RepairHistory.Repairs;
using RepairHistory.Shared;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RepairHistory
{
    partial class MainForm
    {
        private int selectedCar = 0;
        private int? repairIdToEdit;
        IList<Part> partsToFrom = [];

        private async void AddRepairButton_Click(object sender, EventArgs e)
        {
            ClearRepairForm();
            await PrepareReapirForm();
            AppTabs.SelectedTab = RepairFormTab;
        }

        private void RepairFormBackButton_Click(object sender, EventArgs e)
        {
            ClearRepairForm();
            AppTabs.SelectedTab = RepairHistoryTab;
        }

        private async void RepFromNewPartSubButton_Click(object sender, EventArgs e)
        {
            var partVm = RepairFromNewPart();

            var validationResult = FormObjectValidator.ValidateObject(partVm);
            if (!validationResult.Result)
            {
                MessageBox.Show(validationResult.ErrorMessages);
                return;
            }

            var newPart = PartMapper.FormVmToPart(partVm);

            using (var db = new AppDbContext())
            {
                var partService = new PartService(db);
                var addResult = await partService.AddPart(newPart);

                if (!addResult.Success)
                {
                    MessageBox.Show(addResult.Message);
                    return;
                }
            }
            RepFromPartsDropDown.Items.Add(new ComboboxItem { Key = newPart.PartId, Value = newPart.ToString() });
            RepFromTable.Rows.Add(newPart.PartId, newPart.PartNumber, newPart.Description, 1);
            partsToFrom.Add(newPart);
            ClearRepairFormNewPart();
        }

        private async Task LoadRepairsTable(int carId)
        {
            selectedCar = carId;
            RepairsTable.Rows.Clear();

            using (var db = new AppDbContext())
            {
                var service = new RepairService(db);
                var repairsList = await service.GetTableList(carId);

                foreach (var repair in repairsList)
                {
                    CarsTable.Rows.Add(repair.Id, repair.Date, repair.Mileage);
                }
            }
        }

        private void PartDropDown_SelectedItemChanged(object sender, EventArgs e)
        {
            var selectedItem = RepFromPartsDropDown.SelectedItem as ComboboxItem;
            if (selectedItem?.Key == null)
                return;

            RepFromPartsDropDown.SelectedItem = null;

            foreach (DataGridViewRow row in RepFromTable.Rows) 
            {
                if ((int)row.Cells["Id"].Value == selectedItem.Key)
                {
                    MessageBox.Show("Część już znajduje się na liście użytych");
                    return;

                }
            }

            var selectedPart = partsToFrom.Single(x => x.PartId == selectedItem.Key);
            RepFromTable.Rows.Add(selectedPart.PartId, selectedPart.PartNumber, selectedPart.Description, 1);          
        }

        private async Task PrepareReapirForm()
        {
            partsToFrom.Clear();
            RepFromPartsDropDown.Items.Clear();

            using (var db = new AppDbContext())
            {
                var partService = new PartService(db);
                var parts = await partService.GetParts();
                partsToFrom = parts.ToList();
            }

            foreach (var part in partsToFrom)
            {
                RepFromPartsDropDown.Items.Add(new ComboboxItem { Key = part.PartId, Value = part.ToString() });
            }
        }

        private void ClearRepairForm()
        {
            DatePickerRepairForm.Value = DateTime.Today;
            MilagePickerRepairForm.Value = 100000;
            DescRepairFormBox.Clear();
            RepFromPartsDropDown.Items.Clear();
            RepFromTable.Rows.Clear();
            RepFromNewPartNr.Clear();
            RepFromNewPartDesc.Clear();
        }

        private void ClearRepairFormNewPart()
        {
            RepFromNewPartNr.Clear();
            RepFromNewPartDesc.Clear();
        }

        private PartFormVm RepairFromNewPart()
        {
            var partVm = new PartFormVm
            {
                PartNumber = RepFromNewPartNr.Text,
                Description = RepFromNewPartDesc.Text,
            };
            return partVm;
        }

        private void RepFromTable_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (RepFromTable.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                var tb = e.Control;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
