Imports System
Imports DevExpress.AIIntegration

Namespace DevExpress.AI.Demos.Helpers

    Public Class AIExceptionHandler
        Implements IAIExceptionHandler

        Public Sub ProcessException(ByVal args As AIExceptionArgs) Implements IAIExceptionHandler.ProcessException
            If Not(TypeOf args.Exception Is AIDemoException) Then args.Exception = New Exception("Something went wrong.", args.Exception)
        End Sub
    End Class

    '
    Public Class AIDemoException
        Inherits Exception

        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class
End Namespace
