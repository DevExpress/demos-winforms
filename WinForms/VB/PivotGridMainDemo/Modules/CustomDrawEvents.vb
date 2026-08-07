Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class CustomDrawEvents
        Inherits TutorialControl

        Private highlightColor As Color

        Private dataSource As DataTable = New DataTable()

        Private cells As Object(,)

        Private difference As List(Of Point)

        Const colorStep As Integer = 25

        Private ReadOnly Property PointDifference As List(Of Point)
            Get
                If difference Is Nothing Then
                    Dim currentState As Object(,) = CellsState
                    difference = New List(Of Point)()
                    For i As Integer = cells.GetLowerBound(0) To cells.GetUpperBound(0)
                        For j As Integer = cells.GetLowerBound(1) To cells.GetUpperBound(1)
                            If Not Equals(cells(i, j), currentState(i, j)) Then difference.Add(New Point(i, j))
                        Next
                    Next
                End If

                Return difference
            End Get
        End Property

        Private Property LastCells As Object(,)
            Get
                Return cells
            End Get

            Set(ByVal value As Object(,))
                cells = value
                difference = Nothing
            End Set
        End Property

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            pivotGridControl1.OptionsCustomization.AllowFilterBySummary = False
        End Sub

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl1
            End Get
        End Property

        Private ReadOnly Property CellsState As Object(,)
            Get
                Dim result As Object(,) = New Object(pivotGridControl1.Cells.ColumnCount - 1, pivotGridControl1.Cells.RowCount - 1) {}
                For i As Integer = 0 To pivotGridControl1.Cells.ColumnCount - 1
                    For j As Integer = 0 To pivotGridControl1.Cells.RowCount - 1
                        result(i, j) = pivotGridControl1.Cells.GetCellInfo(i, j).Value
                    Next
                Next

                Return result
            End Get
        End Property

        Private Sub AddDataSourceRow()
            dataSource.Rows.Add("Category " & ((dataSource.Rows.Count + 1) Mod 2).ToString(), "Product " & ((dataSource.Rows.Count + 1) Mod 10).ToString(), Date.FromOADate(TutorialConstants.Random.Next(365) + New DateTime(2007, 1, 1).ToOADate()), TutorialConstants.Random.Next(1000))
        End Sub

        Private Sub HighlightChanges()
            highlightColor = Color.Red
            timer2.Enabled = True
        End Sub

        Private Function DecreaseColor(ByVal color As Color) As Color
            Return System.Drawing.Color.FromArgb(Math.Max(0, CInt(color.R) - colorStep), 0, 0)
        End Function

        Private Sub CustomDrawEvents_Load(ByVal sender As Object, ByVal e As EventArgs)
            dataSource.Columns.Add("Category", GetType(String))
            dataSource.Columns.Add("Product", GetType(String))
            dataSource.Columns.Add("OrderDate", GetType(Date))
            dataSource.Columns.Add("Amount", GetType(Integer))
            For i As Integer = 0 To 200 - 1
                AddDataSourceRow()
            Next

            pivotGridControl1.Fields.Add("Category", PivotArea.RowArea)
            pivotGridControl1.Fields.Add("Product", PivotArea.RowArea)
            pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea).GroupInterval = PivotGroupInterval.DateYear
            pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea).GroupInterval = PivotGroupInterval.DateQuarter
            pivotGridControl1.Fields.Add("Amount", PivotArea.DataArea)
            pivotGridControl1.DataSource = dataSource.DefaultView
            LastCells = CellsState
        End Sub

        '<pivotGridControl1>	
        Private Sub pivotGridControl1_CustomDrawFieldValue(ByVal sender As Object, ByVal e As PivotCustomDrawFieldValueEventArgs)
            Dim index As Integer = If(e.Area = PivotArea.ColumnArea, pivotGridControl1.Cells.FocusedCell.X, pivotGridControl1.Cells.FocusedCell.Y)
            If e.MinIndex <= index AndAlso index <= e.MaxIndex Then e.Appearance.FontStyleDelta = FontStyle.Bold
        End Sub

        Private Sub pivotGridControl1_CustomDrawCell(ByVal sender As Object, ByVal e As PivotCustomDrawCellEventArgs)
            Dim highlight As Boolean = highlightColor.R > 0 AndAlso PointDifference.Contains(New Point(e.ColumnIndex, e.RowIndex))
            If e.ColumnIndex = pivotGridControl1.Cells.FocusedCell.X AndAlso e.RowIndex = pivotGridControl1.Cells.FocusedCell.Y OrElse highlight Then e.Appearance.FontStyleDelta = FontStyle.Bold
            e.Appearance.ForeColor = If(highlight, highlightColor, Color.Black)
            If e.ColumnIndex = pivotGridControl1.Cells.FocusedCell.X OrElse e.RowIndex = pivotGridControl1.Cells.FocusedCell.Y Then e.Appearance.BackColor = Color.FromArgb(e.Appearance.BackColor.R - 10, e.Appearance.BackColor.G - 10, e.Appearance.BackColor.B - 10)
        End Sub

        '</pivotGridControl1>
        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If pivotGridControl1.IsDragging Then Return
            LastCells = CellsState
            AddDataSourceRow()
            pivotGridControl1.RefreshData()
            HighlightChanges()
        End Sub

        Private Sub timer2_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If pivotGridControl1.IsDragging Then Return
            highlightColor = DecreaseColor(highlightColor)
            pivotGridControl1.Invalidate()
            If highlightColor.R = 0 Then
                timer2.Enabled = False
                LastCells = CellsState
            End If
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            timer1.Enabled = True
        End Sub

        Protected Overrides Sub DoHide()
            timer1.Enabled = False
            MyBase.DoHide()
        End Sub

        Private Sub pivotGridControl1_FieldAreaChanged(ByVal sender As Object, ByVal e As PivotFieldEventArgs)
            LastCells = CellsState
        End Sub
    End Class
End Namespace
