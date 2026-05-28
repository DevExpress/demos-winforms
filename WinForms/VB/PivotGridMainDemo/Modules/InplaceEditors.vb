Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class InplaceEditors
        Inherits TutorialControl

        Private cells As Object(,)

        Private difference As List(Of Point)

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property LastCells As Object(,)
            Get
                Return cells
            End Get

            Set(ByVal value As Object(,))
                cells = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property PointDifference As List(Of Point)
            Get
                Return difference
            End Get

            Set(ByVal value As List(Of Point))
                difference = value
            End Set
        End Property

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
        End Sub

        Public Overrides ReadOnly Property ViewOptionsControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Public Overrides ReadOnly Property ExportControl As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            pivotGridControl.BeginUpdate()
            pivotGridControl.DataSource = GetNWindData("SalesPerson")
            pivotGridControl.HeaderImages = HeadersImageList
            pivotGridControl.ValueImages = CategoryImageList
            fieldSalesPerson.ImageIndex = 0
            fieldExtendedPrice.ImageIndex = 3
            fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            fieldExtendedPrice.CellFormat.FormatString = "c2"
            pivotGridControl.EndUpdate()
            pivotGridControl.OptionsCustomization.AllowFilterBySummary = False
            pivotGridControl.OptionsCustomization.AllowSortBySummary = False
        End Sub

        Private Sub progressBar_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            Dim value As Integer = Convert.ToInt32(pivotGridControl.ActiveEditor.EditValue)
            If e.KeyChar = "+"c Then pivotGridControl.ActiveEditor.EditValue = Math.Min(value + 1, 99)
            If e.KeyChar = "-"c Then pivotGridControl.ActiveEditor.EditValue = Math.Max(value - 1, 0)
            e.Handled = True
        End Sub

        '<pivotGridControl>
        Private Sub pivotGridControl_CustomEditValue(ByVal sender As Object, ByVal e As CustomEditValueEventArgs)
            If ReferenceEquals(e.DataField, fieldPercents) Then e.Value = Convert.ToDouble(e.Value) * 100F
        End Sub

        Private Sub pivotGridControl_EditorValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            If ReferenceEquals(e.DataField, fieldExtendedPrice) Then
                ChangeCellValue(e, Convert.ToDecimal(e.Value), Convert.ToDecimal(e.Editor.EditValue))
            End If

            If ReferenceEquals(e.DataField, fieldPercents) Then
                Dim c0 As Decimal = Convert.ToDecimal(e.GetCellValue(fieldExtendedPrice))
                Dim p0 As Decimal = Convert.ToDecimal(e.Value)
                Dim p1 As Decimal = Convert.ToDecimal(e.Editor.EditValue)
                Dim newValue As Decimal = If(p0 = 0D OrElse p1 = 0D, 0D, c0 * (100D / p0 - 1D) / (100D / p1 - 1D))
                ChangeCellValue(e, c0, newValue)
            End If
        End Sub

        Private Sub ChangeCellValue(ByVal e As EditValueChangedEventArgs, ByVal oldValue As Decimal, ByVal newValue As Decimal)
            Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
            If ds.RowCount = 0 Then Return
            Dim difference As Decimal = newValue - oldValue
            Dim factor As Decimal = If(difference = newValue, difference / ds.RowCount, difference / oldValue)
            For i As Integer = 0 To ds.RowCount - 1
                Dim value As Decimal = Convert.ToDecimal(ds(i)(fieldExtendedPrice))
                ds(i)(fieldExtendedPrice) = If(value = 0D, factor, value * (1D + factor))
            Next
        End Sub

        '</pivotGridControl>
        Private Function GetCellsState(ByVal pivot As PivotGridControl) As Object(,)
            Dim result As Object(,) = New Object(pivot.Cells.ColumnCount - 1, pivot.Cells.RowCount - 1) {}
            For i As Integer = 0 To pivot.Cells.ColumnCount - 1
                For j As Integer = 0 To pivot.Cells.RowCount - 1
                    result(i, j) = pivot.Cells.GetCellInfo(i, j).Value
                Next
            Next

            Return result
        End Function

        Private Function CalculatePointDifference(ByVal lastCells As Object(,), ByVal currentState As Object(,)) As List(Of Point)
            If lastCells Is Nothing OrElse lastCells.Length = 0 OrElse lastCells.Length <> currentState.Length Then Return Nothing
            Dim difference As List(Of Point) = New List(Of Point)()
            For i As Integer = lastCells.GetLowerBound(0) To lastCells.GetUpperBound(0)
                For j As Integer = lastCells.GetLowerBound(1) To lastCells.GetUpperBound(1)
                    If Not Equals(lastCells(i, j), currentState(i, j)) Then difference.Add(New Point(i, j))
                Next
            Next

            Return difference
        End Function

        Private highlightColor As Color = Color.Red

        Private currentDifferences As List(Of Point) = New List(Of Point)()

        Private Sub pivotGridControl_CustomAppearance(ByVal sender As Object, ByVal e As PivotCustomAppearanceEventArgs)
            If PointDifference Is Nothing Then Return
            If PointDifference.Count <> 0 Then currentDifferences = New List(Of Point)(PointDifference)
            Dim highlight As Boolean = currentDifferences.Contains(New Point(e.ColumnIndex, e.RowIndex))
            If highlight Then
                e.Appearance.FontStyleDelta = FontStyle.Bold
                e.Appearance.ForeColor = highlightColor
            End If
        End Sub

        Private Function GetFocusedCellInfo(ByVal pivot As PivotGridControl) As PivotCellEventArgs
            Dim focusedCell As Point = pivot.Cells.FocusedCell
            Return pivot.Cells.GetCellInfo(focusedCell.X, focusedCell.Y)
        End Function

        Private Sub pivotGridControl_ShowingEditor(ByVal sender As Object, ByVal e As CancelPivotCellEditEventArgs)
            Dim cellInfo As PivotCellEventArgs = GetFocusedCellInfo(pivotGridControl)
            If cellInfo.RowValueType = PivotGridValueType.GrandTotal OrElse cellInfo.ColumnValueType = PivotGridValueType.GrandTotal Then e.Cancel = True
        End Sub

        Private Sub pivotGridControl_FieldValueImageIndex(ByVal sender As Object, ByVal e As PivotFieldImageIndexEventArgs)
            If e.Field Is fieldCategoryName AndAlso Equals(e.ValueType, PivotGridValueType.Value) Then e.ImageIndex = GetCategoryIndexByName(e.Value)
        End Sub

        Private Sub pivotGridControl_GridLayout(ByVal sender As Object, ByVal e As EventArgs)
            Dim currentCells As Object(,) = GetCellsState(pivotGridControl)
            PointDifference = CalculatePointDifference(LastCells, currentCells)
            LastCells = currentCells
        End Sub
    End Class
End Namespace
