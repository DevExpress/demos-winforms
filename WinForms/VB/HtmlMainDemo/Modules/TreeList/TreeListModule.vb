Imports System
Imports System.ComponentModel
Imports DevExpress.DXperience.Demos
Imports DevExpress.HTML.Demos.Helpers.Data
Imports DevExpress.HTML.Demos.Modules.TreeList
Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Namespace DevExpress.HTML.Demos

    Public Partial Class TreeListModule
        Inherits TutorialControlBase

        Private editingComment As EditingComment

        Private dataSource As BindingList(Of Comment)

        Public Sub New()
            InitializeComponent()
            treeListTemplateCodeViewer1.Fill(treeList1)
            dataSource = TreeListData.GenerateCommentsData()
            treeList1.DataSource = dataSource
            Dim autoHeightEdit = TryCast(messageEdit, IAutoHeightControlEx)
            autoHeightEdit.AutoHeightEnabled = True
            AddHandler autoHeightEdit.HeightChanged, AddressOf OnMessageHeightChanged
        End Sub

        Protected Overrides ReadOnly Property TakeScreenDelay As Integer
            Get
                Return 300
            End Get
        End Property

        Private Sub ExpandCollapseClick(ByVal sender As Object, ByVal e As DxHtmlElementMouseEventArgs)
            Dim node = TryCast(e.SourceItem, TreeListNode)
            If node.Expanded Then
                node.Collapse(True)
            Else
                node.Expand(True)
            End If
        End Sub

        Private Sub EditClick(ByVal sender As Object, ByVal e As DxHtmlElementMouseEventArgs)
            Dim node = TryCast(e.SourceItem, TreeListNode)
            StartCommentEditor(node, CommentEditingMode.Editing)
        End Sub

        Private Sub ReplyClick(ByVal sender As Object, ByVal e As DxHtmlElementMouseEventArgs)
            Dim node = TryCast(e.SourceItem, TreeListNode)
            StartCommentEditor(node, CommentEditingMode.Replying)
        End Sub

        Private Sub CancelClick(ByVal sender As Object, ByVal e As DxHtmlElementMouseEventArgs)
            EndCommentEditor(False)
        End Sub

        Private Sub ApplyClick(ByVal sender As Object, ByVal e As DxHtmlElementMouseEventArgs)
            EndCommentEditor(True)
        End Sub

        Private Sub LikeClick(ByVal sender As Object, ByVal e As DxHtmlElementMouseEventArgs)
            Dim node = TryCast(e.SourceItem, TreeListNode)
            Dim comment = TryCast(treeList1.GetRow(node.Id), Comment)
            comment.ToggleLike()
        End Sub

        Private Sub SendClick(ByVal sender As Object, ByVal e As DxHtmlElementMouseEventArgs)
            Dim comment = TreeListData.CurrentUser.CreateComment(messageEdit.Text)
            dataSource.Add(comment)
            messageEdit.Clear()
            Call TreeListData.MakeCommentNodeVisible(comment, treeList1.Nodes)
        End Sub

        Private Sub StartCommentEditor(ByVal node As TreeListNode, ByVal editingMode As CommentEditingMode)
            EndCommentEditor(False)
            Dim comment = TryCast(treeList1.GetRow(node.Id), Comment)
            editingComment = New EditingComment(node, comment, editingMode)
            treeList1.RefreshNode(node)
            If node.NextVisibleNode Is Nothing Then treeList1.MakeNodeVisible(node)
            treeList1.ShowEditor("EditingText")
        End Sub

        Private Sub EndCommentEditor(ByVal applyChanges As Boolean)
            If editingComment IsNot Nothing Then
                treeList1.BeginUpdate()
                Dim editedComment = editingComment
                editingComment = Nothing
                treeList1.RefreshNode(editedComment.Node)
                If applyChanges Then editedComment.Apply()
                treeList1.EndUpdate()
            End If
        End Sub

        Private Sub OnMessageHeightChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim contentSize = typingBox.GetContentSize()
            typingBox.Height = Math.Max(30, contentSize.Height)
        End Sub

        Private Sub treeList1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As TreeListCustomColumnDataEventArgs)
            If Equals(e.Column.FieldName, "IsMyComment") Then
                Dim comment As Comment = TryCast(e.Row, Comment)
                e.Value = Equals(comment.Author, TreeListData.CurrentUser.Name)
            ElseIf Equals(e.Column.FieldName, "HasLikes") Then
                Dim comment As Comment = TryCast(e.Row, Comment)
                e.Value = comment.Likes > 0
            ElseIf Equals(e.Column.FieldName, "EditingText") Then
                If editingComment IsNot Nothing Then
                    If e.IsGetData Then
                        e.Value = editingComment.Text
                    Else
                        editingComment.Text = Convert.ToString(e.Value)
                    End If
                End If
            End If
        End Sub

        Private Sub treeList1_QueryNodeTemplate(ByVal sender As Object, ByVal e As QueryNodeTemplateEventArgs)
            Dim comment = treeList1.GetRow(e.Node.Id)
            If editingComment IsNot Nothing AndAlso editingComment.Comment Is comment Then
                If editingComment.Mode = CommentEditingMode.Editing Then
                    e.Template.Assign(editingCommentTemplate)
                Else
                    e.Template.Assign(replyingCommentTemplate)
                End If
            End If
        End Sub
    End Class
End Namespace
