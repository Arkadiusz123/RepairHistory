namespace RepairHistory
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CarsTable = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            LicensePlate = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            Engine = new DataGridViewTextBoxColumn();
            ManufacturedYear = new DataGridViewTextBoxColumn();
            AddCarButton = new Button();
            AppTabs = new TabControl();
            CarsTableTab = new TabPage();
            ToRepairsButton = new Button();
            DeleteCarButton = new Button();
            EditCarButton = new Button();
            CarsTableFilterButton = new Button();
            LicPlatFilterLabel = new Label();
            LicencePlateFilterBox = new TextBox();
            CarsFormTab = new TabPage();
            CarFormBack = new Button();
            SaveButton = new Button();
            ManYearBox = new NumericUpDown();
            EngineLabel = new Label();
            ManYearLabel = new Label();
            BrandLabel = new Label();
            ModelLabel = new Label();
            LicensePlateLabel = new Label();
            EngineBox = new TextBox();
            ModelBox = new TextBox();
            BrandBox = new TextBox();
            LicensePlateBox = new TextBox();
            RepairHistoryTab = new TabPage();
            DeleteRepairButton = new Button();
            EditRepairButton = new Button();
            AddRepairButton = new Button();
            RepairsTable = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            RepairFormTab = new TabPage();
            RepFromNewPartSubButton = new Button();
            label2 = new Label();
            label1 = new Label();
            RepFromNewPartDesc = new TextBox();
            RepFromNewPartNr = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            RepFromPartsDropDown = new ComboBox();
            RepFromTable = new DataGridView();
            RepFromTableIdCol = new DataGridViewTextBoxColumn();
            RepFromTableNumCol = new DataGridViewTextBoxColumn();
            RepFromTableDescCol = new DataGridViewTextBoxColumn();
            RepFromTableQuant = new DataGridViewTextBoxColumn();
            DatePickerRepairForm = new DateTimePicker();
            RepairFormBackButton = new Button();
            RepairFormSaveButton = new Button();
            MilagePickerRepairForm = new NumericUpDown();
            MilageRepairFormLabel = new Label();
            DescLabelRepFrom = new Label();
            RepairFormLabelDate = new Label();
            DescRepairFormBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)CarsTable).BeginInit();
            AppTabs.SuspendLayout();
            CarsTableTab.SuspendLayout();
            CarsFormTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ManYearBox).BeginInit();
            RepairHistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RepairsTable).BeginInit();
            RepairFormTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RepFromTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MilagePickerRepairForm).BeginInit();
            SuspendLayout();
            // 
            // CarsTable
            // 
            CarsTable.AllowUserToAddRows = false;
            CarsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarsTable.Columns.AddRange(new DataGridViewColumn[] { Id, LicensePlate, Brand, Model, Engine, ManufacturedYear });
            CarsTable.Location = new Point(226, 74);
            CarsTable.MultiSelect = false;
            CarsTable.Name = "CarsTable";
            CarsTable.ReadOnly = true;
            CarsTable.RowHeadersVisible = false;
            CarsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarsTable.Size = new Size(510, 486);
            CarsTable.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // LicensePlate
            // 
            LicensePlate.HeaderText = "Nr rejestracyjny";
            LicensePlate.Name = "LicensePlate";
            LicensePlate.ReadOnly = true;
            // 
            // Brand
            // 
            Brand.HeaderText = "Marka";
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            // 
            // Model
            // 
            Model.HeaderText = "Model";
            Model.Name = "Model";
            Model.ReadOnly = true;
            // 
            // Engine
            // 
            Engine.HeaderText = "Silnik";
            Engine.Name = "Engine";
            Engine.ReadOnly = true;
            // 
            // ManufacturedYear
            // 
            ManufacturedYear.HeaderText = "Rok pordukcji";
            ManufacturedYear.Name = "ManufacturedYear";
            ManufacturedYear.ReadOnly = true;
            // 
            // AddCarButton
            // 
            AddCarButton.Location = new Point(833, 144);
            AddCarButton.Name = "AddCarButton";
            AddCarButton.Size = new Size(161, 31);
            AddCarButton.TabIndex = 1;
            AddCarButton.Text = "Dodaj nowy pojazd";
            AddCarButton.UseVisualStyleBackColor = true;
            AddCarButton.Click += AddCarButton_Click;
            // 
            // AppTabs
            // 
            AppTabs.Controls.Add(CarsTableTab);
            AppTabs.Controls.Add(CarsFormTab);
            AppTabs.Controls.Add(RepairHistoryTab);
            AppTabs.Controls.Add(RepairFormTab);
            AppTabs.Location = new Point(12, 12);
            AppTabs.Name = "AppTabs";
            AppTabs.SelectedIndex = 0;
            AppTabs.Size = new Size(1067, 613);
            AppTabs.TabIndex = 2;
            // 
            // CarsTableTab
            // 
            CarsTableTab.Controls.Add(ToRepairsButton);
            CarsTableTab.Controls.Add(DeleteCarButton);
            CarsTableTab.Controls.Add(EditCarButton);
            CarsTableTab.Controls.Add(CarsTableFilterButton);
            CarsTableTab.Controls.Add(LicPlatFilterLabel);
            CarsTableTab.Controls.Add(LicencePlateFilterBox);
            CarsTableTab.Controls.Add(CarsTable);
            CarsTableTab.Controls.Add(AddCarButton);
            CarsTableTab.Location = new Point(4, 24);
            CarsTableTab.Name = "CarsTableTab";
            CarsTableTab.Padding = new Padding(3);
            CarsTableTab.Size = new Size(1059, 585);
            CarsTableTab.TabIndex = 0;
            CarsTableTab.Text = "Pojazdy";
            CarsTableTab.UseVisualStyleBackColor = true;
            // 
            // ToRepairsButton
            // 
            ToRepairsButton.Location = new Point(833, 86);
            ToRepairsButton.Name = "ToRepairsButton";
            ToRepairsButton.Size = new Size(161, 31);
            ToRepairsButton.TabIndex = 7;
            ToRepairsButton.Text = "Wyświetl historię napraw";
            ToRepairsButton.UseVisualStyleBackColor = true;
            ToRepairsButton.Click += ToRepairsButton_Click;
            // 
            // DeleteCarButton
            // 
            DeleteCarButton.Location = new Point(833, 240);
            DeleteCarButton.Name = "DeleteCarButton";
            DeleteCarButton.Size = new Size(161, 30);
            DeleteCarButton.TabIndex = 6;
            DeleteCarButton.Text = "Usuń pojazd";
            DeleteCarButton.UseVisualStyleBackColor = true;
            DeleteCarButton.Click += DeleteCarButton_Click;
            // 
            // EditCarButton
            // 
            EditCarButton.Location = new Point(833, 192);
            EditCarButton.Name = "EditCarButton";
            EditCarButton.Size = new Size(161, 30);
            EditCarButton.TabIndex = 5;
            EditCarButton.Text = "Edytuj pojazd";
            EditCarButton.UseVisualStyleBackColor = true;
            EditCarButton.Click += EditCarButton_Click;
            // 
            // CarsTableFilterButton
            // 
            CarsTableFilterButton.Location = new Point(432, 33);
            CarsTableFilterButton.Name = "CarsTableFilterButton";
            CarsTableFilterButton.Size = new Size(75, 23);
            CarsTableFilterButton.TabIndex = 4;
            CarsTableFilterButton.Text = "Filtruj";
            CarsTableFilterButton.UseVisualStyleBackColor = true;
            CarsTableFilterButton.Click += CarsTableFilterButton_Click;
            // 
            // LicPlatFilterLabel
            // 
            LicPlatFilterLabel.AutoSize = true;
            LicPlatFilterLabel.Location = new Point(267, 16);
            LicPlatFilterLabel.Name = "LicPlatFilterLabel";
            LicPlatFilterLabel.Size = new Size(89, 15);
            LicPlatFilterLabel.TabIndex = 3;
            LicPlatFilterLabel.Text = "Nr rejestracyjny";
            // 
            // LicencePlateFilterBox
            // 
            LicencePlateFilterBox.Location = new Point(267, 34);
            LicencePlateFilterBox.Name = "LicencePlateFilterBox";
            LicencePlateFilterBox.Size = new Size(150, 23);
            LicencePlateFilterBox.TabIndex = 2;
            // 
            // CarsFormTab
            // 
            CarsFormTab.Controls.Add(CarFormBack);
            CarsFormTab.Controls.Add(SaveButton);
            CarsFormTab.Controls.Add(ManYearBox);
            CarsFormTab.Controls.Add(EngineLabel);
            CarsFormTab.Controls.Add(ManYearLabel);
            CarsFormTab.Controls.Add(BrandLabel);
            CarsFormTab.Controls.Add(ModelLabel);
            CarsFormTab.Controls.Add(LicensePlateLabel);
            CarsFormTab.Controls.Add(EngineBox);
            CarsFormTab.Controls.Add(ModelBox);
            CarsFormTab.Controls.Add(BrandBox);
            CarsFormTab.Controls.Add(LicensePlateBox);
            CarsFormTab.Location = new Point(4, 24);
            CarsFormTab.Name = "CarsFormTab";
            CarsFormTab.Padding = new Padding(3);
            CarsFormTab.Size = new Size(1059, 585);
            CarsFormTab.TabIndex = 1;
            CarsFormTab.Text = "Formularz pojazdu";
            CarsFormTab.UseVisualStyleBackColor = true;
            // 
            // CarFormBack
            // 
            CarFormBack.Location = new Point(70, 236);
            CarFormBack.Name = "CarFormBack";
            CarFormBack.Size = new Size(75, 23);
            CarFormBack.TabIndex = 12;
            CarFormBack.Text = "Wróć";
            CarFormBack.UseVisualStyleBackColor = true;
            CarFormBack.Click += CarFormBack_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(393, 234);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(97, 27);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Zapisz";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += FormSubmitButton_Click;
            // 
            // ManYearBox
            // 
            ManYearBox.Location = new Point(235, 180);
            ManYearBox.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            ManYearBox.Name = "ManYearBox";
            ManYearBox.Size = new Size(166, 23);
            ManYearBox.TabIndex = 10;
            ManYearBox.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // EngineLabel
            // 
            EngineLabel.AutoSize = true;
            EngineLabel.Location = new Point(140, 148);
            EngineLabel.Name = "EngineLabel";
            EngineLabel.Size = new Size(35, 15);
            EngineLabel.TabIndex = 9;
            EngineLabel.Text = "Silnik";
            // 
            // ManYearLabel
            // 
            ManYearLabel.AutoSize = true;
            ManYearLabel.Location = new Point(140, 180);
            ManYearLabel.Name = "ManYearLabel";
            ManYearLabel.Size = new Size(80, 15);
            ManYearLabel.TabIndex = 7;
            ManYearLabel.Text = "Rok produkcji";
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Location = new Point(140, 90);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(40, 15);
            BrandLabel.TabIndex = 6;
            BrandLabel.Text = "Marka";
            // 
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.Location = new Point(140, 122);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(41, 15);
            ModelLabel.TabIndex = 5;
            ModelLabel.Text = "Model";
            // 
            // LicensePlateLabel
            // 
            LicensePlateLabel.AutoSize = true;
            LicensePlateLabel.Location = new Point(140, 59);
            LicensePlateLabel.Name = "LicensePlateLabel";
            LicensePlateLabel.Size = new Size(89, 15);
            LicensePlateLabel.TabIndex = 4;
            LicensePlateLabel.Text = "Nr rejestracyjny";
            // 
            // EngineBox
            // 
            EngineBox.Location = new Point(235, 151);
            EngineBox.Name = "EngineBox";
            EngineBox.Size = new Size(166, 23);
            EngineBox.TabIndex = 3;
            // 
            // ModelBox
            // 
            ModelBox.Location = new Point(235, 122);
            ModelBox.Name = "ModelBox";
            ModelBox.Size = new Size(166, 23);
            ModelBox.TabIndex = 2;
            // 
            // BrandBox
            // 
            BrandBox.Location = new Point(235, 90);
            BrandBox.Name = "BrandBox";
            BrandBox.Size = new Size(166, 23);
            BrandBox.TabIndex = 1;
            // 
            // LicensePlateBox
            // 
            LicensePlateBox.Location = new Point(235, 59);
            LicensePlateBox.Name = "LicensePlateBox";
            LicensePlateBox.Size = new Size(166, 23);
            LicensePlateBox.TabIndex = 0;
            // 
            // RepairHistoryTab
            // 
            RepairHistoryTab.Controls.Add(DeleteRepairButton);
            RepairHistoryTab.Controls.Add(EditRepairButton);
            RepairHistoryTab.Controls.Add(AddRepairButton);
            RepairHistoryTab.Controls.Add(RepairsTable);
            RepairHistoryTab.Location = new Point(4, 24);
            RepairHistoryTab.Name = "RepairHistoryTab";
            RepairHistoryTab.Padding = new Padding(3);
            RepairHistoryTab.Size = new Size(1059, 585);
            RepairHistoryTab.TabIndex = 2;
            RepairHistoryTab.Text = "Historia napraw";
            RepairHistoryTab.UseVisualStyleBackColor = true;
            // 
            // DeleteRepairButton
            // 
            DeleteRepairButton.Location = new Point(803, 212);
            DeleteRepairButton.Name = "DeleteRepairButton";
            DeleteRepairButton.Size = new Size(161, 30);
            DeleteRepairButton.TabIndex = 10;
            DeleteRepairButton.Text = "Usuń naprawę";
            DeleteRepairButton.UseVisualStyleBackColor = true;
            // 
            // EditRepairButton
            // 
            EditRepairButton.Location = new Point(803, 164);
            EditRepairButton.Name = "EditRepairButton";
            EditRepairButton.Size = new Size(161, 30);
            EditRepairButton.TabIndex = 9;
            EditRepairButton.Text = "Edytuj naprawę";
            EditRepairButton.UseVisualStyleBackColor = true;
            // 
            // AddRepairButton
            // 
            AddRepairButton.Location = new Point(803, 116);
            AddRepairButton.Name = "AddRepairButton";
            AddRepairButton.Size = new Size(161, 31);
            AddRepairButton.TabIndex = 8;
            AddRepairButton.Text = "Dodaj naprawę";
            AddRepairButton.UseVisualStyleBackColor = true;
            AddRepairButton.Click += AddRepairButton_Click;
            // 
            // RepairsTable
            // 
            RepairsTable.AllowUserToAddRows = false;
            RepairsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RepairsTable.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            RepairsTable.Location = new Point(397, 47);
            RepairsTable.MultiSelect = false;
            RepairsTable.Name = "RepairsTable";
            RepairsTable.ReadOnly = true;
            RepairsTable.RowHeadersVisible = false;
            RepairsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RepairsTable.Size = new Size(207, 486);
            RepairsTable.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Data";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Przebieg";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // RepairFormTab
            // 
            RepairFormTab.Controls.Add(RepFromNewPartSubButton);
            RepairFormTab.Controls.Add(label2);
            RepairFormTab.Controls.Add(label1);
            RepairFormTab.Controls.Add(RepFromNewPartDesc);
            RepairFormTab.Controls.Add(RepFromNewPartNr);
            RepairFormTab.Controls.Add(label5);
            RepairFormTab.Controls.Add(label4);
            RepairFormTab.Controls.Add(label3);
            RepairFormTab.Controls.Add(RepFromPartsDropDown);
            RepairFormTab.Controls.Add(RepFromTable);
            RepairFormTab.Controls.Add(DatePickerRepairForm);
            RepairFormTab.Controls.Add(RepairFormBackButton);
            RepairFormTab.Controls.Add(RepairFormSaveButton);
            RepairFormTab.Controls.Add(MilagePickerRepairForm);
            RepairFormTab.Controls.Add(MilageRepairFormLabel);
            RepairFormTab.Controls.Add(DescLabelRepFrom);
            RepairFormTab.Controls.Add(RepairFormLabelDate);
            RepairFormTab.Controls.Add(DescRepairFormBox);
            RepairFormTab.Location = new Point(4, 24);
            RepairFormTab.Name = "RepairFormTab";
            RepairFormTab.Padding = new Padding(3);
            RepairFormTab.Size = new Size(1059, 585);
            RepairFormTab.TabIndex = 3;
            RepairFormTab.Text = "Formularz naprawy";
            RepairFormTab.UseVisualStyleBackColor = true;
            // 
            // RepFromNewPartSubButton
            // 
            RepFromNewPartSubButton.Location = new Point(217, 193);
            RepFromNewPartSubButton.Name = "RepFromNewPartSubButton";
            RepFromNewPartSubButton.Size = new Size(97, 27);
            RepFromNewPartSubButton.TabIndex = 35;
            RepFromNewPartSubButton.Text = "Dodaj";
            RepFromNewPartSubButton.UseVisualStyleBackColor = true;
            RepFromNewPartSubButton.Click += RepFromNewPartSubButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 281);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 34;
            label2.Text = "Opis";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 238);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 33;
            label1.Text = "Numer części";
            // 
            // RepFromNewPartDesc
            // 
            RepFromNewPartDesc.Location = new Point(129, 278);
            RepFromNewPartDesc.Name = "RepFromNewPartDesc";
            RepFromNewPartDesc.Size = new Size(129, 23);
            RepFromNewPartDesc.TabIndex = 32;
            // 
            // RepFromNewPartNr
            // 
            RepFromNewPartNr.Location = new Point(129, 238);
            RepFromNewPartNr.Name = "RepFromNewPartNr";
            RepFromNewPartNr.Size = new Size(129, 23);
            RepFromNewPartNr.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 199);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 30;
            label5.Text = "Dodaj nową część";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 365);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 29;
            label4.Text = "Wybierz użytą część";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 238);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 28;
            label3.Text = "Dodane części";
            // 
            // RepFromPartsDropDown
            // 
            RepFromPartsDropDown.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            RepFromPartsDropDown.AutoCompleteSource = AutoCompleteSource.ListItems;
            RepFromPartsDropDown.DisplayMember = "Value";
            RepFromPartsDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            RepFromPartsDropDown.FormattingEnabled = true;
            RepFromPartsDropDown.Location = new Point(208, 362);
            RepFromPartsDropDown.Name = "RepFromPartsDropDown";
            RepFromPartsDropDown.Size = new Size(121, 23);
            RepFromPartsDropDown.TabIndex = 27;
            RepFromPartsDropDown.ValueMember = "Key";
            RepFromPartsDropDown.SelectedIndexChanged += PartDropDown_SelectedItemChanged;
            // 
            // RepFromTable
            // 
            RepFromTable.AllowUserToAddRows = false;
            RepFromTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RepFromTable.Columns.AddRange(new DataGridViewColumn[] { RepFromTableIdCol, RepFromTableNumCol, RepFromTableDescCol, RepFromTableQuant });
            RepFromTable.Location = new Point(393, 266);
            RepFromTable.MultiSelect = false;
            RepFromTable.Name = "RepFromTable";
            RepFromTable.ReadOnly = false;
            RepFromTable.RowHeadersVisible = false;
            RepFromTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RepFromTable.Size = new Size(308, 276);
            RepFromTable.TabIndex = 26;
            // 
            // RepFromTableIdCol
            // 
            RepFromTableIdCol.HeaderText = "Id";
            RepFromTableIdCol.Name = "Id";
            RepFromTableIdCol.ReadOnly = true;
            RepFromTableIdCol.Visible = false;
            // 
            // RepFromTableNumCol
            // 
            RepFromTableNumCol.HeaderText = "Numer";
            RepFromTableNumCol.Name = "RepFromTableNumCol";
            RepFromTableNumCol.ReadOnly = true;
            // 
            // RepFromTableDescCol
            // 
            RepFromTableDescCol.HeaderText = "Opis";
            RepFromTableDescCol.Name = "RepFromTableDescCol";
            RepFromTableDescCol.ReadOnly = true;
            // 
            // RepFromTableQuant
            // 
            RepFromTableQuant.HeaderText = "Podaj ilość";
            RepFromTableQuant.Name = "RepFromTableQuant";
            RepFromTableQuant.ReadOnly = false;
            RepFromTable.EditingControlShowing += RepFromTable_EditingControlShowing;           
            // 
            // DatePickerRepairForm
            // 
            DatePickerRepairForm.Location = new Point(393, 31);
            DatePickerRepairForm.Name = "DatePickerRepairForm";
            DatePickerRepairForm.Size = new Size(200, 23);
            DatePickerRepairForm.TabIndex = 25;
            // 
            // RepairFormBackButton
            // 
            RepairFormBackButton.Location = new Point(42, 453);
            RepairFormBackButton.Name = "RepairFormBackButton";
            RepairFormBackButton.Size = new Size(75, 23);
            RepairFormBackButton.TabIndex = 24;
            RepairFormBackButton.Text = "Wróć";
            RepairFormBackButton.UseVisualStyleBackColor = true;
            RepairFormBackButton.Click += RepairFormBackButton_Click;
            // 
            // RepairFormSaveButton
            // 
            RepairFormSaveButton.Location = new Point(899, 453);
            RepairFormSaveButton.Name = "RepairFormSaveButton";
            RepairFormSaveButton.Size = new Size(97, 27);
            RepairFormSaveButton.TabIndex = 23;
            RepairFormSaveButton.Text = "Zapisz";
            RepairFormSaveButton.UseVisualStyleBackColor = true;
            // 
            // MilagePickerRepairForm
            // 
            MilagePickerRepairForm.Location = new Point(393, 66);
            MilagePickerRepairForm.Maximum = new decimal(new int[] { 9000000, 0, 0, 0 });
            MilagePickerRepairForm.Name = "MilagePickerRepairForm";
            MilagePickerRepairForm.Size = new Size(200, 23);
            MilagePickerRepairForm.TabIndex = 22;
            MilagePickerRepairForm.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // MilageRepairFormLabel
            // 
            MilageRepairFormLabel.AutoSize = true;
            MilageRepairFormLabel.Location = new Point(298, 68);
            MilageRepairFormLabel.Name = "MilageRepairFormLabel";
            MilageRepairFormLabel.Size = new Size(52, 15);
            MilageRepairFormLabel.TabIndex = 19;
            MilageRepairFormLabel.Text = "Przebieg";
            // 
            // DescLabelRepFrom
            // 
            DescLabelRepFrom.AutoSize = true;
            DescLabelRepFrom.Location = new Point(298, 100);
            DescLabelRepFrom.Name = "DescLabelRepFrom";
            DescLabelRepFrom.Size = new Size(31, 15);
            DescLabelRepFrom.TabIndex = 18;
            DescLabelRepFrom.Text = "Opis";
            // 
            // RepairFormLabelDate
            // 
            RepairFormLabelDate.AutoSize = true;
            RepairFormLabelDate.Location = new Point(298, 37);
            RepairFormLabelDate.Name = "RepairFormLabelDate";
            RepairFormLabelDate.Size = new Size(31, 15);
            RepairFormLabelDate.TabIndex = 17;
            RepairFormLabelDate.Text = "Data";
            // 
            // DescRepairFormBox
            // 
            DescRepairFormBox.Location = new Point(393, 100);
            DescRepairFormBox.Multiline = true;
            DescRepairFormBox.Name = "DescRepairFormBox";
            DescRepairFormBox.Size = new Size(278, 114);
            DescRepairFormBox.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 637);
            Controls.Add(AppTabs);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)CarsTable).EndInit();
            AppTabs.ResumeLayout(false);
            CarsTableTab.ResumeLayout(false);
            CarsTableTab.PerformLayout();
            CarsFormTab.ResumeLayout(false);
            CarsFormTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ManYearBox).EndInit();
            RepairHistoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RepairsTable).EndInit();
            RepairFormTab.ResumeLayout(false);
            RepairFormTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RepFromTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)MilagePickerRepairForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CarsTable;
        private Button AddCarButton;
        private TabControl AppTabs;
        private TabPage CarsTableTab;
        private TabPage CarsFormTab;
        private TabPage RepairHistoryTab;
        private Label ManYearLabel;
        private Label BrandLabel;
        private Label ModelLabel;
        private Label LicensePlateLabel;
        private TextBox EngineBox;
        private TextBox ModelBox;
        private TextBox BrandBox;
        private TextBox LicensePlateBox;
        private Label EngineLabel;
        private NumericUpDown ManYearBox;
        private Button SaveButton;
        private Button CarFormBack;
        private Label LicPlatFilterLabel;
        private TextBox LicencePlateFilterBox;
        private Button CarsTableFilterButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn LicensePlate;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Engine;
        private DataGridViewTextBoxColumn ManufacturedYear;
        private Button EditCarButton;
        private Button DeleteCarButton;
        private Button ToRepairsButton;
        private DataGridView RepairsTable;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button DeleteRepairButton;
        private Button EditRepairButton;
        private Button AddRepairButton;
        private TabPage RepairFormTab;
        private DateTimePicker DatePickerRepairForm;
        private Button RepairFormBackButton;
        private Button RepairFormSaveButton;
        private NumericUpDown MilagePickerRepairForm;
        private Label label1;
        private Label label2;
        private Label MilageRepairFormLabel;
        private Label DescLabelRepFrom;
        private Label RepairFormLabelDate;
        private TextBox RepFromNewPartNr;
        private TextBox DescRepairFormBox;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView RepFromTable;
        private DataGridViewTextBoxColumn RepFromTableIdCol;
        private DataGridViewTextBoxColumn RepFromTableNumCol;
        private DataGridViewTextBoxColumn RepFromTableDescCol;
        private DataGridViewTextBoxColumn RepFromTableQuant;
        private ComboBox RepFromPartsDropDown;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox RepFromNewPartDesc;
        private Button RepFromNewPartSubButton;
    }
}
