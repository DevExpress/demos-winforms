Imports System.Windows.Forms
Imports DevExpress.Charts.Heatmap
Imports DevExpress.Utils
Imports DevExpress.XtraCharts.Heatmap

Namespace DevExpress.XtraTreeMap.Demos

    Public Partial Class HeatmapKeyColorProvider
        Inherits TreeMapTutorialControl

        Public Overrides ReadOnly Property ActiveDemoModule As Control
            Get
                Return heatmapControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            CType(heatmapControl1.DataAdapter, HeatmapDataSourceAdapter).DataSource = CreateDataSet("PerformanceMonitoring.xml")
        End Sub

        Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs)
            Dim cell As HeatmapCell = CType(e.SelectedObject, HeatmapCell)
            Dim superToolTip As SuperToolTip = New SuperToolTip()
            superToolTip.Items.Add(New ToolTipItem() With {.Text = String.Format("Date: {0}", cell.XArgument)})
            superToolTip.Items.Add(New ToolTipItem() With {.Text = String.Format("Operation: {0}", cell.YArgument)})
            superToolTip.Items.Add(New ToolTipItem() With {.Text = String.Format("Response Time: {0}", cell.ColorValue)})
            e.SuperTip = superToolTip
        End Sub
    End Class
End Namespace
