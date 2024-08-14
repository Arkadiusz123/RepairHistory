using RepairHistory.Cars;
using RepairHistory.Database;
using RepairHistory.Parts;
using RepairHistory.Repairs;
using RepairHistory.Shared;

namespace RepairHistory
{
    partial class MainForm
    {
        private int selectedCar = 0;
        private int? _repairIdToEdit;
        IList<Part> partsToFrom = [];

        private async void AddRepairButton_Click(object sender, EventArgs e)
        {
            _repairIdToEdit = null;
            ClearRepairForm();
            await PrepareRepairForm();
            AppTabs.SelectedTab = RepairFormTab;
        }

        private async void EditRepairButton_Click(object sender, EventArgs e)
        {
            var id = RepairsTable.GetSelectedRowAttrib("RepairId");
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Nie zaznaczono pojazdu");
                return;
            }

            var idNumber = int.Parse(id);

            using (var db = new AppDbContext())
            {
                var repairService = new RepairService(db);
                var repairResult = await repairService.GetByIdAsync(idNumber);

                if (!repairResult.Success) 
                {
                    MessageBox.Show(repairResult.Message);
                    return;
                }

                PrepareEditRapirForm(repairResult.Value);
                _repairIdToEdit = idNumber;
                AppTabs.SelectedTab = RepairFormTab;
            }
        }

        private async void DeleteRepairButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć?", "Usuń", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No)
                return;

            var id = RepairsTable.GetSelectedRowAttrib("RepairId");
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Nie zaznaczono naprawy");
                return;
            }

            var idNumber = int.Parse(id);

            using (var db = new AppDbContext())
            {
                var repairService = new RepairService(db);
                var deleteResult = await repairService.DeleteAsync(idNumber);

                if (!deleteResult.Success)
                {
                    MessageBox.Show(deleteResult.Message);
                    return;
                }
                await LoadRepairsTable(selectedCar);
            }
        }

        private void RepairFormBackButton_Click(object sender, EventArgs e)
        {
            ClearRepairForm();
            AppTabs.SelectedTab = RepairHistoryTab;
        }

        private void BackFromRepDet_Click(object sender, EventArgs e)
        {
            AppTabs.SelectedTab = RepairHistoryTab;
        }

        private async void RepairDetailsButton_Click(object sender, EventArgs e)
        {
            var id = RepairsTable.GetSelectedRowAttrib("RepairId");
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Nie zaznaczono pojazdu");
                return;
            }

            var idNumber = int.Parse(id);

            Repair repair;
            using (var db = new AppDbContext())
            {
                var service = new RepairService(db);
                var result = await service.GetByIdAsync(idNumber);

                if (!result.Success)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                repair = result.Value;                                  
            }
            DateDisplay.Text = repair.Date.ToShortDateString();
            MileageDisplay.Text = repair.Mileage.ToString();
            DescDisplay.Text = repair.Description;
            PartsDisplay.Text = string.Join(Environment.NewLine, 
                repair.PartRepairs.Select(x => $"{x.Part.PartNumber}({x.Part.Description}) x {x.PartQuantity}"));

            AppTabs.SelectedTab = RepairDetailsTab;
        }

        private async void RepairFormSaveButton_Click(object sender, EventArgs e)
        {
            var repairFormVm = RepairFormVm();
            var validationResult = FormObjectValidator.ValidateObject(repairFormVm);
            if (!validationResult.Result)
            {
                MessageBox.Show(validationResult.ErrorMessages);
                return;
            }

            using (var db = new AppDbContext())
            {
                var repairService = new RepairService(db);
                var carService = new CarService(db);

                var carResult = await carService.GetById(repairFormVm.CarId);
                if (!carResult.Success)
                {
                    MessageBox.Show(carResult.Message);
                    return;
                }

                var repairModel = RepairMapper.FormVmToRepair(repairFormVm, carResult.Value);

                ValueResult<Repair> result;
                if (_repairIdToEdit == null)
                    result = await repairService.AddRepairAsync(repairModel);
                else
                    result = await repairService.EditRepairAsync(repairModel);

                if (!result.Success)
                {
                    MessageBox.Show(carResult.Message);
                    return;
                }

                ClearRepairForm();
                _repairIdToEdit = null;
                await LoadRepairsTable(selectedCar);
                AppTabs.SelectedTab = RepairHistoryTab;
            }
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
                var addResult = await partService.AddPartAsync(newPart);

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

        private void RepFormDelPartButton_Click(object sender, EventArgs e)
        {
            var rowIndex = RepFromTable.CurrentCell?.RowIndex;

            if (rowIndex == null)
            {
                MessageBox.Show("Nie zaznaczono części");
                return;
            }

            RepFromTable.Rows.RemoveAt(rowIndex.Value);
        }

        private async Task LoadRepairsTable(int carId)
        {
            selectedCar = carId;
            RepairsTable.Rows.Clear();

            using (var db = new AppDbContext())
            {
                var service = new RepairService(db);
                var repairsList = await service.GetTableListAsync(carId);

                foreach (var repair in repairsList)
                {
                    RepairsTable.Rows.Add(repair.Id, repair.Date.ToShortDateString(), repair.Mileage);
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
                if ((int)row.Cells["RepPartId"].Value == selectedItem.Key)
                {
                    MessageBox.Show("Część już znajduje się na liście użytych");
                    return;

                }
            }

            var selectedPart = partsToFrom.Single(x => x.PartId == selectedItem.Key);
            RepFromTable.Rows.Add(selectedPart.PartId, selectedPart.PartNumber, selectedPart.Description, 1);          
        }

        private async Task PrepareRepairForm()
        {
            partsToFrom.Clear();
            RepFromPartsDropDown.Items.Clear();

            using (var db = new AppDbContext())
            {
                var partService = new PartService(db);
                var parts = await partService.GetPartsAsync();
                partsToFrom = parts.ToList();
            }

            foreach (var part in partsToFrom)
            {
                RepFromPartsDropDown.Items.Add(new ComboboxItem { Key = part.PartId, Value = part.ToString() });
            }
        }

        private async void PrepareEditRapirForm(Repair repair)
        {
            ClearRepairForm();
            await PrepareRepairForm();

            DatePickerRepairForm.Value = repair.Date;
            MilagePickerRepairForm.Value = repair.Mileage;
            DescRepairFormBox.Text = repair.Description;

            foreach (var partRepair in repair.PartRepairs)
            {
                RepFromTable.Rows.Add(partRepair.PartId, partRepair.Part.PartNumber, partRepair.Part.Description, partRepair.PartQuantity);
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

        private RepairFormVm RepairFormVm()
        {
            var parts = new List<RepairFormVmPart>();

            foreach (DataGridViewRow partRow in RepFromTable.Rows)
            {
                var newPart = new RepairFormVmPart
                {
                    PartId = (int)partRow.Cells["RepPartId"].Value,
                    PartQuantity = Convert.ToInt32(partRow.Cells["Quant"].Value)
                };

                if (newPart.PartQuantity < 1)
                    continue;

                parts.Add(newPart);
            }

            var repairVm = new RepairFormVm
            {
                Id = _repairIdToEdit,
                CarId = selectedCar,
                Date = DatePickerRepairForm.Value,
                Description = DescRepairFormBox.Text,
                Mileage = (int?)MilagePickerRepairForm.Value,
                PartRepairs = parts
            };
            return repairVm;
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
