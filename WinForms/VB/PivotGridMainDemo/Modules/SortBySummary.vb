Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class SortBySummary
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

        Private Sub SortBySummary_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            fieldYear.FilterValues.FilterType = PivotFilterType.Included
            fieldYear.FilterValues.Add(2015)
            pivotGridControl1.HeaderImages = HeadersImageList
            fieldSalesPerson.ImageIndex = 0
        End Sub

        Private Sub pivotGridControl1_CustomDrawCell(ByVal sender As Object, ByVal e As PivotCustomDrawCellEventArgs)
            If ReferenceEquals(e.DataField, fieldSalesPerson.SortBySummaryInfo.Field) Then
                e.Appearance.FontStyleDelta = FontStyle.Bold
            End If
        End Sub
    End Class
End Namespace
