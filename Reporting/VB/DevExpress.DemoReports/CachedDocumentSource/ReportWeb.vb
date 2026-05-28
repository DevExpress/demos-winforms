Namespace XtraReportsDemos.CachedDocumentSourceReport

    Public Class ReportWeb
        Inherits Report

        Public Sub New()
            Me.New(2500UI)
        End Sub

        Public Sub New(ByVal countParameter As UInteger)
            RowCountParameter.Value = countParameter
        End Sub
    End Class
End Namespace
