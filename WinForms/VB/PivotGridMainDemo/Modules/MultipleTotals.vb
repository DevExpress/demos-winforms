Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.PivotGrid

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class MultipleTotals
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

        '<pivotGridControl1>
        Private Sub MultipleTotals_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            fieldYear.Group.FilterValues.FilterType = PivotFilterType.Included
            fieldYear.Group.FilterValues.Values.Add(2015)
            pivotGridControl1.ValueImages = CategoryImageList
            InitCustomTotals()
        End Sub

        Private Sub InitCustomTotals()
            fieldCategoryName.TotalsVisibility = PivotTotalsVisibility.CustomTotals
            fieldCategoryName.CustomTotals.Add(PivotSummaryType.Average)
            fieldCategoryName.CustomTotals.Add(PivotSummaryType.Sum)
            fieldCategoryName.CustomTotals.Add(PivotSummaryType.Max)
            fieldCategoryName.CustomTotals.Add(PivotSummaryType.Min)
            fieldCategoryName.CustomTotals.Add(PivotSummaryType.Count)
        End Sub

        Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As PivotFieldImageIndexEventArgs)
            If e.Field Is fieldCategoryName AndAlso Equals(e.ValueType, PivotGridValueType.Value) Then e.ImageIndex = GetCategoryIndexByName(e.Value)
            If e.ValueType = PivotGridValueType.CustomTotal Then
                If e.CustomTotal.SummaryType = PivotSummaryType.Sum AndAlso e.Field.Area <> PivotArea.DataArea Then e.ImageIndex = 8
            End If
        End Sub
    '</pivotGridControl1>
    End Class
End Namespace
