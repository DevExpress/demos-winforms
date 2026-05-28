Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.DevAV.Chat.Model
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace DevExpress.ChatClient.ViewModels

    <EditorBrowsable(EditorBrowsableState.Never)>
    Public MustInherit Class UserInfoViewModel
        Implements IDocumentContent, ISupportParameter

        Private userInfo As UserInfo

        Protected Sub New(ByVal userInfo As UserInfo)
            Me.userInfo = userInfo
        End Sub

        Private Property Parameter As Object Implements ISupportParameter.Parameter
            Get
                Return userInfo
            End Get

            Set(ByVal value As Object)
                Dim info = TryCast(value, UserInfo)
                If userInfo Is info Then Return
                userInfo = info
                RaisePropertiesChanged()
            End Set
        End Property

        Public ReadOnly Property Id As Long
            Get
                Return userInfo.Id
            End Get
        End Property

        Public ReadOnly Property Name As String
            Get
                Return userInfo.Name
            End Get
        End Property

        Public ReadOnly Property Photo As Image
            Get
                Return userInfo.Photo
            End Get
        End Property

        Public ReadOnly Property MobilePhone As String
            Get
                Return userInfo.MobilePhone
            End Get
        End Property

        Public ReadOnly Property Email As String
            Get
                Return userInfo.Email
            End Get
        End Property

#Region "IDocumentContent"
        Protected Sub CloseDocument()
            Dim owner = CType(Me, IDocumentContent).DocumentOwner
            If owner IsNot Nothing Then owner.Close(Me)
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
        Protected Friend MustOverride ReadOnly Property ServiceKey As String
    End Class
End Namespace
