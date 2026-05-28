Imports System.Drawing
Imports DevExpress.Drawing
Imports DevExpress.XtraCharts

Namespace XtraReportsDemos.Charts

    Public Partial Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Dim currentYear As Integer = 2025
            Me.CurrentYear.Value = New System.DateTime(currentYear, 1, 1)
            Name = ReportNames.ChartName
            DisplayName = ReportNames.Chart
        End Sub

        Private Sub xrChart6_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            Dim color As Color = xrChart3.PaletteRepository("Palette 1")(DetailReport2.CurrentRowIndex).Color
            xrChart6.PaletteRepository("Palette 1")(0).Color = color
            xrChart6.Series(0).Points.BeginUpdate()
            xrChart6.Series(0).Points.Clear()
            Dim categorySalesValue As Long = DetailReport2.GetCurrentColumnValue(Of Long)("Sales")
            Dim totalSalesValue As Decimal = DetailReport2.GetCurrentColumnValue(Of Decimal)("Totals")
            Dim otherSalesValue As Decimal = totalSalesValue - categorySalesValue
            xrChart6.Series(0).Points.Add(New SeriesPoint("Category Sales", categorySalesValue))
            xrChart6.Series(0).Points.Add(New SeriesPoint("Other Sales", otherSalesValue))
            xrChart6.Series(0).Points.EndUpdate()
            Dim percentageOfSales As Decimal = If(totalSalesValue = 0, 0, categorySalesValue / totalSalesValue)
            CType(xrChart6.Series(0).View, DoughnutSeriesView).TotalLabel.TextPattern = String.Format("{0:0%}", percentageOfSales)
            CType(xrChart6.Series(0).View, DoughnutSeriesView).TotalLabel.TextColor = color
        End Sub

        Private Sub xrChart_CustomDrawLegendMarker(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgsBase)
            Dim markerImage As DXBitmap = New DXBitmap(e.LegendMarkerSize.Width, e.LegendMarkerSize.Height)
            Using gr As DXGraphics = DXGraphics.FromImage(markerImage)
                gr.Clear(e.LegendDrawOptions.Color)
            End Using

            e.DXLegendMarkerImage = markerImage
        End Sub
    End Class
End Namespace
