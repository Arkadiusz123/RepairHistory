namespace RepairHistory.Shared
{
    public static class DataGridViewExtensions
    {
        public static string GetSelectedRowAttrib(this DataGridView dataGrid, string attribName)
        {
            try
            {
                var cell = dataGrid.CurrentCell.RowIndex;
                var selected = dataGrid.Rows[cell];
                var val = selected.Cells[attribName].Value;
                return (val ?? "").ToString();
            }
            catch (Exception)
            {
                return "";
            }

        }
    }
}
