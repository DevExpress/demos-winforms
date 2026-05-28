Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid.Demos.Helpers
Imports System
Imports System.Drawing

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class OLAPDrillDown
        Inherits TutorialControl

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            Dim success As Boolean = OLAPConfigurator.ConnectToAdventureWorks(pivotGridControl, True)
            controlPanel.Visible = Not success
            paddingPanel.Visible = Not success
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
            pivotGridControl.ExpandAll()
            pivotGridControl.Cells.FocusedCell = New Point(1, 12)
        End Sub

        '<pivotGridControl>
        Private Sub pivotGridControl_CellDoubleClick(ByVal sender As Object, ByVal e As PivotCellEventArgs)
            Try
                Using form As DrillDownForm = New DrillDownForm(e.CreateDrillDownDataSource())
                    form.ShowDialog()
                End Using
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)
            End Try
        End Sub
    '</pivotGridControl>
    End Class
End Namespace
