Imports System
Imports DevExpress.AIIntegration

Namespace XtraReportsDemos.AIOperations

    Public Class AIExceptionHandler
        Implements IAIExceptionHandler

        Public Sub ProcessException(ByVal args As AIExceptionArgs) Implements IAIExceptionHandler.ProcessException
            If Not(TypeOf args.Exception Is AIDemoException) Then args.Exception = New Exception("Something went wrong.", args.Exception)
        End Sub
    End Class
End Namespace
