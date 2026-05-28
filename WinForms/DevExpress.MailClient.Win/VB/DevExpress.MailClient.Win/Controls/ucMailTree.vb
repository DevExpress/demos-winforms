Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList
Imports DevExpress.Utils.Design
Imports System.Collections

Namespace DevExpress.MailClient.Win
    Partial Public Class ucMailTree
        Inherits BaseControl

        Public Event DataSourceChanged As DataSourceChangedEventHandler
        Public Event ShowMenu As MouseEventHandler
        Private allowDataSourceChanged As Boolean = False
        Public Sub New()
            InitializeComponent()
            InitData()
            treeList1.RowHeight = Math.Max(Convert.ToInt32(treeList1.Font.GetHeight()), icFolders.ImageSize.Height) + 5
            treeList1.OptionsMenu.EnableNodeMenu = False
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If Not DesignTimeTools.IsDesignMode Then
                treeList1.FocusedNode = treeList1.Nodes(1).Nodes(0)
            End If
        End Sub
        Private Sub InitData()
            Dim tlAnnouncements As TreeListNode = treeList1.AppendNode(New Object() {My.Resources.Announcements, MailType.Inbox, MailFolder.Announcements, 5}, -1)
            treeList1.AppendNode(New Object() { My.Resources.Inbox, MailType.Inbox, MailFolder.Announcements }, tlAnnouncements)
            treeList1.AppendNode(New Object() { My.Resources.SentItems, MailType.Sent, MailFolder.Announcements, 1 }, tlAnnouncements)
            Dim tlPerson As TreeListNode = treeList1.AppendNode(New Object() {My.Resources.OwnerName, MailType.Inbox, MailFolder.All, 4}, -1)
            Dim tlPersonInbox As TreeListNode = treeList1.AppendNode(New Object() { My.Resources.Inbox, MailType.Inbox, MailFolder.All }, tlPerson)
            treeList1.AppendNode(New Object() { My.Resources.Management, MailType.Inbox, MailFolder.Management, 6 }, tlPersonInbox)
            treeList1.AppendNode(New Object() { My.Resources.IT, MailType.Inbox, MailFolder.IT, 7 }, tlPersonInbox)
            treeList1.AppendNode(New Object() { My.Resources.Sales, MailType.Inbox, MailFolder.Sales, 8 }, tlPersonInbox)
            treeList1.AppendNode(New Object() { My.Resources.Engineering, MailType.Inbox, MailFolder.Engineering, 9 }, tlPersonInbox)
            treeList1.AppendNode(New Object() { My.Resources.SentItems, MailType.Sent, MailFolder.All, 1 }, tlPerson)
            treeList1.AppendNode(New Object() { My.Resources.DeletedItems, MailType.Deleted, MailFolder.Deleted, 2 }, tlPerson)
            treeList1.AppendNode(New Object() { My.Resources.Drafts, MailType.Draft, MailFolder.All, 3 }, tlPerson)

            treeList1.ExpandAll()
            If Not DesignTimeTools.IsDesignMode Then
                CreateMessagesList(treeList1.Nodes)
            End If
            allowDataSourceChanged = True
        End Sub

        Private Sub CreateMessagesList(ByVal nodes As TreeListNodes)
            For Each node As TreeListNode In nodes
                CreateMessagesForNode(node)
                CreateMessagesList(node.Nodes)
                If GetNodeMailFolder(node) >= CInt(MailFolder.Custom) Then
                    Dim children As New List(Of TreeListNode)()
                    children.Add(node)
                    GetAllChildren(node, children)
                    Dim list As New List(Of Message)()
                    For Each n In children
                        list.AddRange((DirectCast(n.GetValue(colData), IEnumerable(Of Message))))
                    Next n
                    node.SetValue(colData, list)

                End If

            Next node
        End Sub
        Private Sub GetAllChildren(ByVal node As TreeListNode, ByVal list As List(Of TreeListNode))
            If Not node.HasChildren Then
                Return
            End If
            For Each child As TreeListNode In node.Nodes
                list.Add(child)
                GetAllChildren(child, list)
            Next child
        End Sub
        Friend Function GetNodeMailType(ByVal node As TreeListNode) As MailType
            Return CType(node.GetValue(colType), MailType)
        End Function
        Friend Function GetNodeMailFolder(ByVal node As TreeListNode) As Integer
            Return CInt((node.GetValue(colFolder)))
        End Function
        Private Sub CreateMessagesForNode(ByVal node As TreeListNode)
            Dim messages As New List(Of Message)()
            Dim mailType As MailType = GetNodeMailType(node)
            Dim mailFolder As Integer = GetNodeMailFolder(node)
            For Each message As Message In DataHelper.Messages
                If message.MailType = mailType AndAlso ((message.MailFolder And mailFolder) > 0 OrElse mailFolder = CInt(DevExpress.MailClient.Win.MailFolder.All) OrElse mailType = DevExpress.MailClient.Win.MailType.Deleted) AndAlso (Not message.Deleted) Then
                        messages.Add(message)
                End If
            Next message
            node.SetValue(colData, messages)
        End Sub
        Protected Overrides Sub LookAndFeelStyleChanged()
            MyBase.LookAndFeelStyleChanged()
            Dim controlColor As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("Control")
            treeList1.Appearance.Empty.BackColor = controlColor
            treeList1.Appearance.Row.BackColor = controlColor
            SetFocusedColor(CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default))
        End Sub
        Private Sub SetFocusedColor(ByVal skin As Skin)
            If "|Office 2016 Colorful|".IndexOf(skin.Name) > 0 Then
                treeList1.Appearance.FocusedRow.BackColor = skin.Colors.GetColor("HideSelection")
            Else
                treeList1.Appearance.FocusedRow.BackColor = skin.Colors.GetColor("Highlight")
            End If
        End Sub
        Private Sub treeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles treeList1.FocusedNodeChanged
            RaiseDataSourceChanged(e.Node)
        End Sub
        Private Sub RaiseDataSourceChanged(ByVal node As TreeListNode)
            If allowDataSourceChanged Then
                RaiseEvent DataSourceChanged(treeList1, New DataSourceChangedEventArgs(GetNodeCaption(node), node.GetValue(colData), node.GetValue(colType)))
            End If
        End Sub
        Private Function GetNodeCaption(ByVal node As TreeListNode) As String
            Dim ret As String = String.Format("{0}", node.GetValue(colName))
            Do While node.ParentNode IsNot Nothing
                node = node.ParentNode
                ret = String.Format("{0} - {1}", node.GetValue(colName), ret)
            Loop
            Return ret
        End Function
        Private Sub treeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As CustomDrawNodeCellEventArgs) Handles treeList1.CustomDrawNodeCell
            If DesignTimeTools.IsDesignMode Then
                Return
            End If
            If e.Column Is colName Then
                Dim textColor As String = GetHtmlTextColor(treeList1.FocusedNode.Equals(e.Node))
                Dim textValue As Object = e.Node.GetValue(colName)
                e.CellText = String.Format("<Color={1}>{0}", textValue, textColor)
                If e.Node.ParentNode Is Nothing OrElse Not(DataHelper.ShowAllMessageCount OrElse DataHelper.ShowUnreadMessageCount) Then
                    Return
                End If
                Dim list As List(Of Message) = TryCast(e.Node.GetValue(colData), List(Of Message))
                Dim unread As Integer = GetUnreadMessagesCount(list)
                If unread > 0 AndAlso DataHelper.ShowUnreadMessageCount Then
                    If DataHelper.ShowAllMessageCount Then
                        e.CellText = String.Format("<Color={5}><b>{0}</b><Size=-1><Color={2}> [{1}/<Color={4}>{3}<Color={2}>]", textValue, unread, ColorHelper.HtmlQuestionColor, list.Count, ColorHelper.HtmlWarningColor, textColor)
                    Else
                        e.CellText = String.Format("<Color={3}><b>{0}</b><Size=-1><Color={2}> [{1}]", textValue, unread, ColorHelper.HtmlQuestionColor, textColor)
                    End If
                Else
                    If DataHelper.ShowAllMessageCount AndAlso list.Count > 0 Then
                        e.CellText = String.Format("<Color={3}>{0}<Size=-1><Color={2}> [{1}]", textValue, list.Count, ColorHelper.HtmlWarningColor, textColor)
                    End If
                End If
            End If
        End Sub
        Private Shared Function GetHtmlTextColor(ByVal focused As Boolean) As String
            If focused Then
                Return ColorHelper.HtmlHighlightTextColor
            End If
            Return If(AllowControlTextColor, ColorHelper.HtmlControlTextColor, ColorHelper.HtmlControlTextColor2)
        End Function
        Private Shared ReadOnly Property AllowControlTextColor() As Boolean
            Get
                Return DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName <> "Glass Oceans"
            End Get
        End Property
        Private Function GetUnreadMessagesCount(ByVal list As List(Of Message)) As Integer
            Dim ret = From message In list Where message.IsUnread = True Select message
            Return ret.Count
        End Function
        Friend Function IsDeletedFolderFocused() As Boolean
            Return treeList1.FocusedNode IsNot Nothing AndAlso GetNodeMailFolder(treeList1.FocusedNode) = CInt(MailFolder.Deleted)
        End Function
        Private Shared CustomFolderId As Integer = CInt(MailFolder.Custom)
        Friend Sub CreateNewFolder()
            If treeList1.FocusedNode Is Nothing OrElse IsDeletedFolderFocused() Then
                Return
            End If
            Dim node = treeList1.FocusedNode.Nodes.Add(New Object() {My.Resources.NewFolder, MailType.Inbox, CustomFolderId, 9, New List(Of Message)()})
            CustomFolderId += 1

            treeList1.FocusedNode = node
            StartEditing()

        End Sub
        Friend Sub StartEditing()
            If treeList1.FocusedNode Is Nothing OrElse IsDeletedFolderFocused() Then
                Return
            End If
            treeList1.OptionsBehavior.Editable = True
            treeList1.VisibleColumns(0).OptionsColumn.AllowFocus = True
            treeList1.FocusedColumn = treeList1.VisibleColumns(0)
            treeList1.ShowEditor()
        End Sub
        Private Sub treeList1_HiddenEditor(ByVal sender As Object, ByVal e As EventArgs) Handles treeList1.HiddenEditor
            treeList1.OptionsBehavior.Editable = False
            treeList1.VisibleColumns(0).OptionsColumn.AllowFocus = False
            treeList1.ClearFocusedColumn()
        End Sub
        Friend Sub RefreshTreeList()
            treeList1.LayoutChanged()
        End Sub
        Private Sub treeList1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles treeList1.MouseDown
            If e.Button = MouseButtons.Right Then
                RaiseEvent ShowMenu(sender, e)
            End If
        End Sub

        Friend Sub UpdateTreeViewMessages()
            CreateMessagesList(treeList1.Nodes)
            RefreshTreeList()
            RaiseDataSourceChanged(treeList1.FocusedNode)
        End Sub


        Private Sub treeList1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles treeList1.DragEnter
            Dim dragSelection As DragSelection = TryCast(e.Data.GetData(GetType(DragSelection)), DragSelection)
            If dragSelection Is Nothing Then
                Return
            End If
            e.Effect = DragDropEffects.Move
        End Sub

        Private Sub treeList1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles treeList1.DragDrop
            Dim dragSelection As DragSelection = TryCast(e.Data.GetData(GetType(DragSelection)), DragSelection)
            If dragSelection Is Nothing Then
                Return
            End If
            If treeList1.DropTaget IsNot Nothing Then
                OnTreeDragDrop(treeList1.DropTaget, dragSelection)
            End If
        End Sub
        Public Event UCTreeDragDrop As UCTreeDragDropEventHandler
        Private Sub OnTreeDragDrop(ByVal node As TreeListNode, ByVal selection As DragSelection)
            RaiseEvent UCTreeDragDrop(Me, New UCTreeDragDropEventArgs() With {.Node = node, .Selection = selection})

        End Sub

        Private Sub treeList1_CustomNodeCellEditForEditing(ByVal sender As Object, ByVal e As GetCustomNodeCellEditEventArgs) Handles treeList1.CustomNodeCellEditForEditing
            e.RepositoryItem = repositoryItemTextEdit1
        End Sub


    End Class
    Public Delegate Sub UCTreeDragDropEventHandler(ByVal sender As Object, ByVal e As UCTreeDragDropEventArgs)
    Public Class UCTreeDragDropEventArgs
        Inherits EventArgs

        Public Property Node() As TreeListNode
        Public Property Selection() As DragSelection
    End Class
    Public Class MyTreeList
        Inherits TreeList

        Public ReadOnly Property StateData() As DevExpress.XtraTreeList.Handler.StateData
            Get
                Return Me.Handler.StateData
            End Get
        End Property
        Protected Friend ReadOnly Property DropTaget() As TreeListNode
            Get
                If StateData IsNot Nothing AndAlso StateData.DragInfo IsNot Nothing AndAlso StateData.DragInfo.RowInfo IsNot Nothing Then
                    Return StateData.DragInfo.RowInfo.Node
                End If
                Return Nothing
            End Get
        End Property
    End Class
End Namespace
