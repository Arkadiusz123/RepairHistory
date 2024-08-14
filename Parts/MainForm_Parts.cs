using RepairHistory.Database;
using RepairHistory.Parts;
using RepairHistory.Repairs;
using RepairHistory.Shared;
using System.ComponentModel.DataAnnotations;

namespace RepairHistory
{
    partial class MainForm
    {
        private int? _selectedPartId;

        private async Task LoadAllPartsTable()
        {
            AllPartsTable.Rows.Clear();

            using (var db = new AppDbContext())
            {
                var service = new PartService(db);
                var partsList = await service.GetPartsAsync();

                foreach (var part in partsList)
                {
                    AllPartsTable.Rows.Add(part.PartId, part.PartNumber, part.Description);
                }
            }
        }

        private void AddNewPartBut_Click(object sender, EventArgs e)
        {
            _selectedPartId = null;
            ClearPartForm();
            AppTabs.SelectedTab = PartFormTab;
        }

        private void BackToAllPartsBut_Click(object sender, EventArgs e)
        {
            _selectedPartId = null;
            AppTabs.SelectedTab = PartsTableTab;
        }

        private async void EditPartButton_Click(object sender, EventArgs e)
        {
            var id = AllPartsTable.GetSelectedRowAttrib("AllPartsId");
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Nie zaznaczono pojazdu");
                return;
            }

            Part part;
            var idNumber = int.Parse(id);

            using (var db = new AppDbContext())
            {
                var partService = new PartService(db);

                var partResult = await partService.GetByIdAsync(idNumber);

                if (!partResult.Success)
                {
                    MessageBox.Show(partResult.Message);
                    return;
                }
                part = partResult.Value;
            }
            _selectedPartId = idNumber;
            PartFormNrBox.Text = part.PartNumber;
            PartFormDescBox.Text = part.Description;

            AppTabs.SelectedTab = PartFormTab;
        }

        private async void PartFormSubmitBut_Click(object sender, EventArgs e)
        {
            var partFormVm = PartFromForm();
            var validationResult = FormObjectValidator.ValidateObject(partFormVm);
            if (!validationResult.Result)
            {
                MessageBox.Show(validationResult.ErrorMessages);
                return;
            }

            using (var db = new AppDbContext())
            {
                var partService = new PartService(db);

                ValueResult<Part> result;
                if (_selectedPartId == null)
                    result = await partService.AddPartAsync(partFormVm);
                else
                    result = await partService.EditPartAsync(partFormVm);

                if (!result.Success)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                ClearPartForm();
                _selectedPartId = null;
                await LoadAllPartsTable();
                AppTabs.SelectedTab = PartsTableTab;
            }
        }

        private async void DeletePartButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć?", "Usuń", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No)
                return;

            var id = AllPartsTable.GetSelectedRowAttrib("AllPartsId");
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Nie zaznaczono części");
                return;
            }

            var idNumber = int.Parse(id);

            using (var db = new AppDbContext())
            {
                var partService = new PartService(db);
                var deleteResult = await partService.DeleteAsync(idNumber);

                if (!deleteResult.Success)
                {
                    MessageBox.Show(deleteResult.Message);
                    return;
                }
                await LoadAllPartsTable();
            }
        }

        private void ClearPartForm()
        {
            PartFormNrBox.Clear();
            PartFormDescBox.Clear();
        }

        private Part PartFromForm()
        {
            return new Part
            {
                PartId = _selectedPartId ?? 0,
                Description = PartFormDescBox.Text,
                PartNumber = PartFormNrBox.Text,
            };
        }
    }
}
