using RepairHistory.Cars;
using System.ComponentModel.DataAnnotations;
using System;
using RepairHistory.Shared;
using RepairHistory.Database;

namespace RepairHistory
{
    partial class MainForm
    {
        private void LoadData()
        {
            CarsTable.Rows.Add("test", "t", "", "6");
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            AppTabs.SelectedTab = CarsFormTab;
        }

        private async void AddSubmitButton_Click(object sender, EventArgs e)
        {
            var carForm = GetCarFromForm();

            var validationResult = FormObjectValidator.ValidateObject(carForm);
            if (!validationResult.Result)
            {
                MessageBox.Show(validationResult.ErrorMessages, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new AppDbContext())
            {
                var service = new CarService(db);
                var result = await service.AddCarAsync(CarMapper.FormVmToCar(carForm));

                if (!result.Success)
                    MessageBox.Show(result.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Poprawnie zapisano");
            }
        }

        private CarForm GetCarFromForm()
        {
            var carForm = new CarForm
            {
                //id todo
                LicensePlate = LicensePlateBox.Text,
                Brand = BrandBox.Text,
                Engine = EngineBox.Text,
                ManufacturedYear = string.IsNullOrEmpty(ManYearBox.Text) ? null : int.Parse(ManYearBox.Text),
                Model = ModelBox.Text
            };

            return carForm;
        }
    }
}
