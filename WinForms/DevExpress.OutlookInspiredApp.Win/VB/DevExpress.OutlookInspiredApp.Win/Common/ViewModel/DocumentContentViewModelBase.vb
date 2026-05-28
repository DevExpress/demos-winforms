Imports System.ComponentModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace DevExpress.DevAV

    Public MustInherit Class DocumentContentViewModelBase
        Implements IDocumentContent

        Protected Sub New()
        End Sub

        <Command>
        Public Sub Close()
            CType(Me, IDocumentContent).DocumentOwner.Close(Me)
        End Sub

#Region "IDocumentContent"
        Private Sub OnClose(ByVal e As CancelEventArgs) Implements IDocumentContent.OnClose
        End Sub

        Private Sub OnDestroy() Implements IDocumentContent.OnDestroy
        End Sub

        Private Property DocumentOwner As IDocumentOwner Implements IDocumentContent.DocumentOwner

        Private ReadOnly Property Title As Object Implements IDocumentContent.Title
            Get
                Return GetTitle()
            End Get
        End Property

        Protected Overridable Function GetTitle() As String
            Return Nothing
        End Function
#End Region
    End Class
End Namespace
