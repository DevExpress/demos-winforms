Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class TotalsLocation
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            CreateWaitDialog()
            InitializeComponent()
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

        Private Sub TotalsLocation_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            pivotGridControl1.ValueImages = CategoryImageList
            InitComboBoxes()
        End Sub

        Private Sub InitComboBoxes()
            rgColumnsLocation.SelectedIndex = If(pivotGridControl1.OptionsView.ColumnTotalsLocation = PivotTotalsLocation.Near, 0, 1)
            If pivotGridControl1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Near Then
                rgRowsLocation.SelectedIndex = 0
            ElseIf pivotGridControl1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Far Then
                rgRowsLocation.SelectedIndex = 1
            Else
                rgRowsLocation.SelectedIndex = 2
            End If
        End Sub

        Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As PivotFieldImageIndexEventArgs)
            If e.Field Is fieldCategoryName AndAlso Equals(e.ValueType, PivotGridValueType.Value) Then e.ImageIndex = GetCategoryIndexByName(e.Value)
        End Sub

        '<rgRowsLocation>
        Private Sub rgRow_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Select Case rgRowsLocation.SelectedIndex
                Case 0
                    pivotGridControl1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Near
                Case 1
                    pivotGridControl1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Far
                Case 2
                    pivotGridControl1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Tree
                    If Not pivotGridControl1.OptionsView.ShowRowTotals Then pivotGridControl1.OptionsView.ShowRowTotals = True
            End Select
        End Sub

        '</rgRowsLocation>
        '<rgColumnsLocation>
        Private Sub rgColumn_SelectedIndexChanged_1(ByVal sender As Object, ByVal e As EventArgs)
            Select Case rgColumnsLocation.SelectedIndex
                Case 0
                    pivotGridControl1.OptionsView.ColumnTotalsLocation = PivotTotalsLocation.Near
                Case 1
                    pivotGridControl1.OptionsView.ColumnTotalsLocation = PivotTotalsLocation.Far
            End Select
        End Sub
    '</rgColumnsLocation>
    End Class
End Namespace
