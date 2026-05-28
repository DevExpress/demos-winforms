Imports System.Windows.Forms
Imports DevExpress.XtraCharts.Heatmap

Namespace DevExpress.XtraTreeMap.Demos

    Public Partial Class HeatmapDataSourceAdapterDemo
        Inherits TreeMapTutorialControl

        Public Overrides ReadOnly Property ActiveDemoModule As Control
            Get
                Return heatmapControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            CType(heatmapControl1.DataAdapter, HeatmapDataSourceAdapter).DataSource = CreateDataSet("BalanceOfTrade.xml")
        End Sub
    End Class
End Namespace
