Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.ReportMerging

    Public Class MergedReport
        Inherits NorthwindTraders.CatalogReport

        Private GroupFooter1 As GroupFooterBand

        Private parameterShowChartTitle As DevExpress.XtraReports.Parameters.Parameter

        Private chartSubreport As XRSubreport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.ReportMergingName
            DisplayName = ReportNames.ReportMerging
        End Sub

        Private Overloads Sub InitializeComponent()
            GroupFooter1 = New GroupFooterBand()
            chartSubreport = New XRSubreport()
            parameterShowChartTitle = New DevExpress.XtraReports.Parameters.Parameter()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' GroupFooter1
            ' 
            GroupFooter1.Controls.AddRange(New XRControl() {chartSubreport})
            GroupFooter1.HeightF = 23F
            GroupFooter1.Name = "GroupFooter1"
            ' 
            ' chartSubreport
            ' 
            chartSubreport.GenerateOwnPages = True
            chartSubreport.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            chartSubreport.Name = "chartSubreport"
            chartSubreport.ParameterBindings.Add(New ParameterBinding("ShowTitle", parameterShowChartTitle))
            chartSubreport.ParameterBindings.Add(New ParameterBinding("LowCategory", Nothing, "Products.CategoryID"))
            chartSubreport.ParameterBindings.Add(New ParameterBinding("HighCategory", Nothing, "Products.CategoryID"))
            chartSubreport.ReportSource = New ChartReport()
            chartSubreport.SizeF = New System.Drawing.SizeF(649F, 23F)
            ' 
            ' parameterShowChartTitle
            ' 
            parameterShowChartTitle.Description = "Show Chart Title"
            parameterShowChartTitle.Name = "parameterShowChartTitle"
            parameterShowChartTitle.Type = GetType(Boolean)
            parameterShowChartTitle.ValueInfo = "False"
            parameterShowChartTitle.Visible = False
            ' 
            ' MergedReport
            ' 
            Bands.AddRange(New Band() {GroupFooter1})
            Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {parameterShowChartTitle})
            ReportPrintOptions.DetailCountAtDesignTime = 6
            Version = "19.1"
            Controls.SetChildIndex(GroupFooter1, 0)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub
    End Class
End Namespace
