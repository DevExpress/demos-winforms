Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.HTML.Demos.Helpers.Data
Imports DevExpress.XtraTreeList.Nodes

Namespace DevExpress.HTML.Demos.Modules.TreeList

    Public Enum CommentEditingMode
        Editing
        Replying
    End Enum

    Public Class EditingComment

        Public ReadOnly Property Node As TreeListNode

        Public ReadOnly Property Comment As Comment

        Public ReadOnly Property Mode As CommentEditingMode

        Public Property Text As String

        Public Sub New(ByVal node As TreeListNode, ByVal comment As Comment, ByVal mode As CommentEditingMode)
            Me.Node = node
            Me.Comment = comment
            Me.Mode = mode
            If mode = CommentEditingMode.Editing Then Text = comment.Text
        End Sub

        Public Sub Apply()
            If Mode = CommentEditingMode.Editing Then
                Comment.UpdateText(Text)
            Else
                If Not String.IsNullOrEmpty(Text) Then
                    Dim reply = New Comment(TreeListData.CurrentUser.Name, TreeListData.CurrentUser.Photo, Text, TutorialConstants.Now)
                    Comment.AddReply(reply)
                    Call TreeListData.MakeCommentNodeVisible(reply, Node.Nodes)
                End If
            End If
        End Sub
    End Class
End Namespace
