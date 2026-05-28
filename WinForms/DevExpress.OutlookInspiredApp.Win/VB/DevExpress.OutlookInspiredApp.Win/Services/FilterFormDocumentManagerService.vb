Imports System
Imports System.Windows.Forms
Imports DevExpress.Mvvm
Imports DevExpress.DevAV.ViewModels

Namespace DevExpress.DevAV

    Friend Class FilterDialogDocumentManagerService
        Inherits DialogDocumentManagerService

        Private ReadOnly viewModuleType As ModuleType

        Public Sub New(ByVal viewModuleType As ModuleType)
            Me.viewModuleType = viewModuleType
        End Sub

        Protected Overrides Function CreateDocumentCore(ByVal documentType As String, ByVal viewModel As Object, ByVal parentViewModel As Object, ByVal parameter As Object) As IDocument
            Dim moduleLocator = GetService(Of Services.IModuleLocator)(parentViewModel)
            Dim view As Object = moduleLocator.GetModule(viewModuleType, viewModel)
            Return RegisterDocument(view, Function(form) New DialogDocument(Me, form, viewModel), Function() New FilterForm() With {.Text = documentType})
        End Function
    End Class

    Friend Class ViewSettingsDialogDocumentManagerService
        Inherits DialogDocumentManagerService

        Private collectionUIViewModelAccessor As Func(Of CollectionUIViewModel)

        Public Sub New(ByVal collectionUIViewModel As Func(Of CollectionUIViewModel))
            collectionUIViewModelAccessor = collectionUIViewModel
        End Sub

        Protected Overrides Function CreateDocumentCore(ByVal documentType As String, ByVal viewModel As Object, ByVal parentViewModel As Object, ByVal parameter As Object) As IDocument
            Dim view As Object = New Modules.ViewSettingsControl(collectionUIViewModelAccessor())
            viewModel = EnsureViewModel(viewModel, parameter, parentViewModel, view)
            Return RegisterDocument(view, Function(form) New ViewSettingsDialogDocument(Me, form, viewModel), Function() New FilterForm() With {.Text = documentType})
        End Function

#Region "Document"
        Private Class ViewSettingsDialogDocument
            Inherits DialogDocument

            Public Sub New(ByVal owner As ViewSettingsDialogDocumentManagerService, ByVal form As Form, ByVal content As Object)
                MyBase.New(owner, form, content)
                Dim viewModel = TryCast(content, ViewSettingsViewModel)
                If viewModel IsNot Nothing Then viewModel.Document = Me
            End Sub
        End Class
#End Region  ' Document
    End Class
End Namespace
