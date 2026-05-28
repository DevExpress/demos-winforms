Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class ConditionalSortBySummary
        Inherits TutorialControl

        Public Sub New()
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
        Private Sub ConditionalSortBySummary_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.BeginUpdate()
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            fieldYear.FilterValues.ValuesIncluded = New Object() {2014}
            fieldSalesPerson.SortBySummaryInfo.Field = fieldDiscount
            fieldSalesPerson.SortBySummaryInfo.Conditions.Add(New PivotGridFieldSortCondition(fieldYear, 2014))
            fieldSalesPerson.SortBySummaryInfo.Conditions.Add(New PivotGridFieldSortCondition(fieldMonth, 8))
            pivotGridControl1.EndUpdate()
        End Sub
    '</pivotGridControl1>
    End Class
End Namespace
