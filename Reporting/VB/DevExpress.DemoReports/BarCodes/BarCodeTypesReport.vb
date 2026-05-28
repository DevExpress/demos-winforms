Imports System
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.BarCodes

    Public Partial Class BarCodeTypesReport
        Inherits XtraReport

        Shared Sub New()
            DevExpress.XtraReports.Expressions.ExpressionBindingDescriptor.SetPropertyDescription(GetType(XRBarCode), "AutoModule", New DevExpress.XtraReports.Expressions.ExpressionBindingDescription({"BeforePrint"}, 1000, Array.Empty(Of String)()))
        End Sub

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.BarCodes_BarcodeTypesName
            DisplayName = ReportNames.BarCodes_BarcodeTypes
        End Sub
    End Class
End Namespace
