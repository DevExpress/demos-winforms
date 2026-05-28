Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class PivotGridChartingDemo
        Inherits ChartDemoModuleWithOptions

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Dim dataSource As DataView = BindChartToData("SalesPerson")
            If dataSource Is Nothing Then Return
            pivotGridControl.DataSource = dataSource
            SetFilter()
            SetSelection()
            UpdateColorizerKeys()
            chart.DataSource = pivotGridControl
        End Sub

        Private Function BindChartToData(ByVal tableName As String) As DataView
            Dim ds As DataSet = New DataSet()
            Using connection As OleDbConnection = New OleDbConnection()
                Dim path As String = GetRelativePath("nwind.mdb")
                If path.Length > 0 Then
                    SetConnectionString(connection, path)
                Else
                    XtraMessageBox.Show("The ""nwind.mdb"" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return Nothing
                End If

                Try
                    File.SetAttributes(path, File.GetAttributes(path) And Not FileAttributes.ReadOnly)
                    Using adapter As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM " & tableName, connection)
                        adapter.Fill(ds, tableName)
                    End Using
                Catch e As OleDbException
                    XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return Nothing
                End Try
            End Using

            Return ds.Tables(tableName).DefaultView
        End Function

        <System.Diagnostics.CodeAnalysis.SuppressMessage("SpellChecker", "CRRSP01")>
        Private Sub SetFilter()
            fieldProductName.FilterValues.SetValues(New Object() {"Chai", "Chang", "Chocolade", "Filo Mix", "Geitost", "Ikura", "Konbu", "Maxilaku", "Pavlova", "Spegesild", "Tourtiere"}, PivotFilterType.Included, True)
            fieldOrderYear.FilterValues.SetValues(New Object() {2015}, PivotFilterType.Included, True)
        End Sub

        <System.Diagnostics.CodeAnalysis.SuppressMessage("SpellChecker", "CRRSP01")>
        Private Sub SetSelection()
            pivotGridControl.Cells.SetSelectionByFieldValues(False, New Object() {"Chocolade"})
            pivotGridControl.Cells.SetSelectionByFieldValues(False, New Object() {"Chai"})
        End Sub

        Private Sub UpdateColorizerKeys()
            Dim colorizer As SeriesKeyColorColorizer = CType(chart.SeriesTemplate.SeriesColorizer, SeriesKeyColorColorizer)
            colorizer.Keys.Clear()
            If checkEditGenerateSeriesByColumns.Checked Then
                FillColorizerKeysByColumns(colorizer.Keys)
            Else
                FillColorizerKeysByRows(colorizer.Keys)
            End If
        End Sub

        Private Sub FillColorizerKeysByRows(ByVal keys As KeyCollection)
            Dim count As Integer = Math.Min(pivotGridControl.Cells.RowCount - 1, pivotGridControl.OptionsChartDataSource.MaxAllowedSeriesCount)
            For i As Integer = 0 To count - 1
                keys.Add(pivotGridControl.GetFieldValue(fieldProductName, i))
            Next
        End Sub

        Private Sub FillColorizerKeysByColumns(ByVal keys As KeyCollection)
            Dim count As Integer = Math.Min(pivotGridControl.Cells.ColumnCount - 1, pivotGridControl.OptionsChartDataSource.MaxAllowedSeriesCount)
            For i As Integer = 0 To count - 1
                Dim monthNumber As Integer = CInt(pivotGridControl.GetFieldValue(fieldOrderDate, i))
                keys.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber))
            Next
        End Sub

        Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateColorizerKeys()
        End Sub

        Private Sub checkEditLabelVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            chart.SeriesTemplate.LabelsVisibility = CovertBoolToDefaultBoolean(checkEditLabelVisible.Checked)
            chart.CrosshairEnabled = CovertBoolToDefaultBoolean(Not checkEditLabelVisible.Checked)
        End Sub

        Private Sub checkEditGenerateSeriesByColumns_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim generateFromColumn As Boolean = checkEditGenerateSeriesByColumns.Checked
            pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = generateFromColumn
            lciShowRowGrandTotal.Enabled = generateFromColumn
            lciShowColumnGrandTotal.Enabled = Not generateFromColumn
        End Sub

        Private Sub checkEditSelectionOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl.OptionsChartDataSource.SelectionOnly = checkEditSelectionOnly.Checked
        End Sub

        Private Sub checkEditShowColumnGrandTotals_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl.OptionsChartDataSource.ProvideColumnGrandTotals = checkEditShowColumnGrandTotal.Checked
        End Sub

        Private Sub checkEditShowRowGrandTotals_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl.OptionsChartDataSource.ProvideRowGrandTotals = checkEditShowRowGrandTotal.Checked
        End Sub
    End Class
End Namespace
