Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class FormatRules
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

        Private Sub StyleConditions_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.BeginUpdate()
            pivotGridControl1.DataSource = GetNWindData("SalesPerson")
            fieldYear.FilterValues.SetValues(New Object() {2015}, PivotFilterType.Included, False)
            pivotGridControl1.OptionsCustomization.AllowFilterBySummary = False
            pivotGridControl1.OptionsCustomization.AllowSortBySummary = False
            pivotGridControl1.EndUpdate()
        End Sub

        Private Sub pivotGridControl1_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub
    End Class
End Namespace
