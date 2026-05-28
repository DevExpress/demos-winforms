Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Public Partial Class DrillDownForm
        Inherits XtraForm

        Private dataSource As PivotDrillDownDataSource

        Public Sub New(ByVal dataSource As PivotDrillDownDataSource)
            Me.dataSource = dataSource
            InitializeComponent()
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", GetType(DrillDownForm).Assembly)
            gridControl1.DataSource = dataSource
            CType(gridControl1.MainView, GridView).OptionsView.ShowGroupPanel = False
        End Sub

        Public Overloads Sub ShowDialog()
            If dataSource.RowCount = 0 Then
                XtraMessageBox.Show("DrillDown doesn't contains results")
            Else
                MyBase.ShowDialog()
            End If
        End Sub
    End Class
End Namespace
