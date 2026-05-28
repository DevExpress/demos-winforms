Imports System
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.MultiColumnReport

    ''' <summary>
    ''' Summary description for Report.
    ''' </summary>
    Public Partial Class Report
        Inherits XtraReport

        Shared Sub New()
            DevExpress.XtraReports.Expressions.ExpressionBindingDescriptor.SetPropertyDescription(GetType(Band), "PageBreak", New DevExpress.XtraReports.Expressions.ExpressionBindingDescription({"BeforePrint"}, 1000, Array.Empty(Of String)()))
        End Sub

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.MultiColumnName
            DisplayName = ReportNames.MultiColumn
        End Sub

        Private Sub Report_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            Dim report As XtraReport = TryCast(sender, XtraReport)
            Dim detailBand As DetailBand = TryCast(report.Bands(BandKind.Detail), DetailBand)
            detailBand.MultiColumn.Layout = If(CBool(columnLayoutParameter.Value), ColumnLayout.AcrossThenDown, ColumnLayout.DownThenAcross)
        End Sub
    End Class
End Namespace
