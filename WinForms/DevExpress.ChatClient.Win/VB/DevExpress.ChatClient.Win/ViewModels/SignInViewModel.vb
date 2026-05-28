Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Data.Utils.Security
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.ChatClient.ViewModels

    Public Class SignInViewModel
        Implements IDocumentContent

        Private _UserName As String

        Public Shared Function Create(ByVal userName As String, ByVal salt As String) As SignInViewModel
            Return ViewModelSource.Create(Function() New SignInViewModel(userName, salt))
        End Function

        Private ReadOnly salt As String

        Protected Sub New(ByVal userName As String, ByVal salt As String)
            Me.UserName = userName
            Me.salt = salt
        End Sub

        Public Property UserName As String
            Get
                Return _UserName
            End Get

            Private Set(ByVal value As String)
                _UserName = value
            End Set
        End Property

        Private ReadOnly passwordData As SensitiveData = SensitiveData.CreateForCurrentUser()

        <BindableProperty, DataType(DataType.Password)>
        Public Overridable Property Password As String
            Get
                Return passwordData.Text
            End Get

            Set(ByVal value As String)
                passwordData.Text = value
            End Set
        End Property

        Private ReadOnly accessTokenData As SensitiveData = SensitiveData.CreateForCurrentUser()

        Public Property AccessToken As String
            Get
                Return accessTokenData.Text
            End Get

            Private Set(ByVal value As String)
                accessTokenData.Text = value
            End Set
        End Property

        Public Sub ShowDialog()
            Dim flyout = GetService(Of IDocumentManagerService)("Flyout")
            Dim document = flyout.CreateDocument(Me)
            document.Show()
        End Sub

        Public Sub SignInViaSocialNetwork()
            AccessToken = DevAV.Chat.DevAVEmpployeesInMemoryServer.GetPasswordHash(String.Empty, salt)
            CloseDocument()
        End Sub

        Public Sub SignIn()
            AccessToken = DevAV.Chat.DevAVEmpployeesInMemoryServer.GetPasswordHash(Password, salt)
            CloseDocument()
        End Sub

#Region "IDocumentContent"
        Private Sub CloseDocument()
            Dim owner = CType(Me, IDocumentContent).DocumentOwner
            owner?.Close(Me)
        End Sub

        Private ReadOnly Property Title As Object Implements IDocumentContent.Title
            Get
                Return String.Empty
            End Get
        End Property

        Private Property DocumentOwner As IDocumentOwner Implements IDocumentContent.DocumentOwner

        Private Sub OnClose(ByVal e As CancelEventArgs) Implements IDocumentContent.OnClose
        End Sub

        Private Sub OnDestroy() Implements IDocumentContent.OnDestroy
        End Sub
#End Region  ' IDocumentContent
    End Class
End Namespace
