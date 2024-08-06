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
            CarsTable = new DataGridView();
            LicensePlate = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            ManufacturedYear = new DataGridViewTextBoxColumn();
            AddCarButton = new Button();
            AppTabs = new TabControl();
            CarsTableTab = new TabPage();
            CarsFormTab = new TabPage();
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
            tabPage3 = new TabPage();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CarsTable).BeginInit();
            AppTabs.SuspendLayout();
            CarsTableTab.SuspendLayout();
            CarsFormTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ManYearBox).BeginInit();
            SuspendLayout();
            // 
            // CarsTable
            // 
            CarsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarsTable.Columns.AddRange(new DataGridViewColumn[] { LicensePlate, Brand, Model, ManufacturedYear });
            CarsTable.Location = new Point(37, 122);
            CarsTable.Name = "CarsTable";
            CarsTable.Size = new Size(444, 150);
            CarsTable.TabIndex = 0;
            // 
            // LicensePlate
            // 
            LicensePlate.HeaderText = "Nr rejestracyjny";
            LicensePlate.Name = "LicensePlate";
            // 
            // Brand
            // 
            Brand.HeaderText = "Marka";
            Brand.Name = "Brand";
            // 
            // Model
            // 
            Model.HeaderText = "Model";
            Model.Name = "Model";
            // 
            // ManufacturedYear
            // 
            ManufacturedYear.HeaderText = "Rok pordukcji";
            ManufacturedYear.Name = "ManufacturedYear";
            // 
            // AddCarButton
            // 
            AddCarButton.Location = new Point(338, 21);
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
            AppTabs.Controls.Add(tabPage3);
            AppTabs.Location = new Point(66, 17);
            AppTabs.Name = "AppTabs";
            AppTabs.SelectedIndex = 0;
            AppTabs.Size = new Size(528, 321);
            AppTabs.TabIndex = 2;
            // 
            // CarsTableTab
            // 
            CarsTableTab.Controls.Add(CarsTable);
            CarsTableTab.Controls.Add(AddCarButton);
            CarsTableTab.Location = new Point(4, 24);
            CarsTableTab.Name = "CarsTableTab";
            CarsTableTab.Padding = new Padding(3);
            CarsTableTab.Size = new Size(520, 293);
            CarsTableTab.TabIndex = 0;
            CarsTableTab.Text = "Pojazdy";
            CarsTableTab.UseVisualStyleBackColor = true;
            // 
            // CarsFormTab
            // 
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
            CarsFormTab.Size = new Size(520, 293);
            CarsFormTab.TabIndex = 1;
            CarsFormTab.Text = "Formularz pojazdu";
            CarsFormTab.UseVisualStyleBackColor = true;
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
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(520, 293);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(393, 234);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(97, 27);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Zapisz";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += AddSubmitButton_Click;
            // 
            // CarsTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AppTabs);
            Name = "CarsTableForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)CarsTable).EndInit();
            AppTabs.ResumeLayout(false);
            CarsTableTab.ResumeLayout(false);
            CarsFormTab.ResumeLayout(false);
            CarsFormTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ManYearBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CarsTable;
        private DataGridViewTextBoxColumn LicensePlate;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn ManufacturedYear;
        private Button AddCarButton;
        private TabControl AppTabs;
        private TabPage CarsTableTab;
        private TabPage CarsFormTab;
        private TabPage tabPage3;
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
    }
}
