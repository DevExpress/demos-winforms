using System.Drawing;
using System.IO;
using System.Text;
using DevExpress.Office;
using DevExpress.Spreadsheet;
using DevExpress.Utils;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class CustomTooltipModule : SpreadsheetRibbonTutorialControlBase {
        IWorkbook book;
        Worksheet sheet;
        CellCollection cells;

        public CustomTooltipModule() {
            InitializeComponent();
            toolTipController1.GetActiveObjectInfo += toolTipController1_GetActiveObjectInfo;

            employeesTableAdapter.Fill(nwindDataSet.Employees);
            InitWorkbook();
            spreadsheetControl1.Document.History.Clear();
        }

        void CustomTooltipModule_Load(object sender, System.EventArgs e) {
            toolTipController1.Appearance.BackColor = Color.Violet;
            toolTipController1.Appearance.ForeColor = Color.Violet;
        }

        void SetColumnsWidth() {
            sheet.Columns["A"].WidthInCharacters = 4.82;
            sheet.Columns["B"].WidthInCharacters = 3.57;
            sheet.Columns["C"].WidthInCharacters = 16.43;
            sheet.Columns["D"].WidthInCharacters = 16.43;
            sheet.Columns["E"].WidthInCharacters = 27.86;
        }

        void GenerateSheetTitle() {
            CellRange range = sheet["B2:E2"];
            range.Merge();
            cells["B2"].Value = "EMPLOYEES";
            Formatting style = range.BeginUpdateFormatting();
            try {
                style.Font.Name = "Segoe";
                style.Font.Size = 13.5;
                style.Font.Color = Color.FromArgb(60, 60, 60);
                style.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                style.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
                style.Borders.SetAllBorders(Color.White, BorderLineStyle.Thin);
            }
            finally {
                range.EndUpdateFormatting(style);
            }
            sheet.Rows[1].Height = 36;
        }

        void GenerateTableTitle() {
            cells["B3"].Value = "#";
            cells["C3"].Value = "Last Name";
            cells["D3"].Value = "First Name";
            cells["E3"].Value = "Title";
            CellRange range = sheet["B3:E3"];
            Formatting style = range.BeginUpdateFormatting();
            try {
                style.Fill.BackgroundColor = Color.FromArgb(255, 229, 152);
                style.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
                style.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                style.Alignment.Indent = 1;
                style.Font.Size = 9;
                style.Font.Color = Color.FromArgb(60, 60, 60);
                style.Font.Name = "Segoe";
                style.Borders.SetAllBorders(Color.White, BorderLineStyle.Thin);
            }
            finally {
                range.EndUpdateFormatting(style);
            }
            cells["E3"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
            cells["E3"].Alignment.Indent = 1;
        }

        void GenerateTable() {
            GenerateTableTitle();
            CellRange range;
            Formatting style;
            for(int i = 0; i < nwindDataSet.Employees.Rows.Count; i++) {
                nwindDataSet.EmployeesRow row = (nwindDataSet.EmployeesRow)nwindDataSet.Employees.Rows[i];
                int rowIndex = i + 4;
                cells["B" + rowIndex].Value = i + 1;
                cells["C" + rowIndex].Value = row.LastName;
                cells["D" + rowIndex].Value = row.FirstName;
                cells["E" + rowIndex].Value = row.Title;
                range = sheet["B" + rowIndex + ":E" + rowIndex];
                style = range.BeginUpdateFormatting();
                try {
                    style.Borders.SetAllBorders(Color.White, BorderLineStyle.Thin);
                    style.Borders.SetAllBorders(Color.FromArgb(138, 138, 138), BorderLineStyle.Thin);
                    style.Font.Size = 9;
                    style.Font.Color = Color.FromArgb(60, 60, 60);
                    style.Font.Name = "Segoe";
                    style.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
                    style.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                    style.Alignment.Indent = 1;
                    style.Fill.BackgroundColor = i % 2 == 0 ? Color.FromArgb(251, 251, 252) : Color.FromArgb(238, 238, 241);
                    style.Borders.SetAllBorders(Color.White, BorderLineStyle.Thin);
                }
                finally {
                    range.EndUpdateFormatting(style);
                }
                cells["B" + rowIndex].Fill.BackgroundColor = i % 2 == 0 ? Color.FromArgb(255, 239, 191) : Color.FromArgb(255, 229, 152);
                cells["B" + rowIndex].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            }
            sheet["B2:E" + (nwindDataSet.Employees.Rows.Count + 3)].Borders.SetOutsideBorders(Color.FromArgb(138, 138, 138), BorderLineStyle.Thin);
        }

        void InitWorkbook() {
            book = spreadsheetControl1.Document;
            sheet = book.Worksheets[0];
            cells = sheet.Cells;
            book.Unit = DocumentUnit.Point;
            spreadsheetControl1.BeginUpdate();
            sheet.DefaultRowHeight = 23;
            sheet.Name = "Employees";
            SetColumnsWidth();
            GenerateSheetTitle();
            GenerateTable();
            sheet.SelectedCell = sheet["G14"];
            spreadsheetControl1.EndUpdate();
        }

        void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e) {
            if(e.SelectedControl != spreadsheetControl1)
                return;
            Cell cell = spreadsheetControl1.GetCellFromPoint(new PointF(e.ControlMousePosition.X, e.ControlMousePosition.Y));
            if(cell == null)
                return;
            int dataRowIndex = cell.RowIndex - 3;
            if(dataRowIndex >= nwindDataSet.Employees.Rows.Count || dataRowIndex < 0)
                return;
            if(cell.ColumnIndex > 4 || cell.ColumnIndex < 1)
                return;
            ToolTipControlInfo info = new ToolTipControlInfo(cell, string.Empty);
            info.ToolTipType = ToolTipType.SuperTip;
            nwindDataSet.EmployeesRow row = (nwindDataSet.EmployeesRow)nwindDataSet.Employees.Rows[dataRowIndex];

            SuperToolTip sToolTip = new SuperToolTip();
            sToolTip.MaxWidth = 430;
            //sToolTip.Padding = new System.Windows.Forms.Padding(14);

            ToolTipItem item = new ToolTipItem();
            byte[] bytes = row.Photo;
            item.Image = new Bitmap(new MemoryStream(bytes));
            item.Text = GenerateToolTipText(row);
            item.AllowHtmlText = DefaultBoolean.True;
            item.Appearance.BackColor = Color.Blue;

            sToolTip.Items.Add(item);
            info.SuperTip = sToolTip;
            e.Info = info;

        }

        string GenerateToolTipText(nwindDataSet.EmployeesRow row) {
            StringBuilder toolTipTextBuilder = new StringBuilder();
            string openColorTag = "<color=#C5A465><b>";
            string closeColorTag = "</b></color>";
            string interval = "<size=5> </size>";
            string interval2 = "<size=1> </size>";
            toolTipTextBuilder.AppendLine("<size=18>" + row.LastName + " " + row.FirstName + "</size>");
            toolTipTextBuilder.AppendLine(interval2);
            toolTipTextBuilder.AppendLine("<size=9>" + row.Title + "</size>");
            toolTipTextBuilder.AppendLine();
            toolTipTextBuilder.AppendLine(interval2);
            toolTipTextBuilder.AppendLine(openColorTag + "BirthDate: " + closeColorTag + " " + row.BirthDate.ToString("MM/dd/yyyy"));
            toolTipTextBuilder.AppendLine(interval);
            toolTipTextBuilder.AppendLine(openColorTag + "HireDate: " + closeColorTag + " " + row.HireDate.ToString("MM/dd/yyyy"));
            toolTipTextBuilder.AppendLine(interval);
            toolTipTextBuilder.Append(openColorTag + "Address: " + closeColorTag + " " + row.Address + ", " + row.City);
            if(!row.IsRegionNull())
                toolTipTextBuilder.Append(", " + row.Region);
            toolTipTextBuilder.Append(", " + row.PostalCode + ", " + row.Country);
            toolTipTextBuilder.AppendLine();
            toolTipTextBuilder.AppendLine(interval);
            toolTipTextBuilder.AppendLine(openColorTag + "HomePhone: " + closeColorTag + " " + row.HomePhone);
            toolTipTextBuilder.AppendLine(interval);
            toolTipTextBuilder.AppendLine(openColorTag + "Extension: " + closeColorTag + " " + row.Extension);
            return toolTipTextBuilder.ToString();
        }
    }
}
