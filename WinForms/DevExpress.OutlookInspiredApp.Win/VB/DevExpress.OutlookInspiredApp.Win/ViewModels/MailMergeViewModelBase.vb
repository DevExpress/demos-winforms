Imports System
Imports System.ComponentModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.DevAV.ViewModels

    Public MustInherit Class MailMergeViewModelBase(Of TMailTemplate As Structure)
        Implements ISupportParameter, IDocumentContent

        Private _DocumentOwnerProp As IDocumentOwner

        Public Overridable Property MailTemplate As TMailTemplate?

        Protected Overridable Sub OnMailTemplateChanged()
            RaiseMailTemplateChanged()
        End Sub

        Public Overridable Property IsMailTemplateSelected As Boolean

        Protected Overridable Sub OnIsMailTemplateSelectedChanged()
            RaiseMailTemplateSelectedChanged()
        End Sub

        Private Property Parameter As Object Implements ISupportParameter.Parameter
            Get
                Return MailTemplate
            End Get

            Set(ByVal value As Object)
                IsMailTemplateSelected = TypeOf value Is TMailTemplate
                If IsMailTemplateSelected Then
                    MailTemplate = CType(value, TMailTemplate)
                Else
                    MailTemplate = Nothing
                End If
            End Set
        End Property

        Public Event MailTemplateChanged As EventHandler

        Public Event MailTemplateSelectedChanged As EventHandler

        Private Sub RaiseMailTemplateChanged()
            Dim handler As EventHandler = MailTemplateChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Private Sub RaiseMailTemplateSelectedChanged()
            Dim handler As EventHandler = MailTemplateSelectedChangedEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Protected ReadOnly Property MessageBoxService As IMessageBoxService
            Get
                Return GetService(Of IMessageBoxService)()
            End Get
        End Property

        Public Property Modified As Boolean

        <Mvvm.DataAnnotations.Command>
        Public Function Close() As Boolean
            Dim result As MessageResult = MessageResult.Yes
            If Modified Then
                If MessageBoxService IsNot Nothing Then
                    result = MessageBoxService.Show("Do you want to save changes?", "Mail Merge", MessageButton.YesNoCancel, MessageIcon.Question, MessageResult.Yes)
                    If result = MessageResult.Yes Then RaiseSave()
                End If
            End If

            If result <> MessageResult.Cancel AndAlso DocumentOwnerProp IsNot Nothing Then DocumentOwnerProp.Close(Me)
            Return result <> MessageResult.Cancel
        End Function

        Public Event Save As EventHandler

        Private Sub RaiseSave()
            Dim handler As EventHandler = SaveEvent
            If handler IsNot Nothing Then handler(Me, EventArgs.Empty)
        End Sub

        Protected Property DocumentOwnerProp As IDocumentOwner
            Get
                Return _DocumentOwnerProp
            End Get

            Private Set(ByVal value As IDocumentOwner)
                _DocumentOwnerProp = value
            End Set
        End Property

#Region "IDocumentContent"
        Private ReadOnly Property Title As Object Implements IDocumentContent.Title
            Get
                Return "Mail Merge"
            End Get
        End Property

        Private Sub OnClose(ByVal e As CancelEventArgs) Implements IDocumentContent.OnClose
            e.Cancel = Not Close()
        End Sub

        Private Sub OnDestroy() Implements IDocumentContent.OnDestroy
        End Sub

        Private Property DocumentOwner As IDocumentOwner Implements IDocumentContent.DocumentOwner
            Get
                Return DocumentOwnerProp
            End Get

            Set(ByVal value As IDocumentOwner)
                DocumentOwnerProp = value
            End Set
        End Property
#End Region
    End Class
End Namespace
