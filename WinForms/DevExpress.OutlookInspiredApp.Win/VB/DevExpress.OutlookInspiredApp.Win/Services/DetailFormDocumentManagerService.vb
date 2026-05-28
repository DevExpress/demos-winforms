Imports System
Imports System.Windows.Forms
Imports DevExpress.DevAV.Modules
Imports DevExpress.DevAV.Services
Imports DevExpress.Mvvm

Namespace DevExpress.DevAV

    Friend MustInherit Class DetailFormDocumentManagerServiceBase
        Inherits DocumentManagerServiceBase

        Private ReadOnly viewModuleType As ModuleType

        Public Sub New(ByVal viewModuleType As ModuleType)
            Me.viewModuleType = viewModuleType
        End Sub

#Region "Document"
        Protected Class DetailFormDocument
            Implements IDocument, IDocumentInfo

            Private ReadOnly contentCore As Object

            Private ReadOnly formCore As Form

            Private ReadOnly owner As DetailFormDocumentManagerServiceBase

            Private docState As DocumentState = DocumentState.Hidden

            Public Sub New(ByVal owner As DetailFormDocumentManagerServiceBase, ByVal form As Form, ByVal content As Object)
                Me.owner = owner
                formCore = form
                contentCore = content
                form.AutoValidate = AutoValidate.EnableAllowFocusChange
                AddHandler form.FormClosing, AddressOf form_Closing
                AddHandler form.FormClosed, AddressOf form_Closed
            End Sub

            Private Sub form_Closed(ByVal sender As Object, ByVal e As EventArgs)
                Dim formTitle = formCore.Text
                Dim parentViewModel = GetParentViewModel(Of ISupportNewParent)(contentCore)
                owner.RemoveDocument(Me)
                RemoveHandler formCore.FormClosing, AddressOf form_Closing
                RemoveHandler formCore.FormClosed, AddressOf form_Closed
                Dim documentContent As IDocumentContent = TryCast(GetContent(), IDocumentContent)
                If documentContent IsNot Nothing Then documentContent.OnDestroy()
                Call TryUpdateNew(GetContent(), formTitle, parentViewModel)
            End Sub

            Private Sub form_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
                Dim documentContent As IDocumentContent = TryCast(GetContent(), IDocumentContent)
                If documentContent IsNot Nothing Then documentContent.OnClose(e)
                If Not destroyOnCloseCore Then
                    Dim cancel As Boolean = e.Cancel
                    e.Cancel = True
                    If Not cancel Then formCore.Hide()
                End If
            End Sub

            Private Sub Show() Implements IDocument.Show
                If Not formCore.Visible Then
                    formCore.Show(AppHelper.MainForm)
                Else
                    formCore.Activate()
                End If

                docState = DocumentState.Visible
                Dim parentViewModel = GetParentViewModel(Of ISupportNewParent)(contentCore)
                If TypeOf contentCore Is ISupportNewChid AndAlso parentViewModel IsNot Nothing Then UpdateNew(parentViewModel)
            End Sub

            Private Sub Hide() Implements IDocument.Hide
                formCore.Hide()
                docState = DocumentState.Hidden
            End Sub

            Private Sub Close(Optional force As Boolean = True) Implements IDocument.Close
                If force Then
                    RemoveHandler formCore.FormClosing, AddressOf form_Closing
                    XtraEditors.Container.ContainerHelper.ClearUnvalidatedControl(formCore.ActiveControl, formCore)
                End If

                formCore.Close()
                docState = DocumentState.Hidden
            End Sub

            Private Shared Sub TryUpdateNew(ByVal content As Object, ByVal title As String, ByVal parentViewModel As ISupportNewParent)
                If TypeOf content Is ISupportNewChid AndAlso parentViewModel IsNot Nothing Then
                    If AppHelper.MainForm IsNot Nothing AndAlso title.EndsWith("(New)") Then Call AppHelper.MainForm.BeginInvoke(New Action(Of Object)(AddressOf UpdateNew), parentViewModel)
                End If
            End Sub

            Private Shared Sub UpdateNew(ByVal parameter As Object)
                Dim parentViewModel = TryCast(parameter, ISupportNewParent)
                If parentViewModel IsNot Nothing Then RaiseCanExecuteChanged(parentViewModel, "New")
            End Sub

            Private destroyOnCloseCore As Boolean = True

            Private Property DestroyOnClose As Boolean Implements IDocument.DestroyOnClose
                Get
                    Return destroyOnCloseCore
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
                    Return GetContent()
                End Get
            End Property

            Private Function GetContent() As Object
                Return contentCore
            End Function

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
        Protected Function IsDefaultViewModuleType(ByVal actualViewModuleType As ModuleType) As Boolean
            Return viewModuleType = actualViewModuleType
        End Function

        Protected Overridable Function GetActualViewModuleType(ByVal documentType As String, ByVal parentViewModel As Object) As ModuleType
            If Equals(documentType, "MapView") Then
                Dim resolver = GetService(Of IModuleTypesResolver)(parentViewModel)
                Return resolver.GetMapModuleType(viewModuleType)
            End If

            If Equals(documentType, "MailMerge") Then
                Dim resolver = GetService(Of IModuleTypesResolver)(parentViewModel)
                Return resolver.GetMailMergeModuleType(viewModuleType)
            End If

            If Equals(documentType, "Analysis") Then
                Dim resolver = GetService(Of IModuleTypesResolver)(parentViewModel)
                Return resolver.GetAnalysisModuleType(viewModuleType)
            End If

            If Equals(documentType, "OrderPdfQuickReportView") Then Return ModuleType.OrderPdfQuickReportView
            If Equals(documentType, "OrderXlsQuickReportView") Then Return ModuleType.OrderXlsQuickReportView
            If Equals(documentType, "OrderDocQuickReportView") Then Return ModuleType.OrderDocQuickReportView
            If Equals(documentType, "OrderRevenueView") Then Return ModuleType.OrderRevenueView
            Return viewModuleType
        End Function

        Protected Shared Function CreateView(ByVal parameter As Object, ByVal actualModuleType As ModuleType, ByVal moduleLocator As IModuleLocator) As Object
            If TypeOf parameter Is [Delegate] Then Return moduleLocator.CreateModule(actualModuleType)
            Dim initInfo = TryCast(parameter, ViewModel.ViewModelInitInfo)
            If initInfo IsNot Nothing AndAlso TypeOf initInfo.PrimaryKey Is Long Then Return moduleLocator.GetModule(actualModuleType, CLng(initInfo.PrimaryKey))
            If TypeOf parameter Is Long Then Return moduleLocator.GetModule(actualModuleType, CLng(parameter))
            Return moduleLocator.GetModule(actualModuleType)
        End Function

        Protected Function RegisterDetailFormDocumentForModule(ByVal viewModel As Object, ByVal parentViewModel As Object, ByVal parameter As Object, ByVal actualModuleType As ModuleType) As IDocument
            Dim waitingService = GetService(Of IWaitingService)(parentViewModel)
            Using waitingService.Enter(actualModuleType)
                Dim moduleLocator = GetService(Of IModuleLocator)(parentViewModel)
                Dim view As Object = CreateView(parameter, actualModuleType, moduleLocator)
                viewModel = EnsureViewModel(viewModel, parameter, parentViewModel, view)
                Return RegisterDocument(view, Function(container) New DetailFormDocument(Me, container, viewModel), Function() New DetailForm(), parameter)
            End Using
        End Function
    End Class

    Friend Class DetailFormDocumentManagerService
        Inherits DetailFormDocumentManagerServiceBase
        Implements IDocumentManagerService

        Public Sub New(ByVal viewModuleType As ModuleType)
            MyBase.New(viewModuleType)
        End Sub

        Protected Overrides Function CreateDocumentCore(ByVal documentType As String, ByVal viewModel As Object, ByVal parentViewModel As Object, ByVal parameter As Object) As IDocument
            Dim actualModuleType = GetActualViewModuleType(documentType, parentViewModel)
            Return RegisterDetailFormDocumentForModule(viewModel, parentViewModel, parameter, actualModuleType)
        End Function
    End Class

    Friend Class NotImplementedDetailFormDocumentManagerService
        Inherits DetailFormDocumentManagerServiceBase
        Implements IDocumentManagerService

        Public Sub New(ByVal viewModuleType As ModuleType)
            MyBase.New(viewModuleType)
        End Sub

        Protected Overrides Function CreateDocumentCore(ByVal documentType As String, ByVal viewModel As Object, ByVal parentViewModel As Object, ByVal parameter As Object) As IDocument
            Dim actualModuleType = GetActualViewModuleType(documentType, parentViewModel)
            Return If(IsDefaultViewModuleType(actualModuleType), New DXOverviewDocument(), RegisterDetailFormDocumentForModule(viewModel, parentViewModel, parameter, actualModuleType))
        End Function

#Region "DXAbout"
        Protected Class DXOverviewDocument
            Implements IDocument, IDocumentInfo

            Private overviewForm As XtraEditors.XtraForm = New XtraEditors.XtraForm()

            Private docState As DocumentState = DocumentState.Hidden

            Const captionText As String = "DevExpress"

            Const descriptionText As String = "You can easily create custom edit forms using the 40+ controls that ship as part of the DevExpress Data Editors Library.<br>" & "To see what you can build, <href=Employees>activate the Employees module.</href>"

#Region "IDocument Members"
            Private Sub Show() Implements IDocument.Show
                Dim overview As OverviewControl = New OverviewControl()
                overviewForm.MinimizeBox = False
                overviewForm.MaximizeBox = False
                overviewForm.FormBorderStyle = FormBorderStyle.FixedDialog
                overviewForm.Text = captionText
                overviewForm.ClientSize = overview.Size
                overviewForm.MinimumSize = overviewForm.Size
                overview.SetDescription(descriptionText)
                overview.Dock = DockStyle.Fill
                overview.Parent = overviewForm
                overviewForm.StartPosition = FormStartPosition.CenterParent
                overviewForm.IconOptions.SvgImage = AppIcon
                Using overviewForm
                    overviewForm.ShowDialog(AppHelper.MainForm)
                End Using

                docState = DocumentState.Visible
            End Sub

            Private ReadOnly Property Content As Object Implements IDocument.Content
                Get
                    Return Nothing
                End Get
            End Property

            Private Property DestroyOnClose As Boolean Implements IDocument.DestroyOnClose

            Private Sub Hide() Implements IDocument.Hide
                overviewForm.Close()
                docState = DocumentState.Hidden
            End Sub

            Private Sub Close(Optional force As Boolean = True) Implements IDocument.Close
                overviewForm.Close()
                docState = DocumentState.Hidden
            End Sub

            Private Property Title As Object Implements IDocument.Title

            Private Property Id As Object Implements IDocument.Id

#End Region
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
#End Region
    End Class
End Namespace
