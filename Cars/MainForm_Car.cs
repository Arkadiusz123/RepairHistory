﻿using RepairHistory.Cars;
using RepairHistory.Database;
using RepairHistory.Shared;

namespace RepairHistory
{
    partial class MainForm
    {
        private int? _editedCarId;

        private async void LoadData()
        {
            CarsTable.Rows.Clear();

            var filters = new CarsTableFilters 
            {
                LicensePlate = LicencePlateFilterBox.Text
            };

            using (var db = new AppDbContext())
            {
                var service = new CarService(db);
                var list = await service.GetCars(filters);

                foreach (var car in list) 
                {
                    CarsTable.Rows.Add(car.CarId, car.LicensePlate, car.Brand, car.Brand, car.Engine, car.ManufacturedYear);
                }
            }
        }

        private void CarsTableFilterButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            _editedCarId = null;
            AppTabs.SelectedTab = CarsFormTab;
        }

        private async void EditCarButton_Click(object sender, EventArgs e)
        {
            var id = CarsTable.GetSelectedRowAttrib("Id");
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Nie zaznaczono pojazdu");
                return;
            }

            var idNumber = int.Parse(id);

            using (var db = new AppDbContext())
            {
                var service = new CarService(db);
                var carResult = await service.GetById(idNumber);

                if (!carResult.Success)
                    MessageBox.Show(carResult.Message);

                PrepareFormToEdit(carResult.Value);
                AppTabs.SelectedTab = CarsFormTab;
            }
        }

        private void CarFormBack_Click(object sender, EventArgs e)
        {
            ClearCarForm();
            AppTabs.SelectedTab = CarsTableTab;
        }

        private async void FormSubmitButton_Click(object sender, EventArgs e)
        {
            var carForm = GetCarFromForm();

            var validationResult = FormObjectValidator.ValidateObject(carForm);
            if (!validationResult.Result)
            {
                MessageBox.Show(validationResult.ErrorMessages);
                return;
            }

            var carFromForm = CarMapper.FormVmToCar(carForm);

            using (var db = new AppDbContext())
            {
                var service = new CarService(db);

                ValueResult<Car> result;

                if (_editedCarId == null)
                    result = await service.AddCarAsync(carFromForm);
                else
                    result = await service.EditCarAsync(carFromForm);

                if (!result.Success)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {                   
                    MessageBox.Show("Poprawnie zapisano");
                    LoadData();
                    AppTabs.SelectedTab = CarsTableTab;
                    ClearCarForm();
                }                   
            }
        }

        private CarForm GetCarFromForm()
        {
            var carForm = new CarForm
            {
                Id = _editedCarId,
                LicensePlate = LicensePlateBox.Text,
                Brand = BrandBox.Text,
                Engine = EngineBox.Text,
                ManufacturedYear = (int)ManYearBox.Value,
                Model = ModelBox.Text
            };

            return carForm;
        }

        private void ClearCarForm()
        {
            _editedCarId = null;

            LicensePlateBox.Clear();
            BrandBox.Clear();
            EngineBox.Clear();
            ModelBox.Clear();
            ManYearBox.Value = DateTime.Now.Year;
        }

        private void PrepareFormToEdit(Car car)
        {
            _editedCarId = car.CarId;

            LicensePlateBox.Text = car.LicensePlate;
            BrandBox.Text = car.Brand;
            EngineBox.Text = car.Engine;
            ModelBox.Text = car.Model;
            ManYearBox.Value = car.ManufacturedYear;
        }
    }
}
