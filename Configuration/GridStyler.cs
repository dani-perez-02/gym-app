
namespace gym_app.Configuration
{
    internal static class GridStyler
    {
        public static void Apply(DataGridView grid)
        {
            grid.ColumnHeadersHeight = 38;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 243, 239); 
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(32, 42, 34);
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);

            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(32, 42, 34);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 235, 215); 
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 42, 34);
            grid.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);

            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 251, 249);
            grid.GridColor = Color.FromArgb(229, 231, 235);
        }
    }
}