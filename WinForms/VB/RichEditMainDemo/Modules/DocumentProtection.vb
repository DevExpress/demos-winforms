Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraRichEdit.API.Native

Namespace DevExpress.XtraRichEdit.Demos

    Public Partial Class DocumentProtectionModule
        Inherits TutorialControl

        Private ReadOnly _userService As UserService = New UserService()

        Public Sub New()
            InitializeComponent()
            richEditControl.ReplaceService(_userService)
            LoadDocument("DocumentProtection.docx")
        End Sub

        Public Overrides ReadOnly Property RichEdit As RichEditControl
            Get
                Return richEditControl
            End Get
        End Property

        Private Sub OnRichEditControlDocumentProtectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            pnlAlert.Visible = richEditControl.Document.IsDocumentProtected
            richEditControl.ClearUndo()
        End Sub

        Private Sub OnRichEditControl1DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            Dim rangePermissions As RangePermissionCollection = richEditControl.Document.BeginUpdateRangePermissions()
            cbUsers.Items.Clear()
            richEditControl.Document.CancelUpdateRangePermissions(rangePermissions)
            Dim users As List(Of String) = FetchUsers(rangePermissions)
            cbUsers.Items.AddRange(users)
            _userService.Update(users)
            If users.Count > 0 Then
                SetActiveUser(users(0))
                usersBarEditItem.Visibility = XtraBars.BarItemVisibility.Always
            Else
                SetActiveUser("guest")
                cbUsers.Items.Add("guest")
                usersBarEditItem.Visibility = XtraBars.BarItemVisibility.Never
            End If

            usersBarEditItem.EditValue = cbUsers.Items(0)
        End Sub

        Private Function FetchUsers(ByVal rangePermissions As RangePermissionCollection) As List(Of String)
            Dim users As List(Of String) = New List(Of String)()
            For Each rangePermission As RangePermission In rangePermissions
                Dim userName As String = rangePermission.UserName
                If Not String.IsNullOrEmpty(userName) AndAlso Not users.Contains(userName) Then users.Add(userName)
            Next

            Return users
        End Function

        Private Sub SetActiveUser(ByVal user As String)
            richEditControl.Options.Authentication.EMail = user
        End Sub

        Private Sub usersBarEditItem_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetActiveUser(usersBarEditItem.EditValue.ToString())
        End Sub
    End Class
End Namespace
