namespace RepairHistory
{
    public partial class MainForm : Form
    {
        private readonly List<TabPage> hiddenTabs;

        public MainForm()
        {
            InitializeComponent();

            hiddenTabs = [CarsFormTab, RepairHistoryTab, RepairFormTab, RepairDetailsTab, PartFormTab];

            foreach (TabPage tab in hiddenTabs)
            {
                AppTabs.Controls.Remove(tab);
            }
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadCarsTable();
            await LoadAllPartsTable();
        }

        private void SwitchTab(TabPage tabPage)
        {
            if (!AppTabs.Controls.Contains(tabPage))
                AppTabs.Controls.Add(tabPage);

            AppTabs.SelectedTab = tabPage;

            var toRemove = hiddenTabs.Where(x => x != tabPage);

            foreach (TabPage tab in toRemove)
            {
                AppTabs.Controls.Remove(tab);
            }
        }
    }
}
