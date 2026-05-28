Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Mvvm
Imports DevExpress.DevAV.Modules

Namespace DevExpress.DevAV

    Public MustInherit Class DocumentManagerServiceBase
        Implements IDocumentManagerService, IDocumentOwner

        Private documentsCore As IList(Of IDocument)

        Public Sub New()
            documentsCore = New List(Of IDocument)()
        End Sub

        Protected Function RegisterDocument(ByVal view As Object, ByVal createDocument As Func(Of Form, IDocument), ByVal createContainer As Func(Of Form), ByVal Optional id As Object = Nothing) As IDocument
            Dim container As Form = Nothing
            If createContainer IsNot Nothing Then
                container = createContainer()
                If container IsNot Nothing Then container.Owner = AppHelper.MainForm
            End If

            Dim document As IDocument = createDocument(container)
            document.Id = id
            documentsCore.Add(document)
            If view IsNot Nothing Then
                container.ClientSize = CType(view, Control).Size
                CType(view, Control).Dock = DockStyle.Fill
                CType(view, Control).Parent = container
                CType(view, Control).BringToFront()
            End If

            Return document
        End Function

        Protected Function EnsureViewModel(ByVal viewModel As Object, ByVal parameter As Object, ByVal parentViewModel As Object, ByVal view As Object) As Object
            If viewModel Is Nothing Then
                If TypeOf view Is ISupportViewModel Then viewModel = CType(view, ISupportViewModel).ViewModel
                EnsureModuleViewModel(view, parentViewModel, parameter)
            End If

            Dim documentContent As IDocumentContent = TryCast(viewModel, IDocumentContent)
            If documentContent IsNot Nothing Then documentContent.DocumentOwner = Me
            Return viewModel
        End Function

        Protected Friend Sub RemoveDocument(ByVal document As IDocument)
            documentsCore.Remove(document)
        End Sub

        Protected Function GetService(Of TService As Class)(ByVal viewModel As Object) As TService
            Return CType(viewModel, ISupportServices).ServiceContainer.GetService(Of TService)()
        End Function

#Region "IDocumentManagerService"
        Private Function CreateDocument(ByVal documentType As String, ByVal viewModel As Object, ByVal parameter As Object, ByVal parentViewModel As Object) As IDocument Implements IDocumentManagerService.CreateDocument
            Return CreateDocumentCore(documentType, viewModel, parentViewModel, parameter)
        End Function

        Private ReadOnly Property Documents As IEnumerable(Of IDocument) Implements IDocumentManagerService.Documents
            Get
                Return documentsCore
            End Get
        End Property

        Private Property ActiveDocument As IDocument Implements IDocumentManagerService.ActiveDocument
            Get
                Throw New NotImplementedException()
            End Get

            Set(ByVal value As IDocument)
                Throw New NotImplementedException()
            End Set
        End Property

        Private Custom Event ActiveDocumentChanged As ActiveDocumentChangedEventHandler Implements IDocumentManagerService.ActiveDocumentChanged
            AddHandler(ByVal value As ActiveDocumentChangedEventHandler)
            End AddHandler

            RemoveHandler(ByVal value As ActiveDocumentChangedEventHandler)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As ActiveDocumentChangedEventArgs)
            End RaiseEvent
        End Event

#End Region  ' IDocumentManagerService
        Private Sub Close(ByVal documentContent As IDocumentContent, Optional force As Boolean = True) Implements IDocumentOwner.Close
            Dim document = documentsCore.FirstOrDefault(Function(d) Equals(d.Content, documentContent))
            If document IsNot Nothing Then document.Close(force)
        End Sub

        Protected MustOverride Function CreateDocumentCore(ByVal documentType As String, ByVal viewModel As Object, ByVal parentViewModel As Object, ByVal parameter As Object) As IDocument
    End Class

    Public MustInherit Class DialogDocumentManagerService
        Inherits DocumentManagerServiceBase

#Region "Document"
        Protected Class DialogDocument
            Implements IDocument, IDocumentInfo

            Private ReadOnly contentCore As Object

            Private ReadOnly formCore As Form

            Private ReadOnly owner As DialogDocumentManagerService

            Private docState As DocumentState = DocumentState.Hidden

            Public Sub New(ByVal owner As DialogDocumentManagerService, ByVal dialogForm As Form, ByVal content As Object)
                Me.owner = owner
                formCore = dialogForm
                contentCore = content
                dialogForm.AutoValidate = AutoValidate.EnableAllowFocusChange
                AddHandler dialogForm.FormClosed, AddressOf form_Closed
            End Sub

            Private Sub form_Closed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
                owner.RemoveDocument(Me)
                RemoveHandler formCore.FormClosed, AddressOf form_Closed
            End Sub

            Private Sub Show() Implements IDocument.Show
                Using formCore
                    formCore.ShowDialog()
                End Using

                docState = DocumentState.Visible
            End Sub

            Private Sub Hide() Implements IDocument.Hide
                formCore.Close()
                docState = DocumentState.Hidden
            End Sub

            Private Sub Close(Optional force As Boolean = True) Implements IDocument.Close
                formCore.Close()
                docState = DocumentState.Hidden
            End Sub

            Private Property DestroyOnClose As Boolean Implements IDocument.DestroyOnClose
                Get
                    Return True
                End Get

                Set(ByVal value As Boolean)
                End Set
            End Property

            Private Property Id As Object Implements IDocument.Id

            Private Property Title As Object Implements IDocument.Title
                Get
                    Return formCore.Text
                End Get

                Set(ByVal value As Object)
                    formCore.Text = Convert.ToString(value)
                End Set
            End Property

            Private ReadOnly Property Content As Object Implements IDocument.Content
                Get
                    Return contentCore
                End Get
            End Property

            Private ReadOnly Property State As DocumentState Implements IDocumentInfo.State
                Get
                    Return docState
                End Get
            End Property

            Private ReadOnly Property DocumentType As String Implements IDocumentInfo.DocumentType
                Get
                    Return Nothing
                End Get
            End Property
        End Class
#End Region  ' Document
    End Class
End Namespace
