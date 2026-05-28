Imports System.Drawing
Imports System.IO
Imports System.Text
Imports DevExpress.Office
Imports DevExpress.Spreadsheet
Imports DevExpress.Utils

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class CustomTooltipModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Private book As IWorkbook

        Private sheet As Worksheet

        Private cells As CellCollection

        Public Sub New()
            InitializeComponent()
            AddHandler toolTipController1.GetActiveObjectInfo, AddressOf toolTipController1_GetActiveObjectInfo
            employeesTableAdapter.Fill(nwindDataSet.Employees)
            InitWorkbook()
            spreadsheetControl1.Document.History.Clear()
        End Sub

        Private Sub CustomTooltipModule_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            toolTipController1.Appearance.BackColor = Color.Violet
            toolTipController1.Appearance.ForeColor = Color.Violet
        End Sub

        Private Sub SetColumnsWidth()
            sheet.Columns("A").WidthInCharacters = 4.82
            sheet.Columns("B").WidthInCharacters = 3.57
            sheet.Columns("C").WidthInCharacters = 16.43
            sheet.Columns("D").WidthInCharacters = 16.43
            sheet.Columns("E").WidthInCharacters = 27.86
        End Sub

        Private Sub GenerateSheetTitle()
            Dim range As CellRange = sheet("B2:E2")
            range.Merge()
            cells("B2").Value = "EMPLOYEES"
            Dim style As Formatting = range.BeginUpdateFormatting()
            Try
                style.Font.Name = "Segoe"
                style.Font.Size = 13.5
                style.Font.Color = Color.FromArgb(60, 60, 60)
                style.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
                style.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
                style.Borders.SetAllBorders(Color.White, BorderLineStyle.Thin)
            Finally
                range.EndUpdateFormatting(style)
            End Try

            sheet.Rows(1).Height = 36
        End Sub

        Private Sub GenerateTableTitle()
            cells("B3").Value = "#"
            cells("C3").Value = "Last Name"
            cells("D3").Value = "First Name"
            cells("E3").Value = "Title"
            Dim range As CellRange = sheet("B3:E3")
            Dim style As Formatting = range.BeginUpdateFormatting()
            Try
                style.Fill.BackgroundColor = Color.FromArgb(255, 229, 152)
                style.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
                style.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
                style.Alignment.Indent = 1
                style.Font.Size = 9
                style.Font.Color = Color.FromArgb(60, 60, 60)
                style.Font.Name = "Segoe"
                style.Borders.SetAllBorders(Color.White, BorderLineStyle.Thin)
            Finally
                range.EndUpdateFormatting(style)
            End Try

            cells("E3").Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
            cells("E3").Alignment.Indent = 1
        End Sub

        Private Sub GenerateTable()
            GenerateTableTitle()
            Dim range As CellRange
            Dim style As Formatting
            For i As Integer = 0 To nwindDataSet.Employees.Rows.Count - 1
                Dim row As nwindDataSet.EmployeesRow = CType(nwindDataSet.Employees.Rows(i), nwindDataSet.EmployeesRow)
                Dim rowIndex As Integer = i + 4
                cells("B" & rowIndex).Value = i + 1
                cells("C" & rowIndex).Value = row.LastName
                cells("D" & rowIndex).Value = row.FirstName
                cells("E" & rowIndex).Value = row.Title
                range = sheet("B" & rowIndex & ":E" & rowIndex)
                style = range.BeginUpdateFormatting()
                Try
                    style.Borders.SetAllBorders(Color.White, BorderLineStyle.Thin)
                    style.Borders.SetAllBorders(Color.FromArgb(138, 138, 138), BorderLineStyle.Thin)
                    style.Font.Size = 9
                    style.Font.Color = Color.FromArgb(60, 60, 60)
                    style.Font.Name = "Segoe"
                    style.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
                    style.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left
                    style.Alignment.Indent = 1
                    style.Fill.BackgroundColor = If(i Mod 2 = 0, Color.FromArgb(251, 251, 252), Color.FromArgb(238, 238, 241))
                    style.Borders.SetAllBorders(Color.White, BorderLineStyle.Thin)
                Finally
                    range.EndUpdateFormatting(style)
                End Try

                cells("B" & rowIndex).Fill.BackgroundColor = If(i Mod 2 = 0, Color.FromArgb(255, 239, 191), Color.FromArgb(255, 229, 152))
                cells("B" & rowIndex).Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            Next

            sheet(CStr("B2:E" & nwindDataSet.Employees.Rows.Count + 3)).Borders.SetOutsideBorders(Color.FromArgb(138, 138, 138), BorderLineStyle.Thin)
        End Sub

        Private Sub InitWorkbook()
            book = spreadsheetControl1.Document
            sheet = book.Worksheets(0)
            cells = sheet.Cells
            book.Unit = DocumentUnit.Point
            spreadsheetControl1.BeginUpdate()
            sheet.DefaultRowHeight = 23
            sheet.Name = "Employees"
            SetColumnsWidth()
            GenerateSheetTitle()
            GenerateTable()
            sheet.SelectedCell = sheet("G14")
            spreadsheetControl1.EndUpdate()
        End Sub

        Private Sub toolTipController1_GetActiveObjectInfo(ByVal sender As Object, ByVal e As ToolTipControllerGetActiveObjectInfoEventArgs)
            If e.SelectedControl IsNot spreadsheetControl1 Then Return
            Dim cell As Cell = spreadsheetControl1.GetCellFromPoint(New PointF(e.ControlMousePosition.X, e.ControlMousePosition.Y))
            If cell Is Nothing Then Return
            Dim dataRowIndex As Integer = cell.RowIndex - 3
            If dataRowIndex >= nwindDataSet.Employees.Rows.Count OrElse dataRowIndex < 0 Then Return
            If cell.ColumnIndex > 4 OrElse cell.ColumnIndex < 1 Then Return
            Dim info As ToolTipControlInfo = New ToolTipControlInfo(cell, String.Empty)
            info.ToolTipType = ToolTipType.SuperTip
            Dim row As nwindDataSet.EmployeesRow = CType(nwindDataSet.Employees.Rows(dataRowIndex), nwindDataSet.EmployeesRow)
            Dim sToolTip As SuperToolTip = New SuperToolTip()
            sToolTip.MaxWidth = 430
            'sToolTip.Padding = new System.Windows.Forms.Padding(14);
            Dim item As ToolTipItem = New ToolTipItem()
            Dim bytes As Byte() = row.Photo
            item.Image = New Bitmap(New MemoryStream(bytes))
            item.Text = GenerateToolTipText(row)
            item.AllowHtmlText = DefaultBoolean.True
            item.Appearance.BackColor = Color.Blue
            sToolTip.Items.Add(item)
            info.SuperTip = sToolTip
            e.Info = info
        End Sub

        Private Function GenerateToolTipText(ByVal row As nwindDataSet.EmployeesRow) As String
            Dim toolTipTextBuilder As StringBuilder = New StringBuilder()
            Dim openColorTag As String = "<color=#C5A465><b>"
            Dim closeColorTag As String = "</b></color>"
            Dim interval As String = "<size=5> </size>"
            Dim interval2 As String = "<size=1> </size>"
            toolTipTextBuilder.AppendLine("<size=18>" & row.LastName & " " & row.FirstName & "</size>")
            toolTipTextBuilder.AppendLine(interval2)
            toolTipTextBuilder.AppendLine("<size=9>" & row.Title & "</size>")
            toolTipTextBuilder.AppendLine()
            toolTipTextBuilder.AppendLine(interval2)
            toolTipTextBuilder.AppendLine(openColorTag & "BirthDate: " & closeColorTag & " " & row.BirthDate.ToString("MM/dd/yyyy"))
            toolTipTextBuilder.AppendLine(interval)
            toolTipTextBuilder.AppendLine(openColorTag & "HireDate: " & closeColorTag & " " & row.HireDate.ToString("MM/dd/yyyy"))
            toolTipTextBuilder.AppendLine(interval)
            toolTipTextBuilder.Append(openColorTag & "Address: " & closeColorTag & " " & row.Address & ", " & row.City)
            If Not row.IsRegionNull() Then toolTipTextBuilder.Append(", " & row.Region)
            toolTipTextBuilder.Append(", " & row.PostalCode & ", " & row.Country)
            toolTipTextBuilder.AppendLine()
            toolTipTextBuilder.AppendLine(interval)
            toolTipTextBuilder.AppendLine(openColorTag & "HomePhone: " & closeColorTag & " " & row.HomePhone)
            toolTipTextBuilder.AppendLine(interval)
            toolTipTextBuilder.AppendLine(openColorTag & "Extension: " & closeColorTag & " " & row.Extension)
            Return toolTipTextBuilder.ToString()
        End Function
    End Class
End Namespace
