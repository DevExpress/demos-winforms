Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraGrid.Controls
Imports DevExpress.Utils.Design
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraGrid.Columns

Namespace DevExpress.MailClient.Win
    Partial Public Class Mail
        Inherits BaseModule

        Private currentMessage_Field As Message
        Private priorityMenu_Field, dateFilterMenu_Field As PopupMenu
        Private ribbon As RibbonControl
        Private findControlManager As FindControlManager = Nothing
        Private filterCriteriaManager As FilterCriteriaManager = Nothing
        Private messageReadTimer As Timer
        Private focusedRowHandle As Integer = 0
        Private lockUpdateCurrentMessage As Boolean = True
        Public Overrides ReadOnly Property ModuleName() As String
            Get
                Return My.Resources.MailName
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
            ucMailViewer1.SetParentModule(Me)
            ShowPreview()
            CreateTimer()
        End Sub

        Private Sub Mail_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            gridControl1.ForceInitialize()
            CalcPreviewIndent()
        End Sub
        Private Sub CreateTimer()
            messageReadTimer = New Timer()
            messageReadTimer.Interval = 3000
            AddHandler messageReadTimer.Tick, AddressOf messageReadTimer_Tick
        End Sub

        Private Sub messageReadTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If CurrentMessage IsNot Nothing AndAlso CurrentMessage.IsUnread Then
                RaiseReadMessagesChanged(gridView1.FocusedRowHandle)
                messageReadTimer.Stop()
            End If
        End Sub
        Protected Friend Overrides ReadOnly Property CurrentRichEdit() As RichEditControl
            Get
                Return ucMailViewer1.RichEdit
            End Get
        End Property
        Protected Overrides ReadOnly Property Grid() As DevExpress.XtraGrid.GridControl
            Get
                Return gridControl1
            End Get
        End Property
        Friend Overrides Sub InitModule(ByVal manager As DevExpress.Utils.Menu.IDXMenuManager, ByVal data As Object)
            MyBase.InitModule(manager, data)
            EditorHelper.InitPriorityComboBox(repositoryItemImageComboBox1)
            Me.ribbon = TryCast(manager, RibbonControl)
            ucMailViewer1.SetMenuManager(manager)
            ShowAboutRow()
        End Sub
        Private Sub ShowAboutRow()
            Dim tmr As New Timer()
            tmr.Interval = 100
            AddHandler tmr.Tick, AddressOf tmr_Tick
            tmr.Start()
        End Sub
        Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
            lockUpdateCurrentMessage = False
            FocusRow(0)
            DirectCast(sender, Timer).Stop()
        End Sub
        Private Sub FocusRow(ByVal rowHandle As Integer)
            gridView1.FocusedRowHandle = rowHandle
            gridView1.ClearSelection()
            gridView1.SelectRow(rowHandle)
        End Sub
        Friend Overrides Sub ShowModule(ByVal firstShow As Boolean)
            MyBase.ShowModule(firstShow)
            If firstShow Then
                filterCriteriaManager = New FilterCriteriaManager(gridView1)
                filterCriteriaManager.AddBarItem(OwnerForm.ShowUnreadItem, gcIcon, "[Read] = 0")
                filterCriteriaManager.AddBarItem(OwnerForm.ImportantItem, gcPriority, "[Priority] = 2")
                filterCriteriaManager.AddBarItem(OwnerForm.HasAttachmentItem, gcAttachment, "[Attachment] = 1")
                filterCriteriaManager.AddClearFilterButton(OwnerForm.ClearFilterItem)
                SetPriorityMenu()
                SetDateFilterMenu()
                OwnerForm.FilterColumnManager.InitGridView(gridView1)
            Else
                lockUpdateCurrentMessage = False
                FocusRow(focusedRowHandle)
            End If
            gridControl1.Focus()
        End Sub
        Friend Overrides Sub HideModule()
            lockUpdateCurrentMessage = True
            focusedRowHandle = gridView1.FocusedRowHandle
        End Sub
        Protected Overrides Sub LookAndFeelStyleChanged()
            MyBase.LookAndFeelStyleChanged()
            ColorHelper.UpdateColor(ilColumns, gridControl1.LookAndFeel)
        End Sub
        Private Sub gridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView1.CustomDrawGroupRow
            Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)
            If info Is Nothing Then
                Return
            End If
        End Sub

        Private Sub gridView1_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView1.RowCellClick
            If e.Column Is gcRead AndAlso e.Button = MouseButtons.Left Then
                RaiseReadMessagesChanged(e.RowHandle)
            End If
            If e.Column.FieldName = "Priority" AndAlso e.Button = MouseButtons.Left Then
                PriorityMenu.ShowPopup(gridControl1.PointToScreen(e.Location))
            End If
            If e.Button = MouseButtons.Right Then
                ShowMessageMenu(gridControl1.PointToScreen(e.Location))
            End If
        End Sub

        Private Sub gridView1_RowClick(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.RowClickEventArgs) Handles gridView1.RowClick
            If e.HitInfo.HitTest = GridHitTest.RowPreview AndAlso e.Button = MouseButtons.Right Then
                ShowMessageMenu(gridControl1.PointToScreen(e.Location))
            End If
        End Sub
        Private Sub EditMessage(ByVal rowHandle As Integer)
            If rowHandle < 0 Then
                Return
            End If
            Dim message As Message = TryCast(gridView1.GetRow(rowHandle), Message)
            If message IsNot Nothing Then
                EditMessage(message, False, gcFrom.Caption)
            End If
        End Sub
        Private Sub gridView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView1.KeyDown
            If e.KeyData = Keys.Enter Then
                EditMessage(gridView1.FocusedRowHandle)
            End If
            If e.KeyData = Keys.Delete Then
                DeleteMails()
            End If
        End Sub
        Private Sub RaiseReadMessagesChanged(ByVal rowHandle As Integer)
            Dim current As Message = TryCast(gridView1.GetRow(rowHandle), Message)
            If current Is Nothing Then
                Return
            End If
            current.ToggleRead()
            gridView1.LayoutChanged()
            OwnerForm.ReadMessagesChanged()
            MakeFocusedRowVisible()
        End Sub
        Private Sub RaiseUpdateTreeViewMessages()
            OwnerForm.UpdateTreeViewMessages()
        End Sub
        Private Sub RaiseEnableDelete(ByVal enabled As Boolean)
            OwnerForm.EnableDelete(enabled)
        End Sub
        Private Sub RaiseEnableMail(ByVal enabled As Boolean)
            OwnerForm.EnableMail(enabled, If(enabled AndAlso CurrentMessage IsNot Nothing, CurrentMessage.IsUnread, False))
        End Sub
        Private Sub SetPriorityMenu()
            OwnerForm.SetPriorityMenu(PriorityMenu)
        End Sub
        Private Sub SetDateFilterMenu()
            OwnerForm.SetDateFilterMenu(DateFilterMenu)
        End Sub
        Private Sub ShowMessageMenu(ByVal location As Point)
            OwnerForm.ShowMessageMenu(location)
        End Sub
        Private Property CurrentMessage() As Message
            Get
                Return currentMessage_Field
            End Get
            Set(ByVal value As Message)
                If currentMessage_Field Is value Then
                    Return
                End If
                currentMessage_Field = value
                ucMailViewer1.ShowMessage(CurrentMessage)
                messageReadTimer.Stop()
                If CurrentMessage IsNot Nothing AndAlso CurrentMessage.IsUnread Then
                    messageReadTimer.Start()
                End If
            End Set
        End Property
        Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
            UpdateCurrentMessage()
        End Sub
        Private Sub gridView1_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.ColumnFilterChanged
            UpdateCurrentMessage()
        End Sub
        Private Sub gridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles gridView1.SelectionChanged
            RaiseEnableDelete(EnableDelete)
        End Sub

        Private Sub UpdateCurrentMessage()
            If lockUpdateCurrentMessage Then
                Return
            End If
            If gridView1.FocusedRowHandle >= 0 Then
                CurrentMessage = TryCast(gridView1.GetFocusedRow(), Message)
            Else
                Dim rows As New List(Of Message)()
                GridHelper.GetChildDataRowHandles(gridView1, gridView1.FocusedRowHandle, rows)
                ucMailViewer1.ShowMessagesInfo(rows)
                CurrentMessage = Nothing
                messageReadTimer.Stop()
            End If
            RaiseEnableMail(gridView1.FocusedRowHandle >= 0)
            RaiseEnableDelete(EnableDelete)
        End Sub
        Private Sub DeleteMails()
            For Each row As Integer In gridView1.GetSelectedRows()
                If row >= 0 Then
                    Dim message As Message = (CType(gridView1.GetRow(row), Message))
                    If message.MailType = MailType.Deleted Then
                        message.Deleted = True
                    Else
                        message.MailType = MailType.Deleted
                    End If
                End If
            Next row
            RaiseUpdateTreeViewMessages()
        End Sub
        Protected Friend Overrides Sub ButtonClick(ByVal tag As String)
            Select Case tag
                Case TagResources.RotateLayout
                    layoutControl1.Root.RotateLayout()
                Case TagResources.FlipLayout
                    layoutControl1.Root.FlipLayout()
                Case TagResources.DeleteItem
                    DeleteMails()
                Case TagResources.NewMail
                    CreateNewMailMessage()
                Case TagResources.Reply
                    CreateReplyMailMessage()
                Case TagResources.ReplyAll
                    CreateReplyAllMailMessages()
                Case TagResources.Forward
                    CreateForwardMailMessage()
                Case TagResources.UnreadRead
                    For Each row As Integer In gridView1.GetSelectedRows()
                        If row >= 0 Then
                            CType(gridView1.GetRow(row), Message).ToggleRead()
                        End If
                    Next row
                    gridView1.LayoutChanged()
                    OwnerForm.ReadMessagesChanged()
                Case TagResources.CloseSearch
                    gridView1.Focus()
                Case TagResources.ResetColumnsToDefault
                    OwnerForm.FilterColumnManager.SetDefault()
                Case TagResources.ClearFilter
                    gridView1.ActiveFilter.Clear()
                Case TagResources.Preview
                    ShowPreview()
            End Select
        End Sub
        Private Sub ShowPreview()
            If OwnerForm IsNot Nothing AndAlso (Not OwnerForm.ShowPreview) Then
                gridView1.OptionsView.ShowPreview = False
                gridView1.OptionsView.ShowHorizontalLines = Utils.DefaultBoolean.True
            Else
                gridView1.OptionsView.ShowPreview = True
                gridView1.OptionsView.ShowHorizontalLines = Utils.DefaultBoolean.False
            End If
        End Sub
        Private ReadOnly Property EnableDelete() As Boolean
            Get
                For Each row As Integer In gridView1.GetSelectedRows()
                    If row >= 0 Then
                        Return True
                    End If
                Next row
                Return False
            End Get
        End Property

        Private Sub CreateNewMailMessage()
            Dim message As New Message()
            message.MailType = MailType.Draft
            EditMessage(message, True, Nothing)
        End Sub
        Private Sub EditMessage(ByVal message As Message, ByVal newMessage As Boolean, ByVal caption As String)
            Cursor.Current = Cursors.WaitCursor
            Dim form As New frmEditMail(message, newMessage, caption)
            AddHandler form.Load, AddressOf OnEditMailFormLoad
            AddHandler form.FormClosed, AddressOf OnEditMailFormClosed
            form.Location = New Point(OwnerForm.Left + (OwnerForm.Width - form.Width) \ 2, OwnerForm.Top + (OwnerForm.Height - form.Height) \ 2)
            form.Show()
            Cursor.Current = Cursors.Default
        End Sub
        Private Sub CreateReplyAllMailMessages()
            For Each row As Integer In gridView1.GetSelectedRows()
                CreateReplyMailMessage(row)
            Next row
        End Sub

        Private Sub CreateReplyMailMessage()
            Dim rows() As Integer = gridView1.GetSelectedRows()
            If rows.Length <> 1 Then
                Return
            End If
            CreateReplyMailMessage(rows(0))
        End Sub
        Private Sub CreateReplyMailMessage(ByVal row As Integer)
            If row >= 0 Then
                Dim message As Message = (CType(gridView1.GetRow(row), Message))
                If message.MailType <> MailType.Deleted AndAlso (Not message.Deleted) Then
                    CreateReplyMailMessage(message)
                End If
            End If
        End Sub
        Private Sub CreateReplyMailMessage(ByVal originalMessage As Message)
            Dim message As New Message()
            message.MailType = MailType.Draft
            message.From = originalMessage.From
            message.Email = originalMessage.Email
            message.Subject = originalMessage.Subject
            message.Text = CreateReplyMessageText(originalMessage.Text, message.From, originalMessage.Date)
            EditMessage(message, True, Nothing)
        End Sub
        Private Sub CreateForwardMailMessage()
            Dim rows() As Integer = gridView1.GetSelectedRows()
            If rows.Length <> 1 Then
                Return
            End If
            CreateForwardMailMessage(rows(0))
        End Sub
        Private Sub CreateForwardMailMessage(ByVal row As Integer)
            If row >= 0 Then
                Dim message As Message = (CType(gridView1.GetRow(row), Message))
                If message.MailType <> MailType.Deleted AndAlso (Not message.Deleted) Then
                    CreateForwardMailMessage(message)
                End If
            End If
        End Sub
        Private Sub CreateForwardMailMessage(ByVal originalMessage As Message)
            Dim message As New Message()
            message.MailType = MailType.Draft
            message.Subject = originalMessage.Subject
            message.Text = CreateForwardMessageText(originalMessage.Text, String.Empty)
            EditMessage(message, True, Nothing)
        End Sub

        Private Function CreateReplyMessageText(ByVal text As String, ByVal [to] As String, ByVal originalMessageDate As Date) As String
            Using server As New RichEditDocumentServer()
                server.MhtText = text
                QuoteReplyMessage(server, [to], originalMessageDate)
                Return server.MhtText
            End Using
        End Function
        Private Function CreateForwardMessageText(ByVal text As String, ByVal [to] As String) As String
            Using server As New RichEditDocumentServer()
                server.MhtText = text
                QuoteForwardMessage(server, [to])
                Return server.MhtText
            End Using
        End Function
        Private Sub QuoteReplyMessage(ByVal server As RichEditDocumentServer, ByVal [to] As String, ByVal originalMessageDate As Date)
            QuoteMessage(server)
            Dim document As Document = server.Document
            Dim replyHeader As String = String.Format(My.Resources.ReplyText, [to], originalMessageDate)
            document.InsertText(document.Range.Start, replyHeader)
        End Sub
        Private Sub QuoteMessage(ByVal server As RichEditDocumentServer)
            Dim document As Document = server.Document
            Dim paragraphs As ParagraphCollection = document.Paragraphs
            For Each paragraph As Paragraph In paragraphs
                Dim range As DocumentRange = paragraph.Range
                If document.Tables.GetTableCell(range.Start) Is Nothing AndAlso (Not paragraph.IsInList) Then
                    document.InsertText(range.Start, ">> ")
                End If
            Next paragraph
        End Sub
        Private Sub QuoteForwardMessage(ByVal server As RichEditDocumentServer, ByVal [to] As String)
            Dim document As Document = server.Document
            Dim replyHeader As String = My.Resources.ForwardTextStart
            document.InsertText(document.Range.Start, replyHeader)
            document.AppendText(My.Resources.ForwardTextStart)
        End Sub
        Private Sub OnEditMailFormLoad(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As frmEditMail = TryCast(sender, frmEditMail)
            If form IsNot Nothing Then
                AddHandler form.SaveMessage, AddressOf OnEditMailFormSaveMessage
            End If
        End Sub

        Private Sub OnEditMailFormSaveMessage(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As frmEditMail = TryCast(sender, frmEditMail)
            If form Is Nothing Then
                Return
            End If

            If Not DataHelper.Messages.Contains(form.SourceMessage) Then
                DataHelper.Messages.Add(form.SourceMessage)
            End If
            RaiseUpdateTreeViewMessages()
        End Sub

        Private Sub OnEditMailFormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
            Dim form As frmEditMail = TryCast(sender, frmEditMail)
            If form IsNot Nothing Then
                RemoveHandler form.SaveMessage, AddressOf OnEditMailFormSaveMessage
            End If
        End Sub
        Protected Friend Overrides Sub MessagesDataChanged(ByVal args As DataSourceChangedEventArgs)
            partName_Field = args.Caption
            gridControl1.DataSource = args.List
            If args.Type = MailType.Deleted Then
                gcDate.Caption = My.Resources.DateDeleted
                gcFrom.Caption = My.Resources.FromDeleted
                OwnerForm.FilterColumnManager.UpdateColumnsCaption(My.Resources.DateDeleted, My.Resources.FromDeleted)
            ElseIf args.Type = MailType.Inbox Then
                gcDate.Caption = My.Resources.DateInbox
                gcFrom.Caption = My.Resources.FromInbox
                OwnerForm.FilterColumnManager.UpdateColumnsCaption(My.Resources.DateInbox, My.Resources.FromInbox)
            Else
                gcDate.Caption = My.Resources.DateOutbox
                gcFrom.Caption = My.Resources.FromOutbox
                OwnerForm.FilterColumnManager.UpdateColumnsCaption(My.Resources.DateOutbox, My.Resources.FromOutbox)
            End If
            If FindControl IsNot Nothing Then
                FindControl.FindEdit.Properties.NullValuePrompt = StringResources.GetSearchPrompt(args.Type)
                FindControl.FindEdit.Properties.NullValuePromptShowForEmptyValue = True
                If findControlManager Is Nothing Then
                    findControlManager = New FindControlManager(ribbon, FindControl)
                End If
            End If
            UpdateCurrentMessage()
        End Sub
        Private ReadOnly Property FindControl() As FindControl
            Get
                For Each ctrl As Control In gridControl1.Controls
                    Dim ret As FindControl = TryCast(ctrl, FindControl)
                    If ret IsNot Nothing Then
                        Return ret
                    End If
                Next ctrl
                Return Nothing
            End Get
        End Property
        Private ReadOnly Property PriorityMenu() As PopupMenu
            Get
                If priorityMenu_Field Is Nothing Then
                    priorityMenu_Field = New PriorityMenu(ribbon.Manager, gridView1, My.Resources.Low16x16, My.Resources.High16x16)
                End If
                Return priorityMenu_Field
            End Get
        End Property
        Private ReadOnly Property DateFilterMenu() As PopupMenu
            Get
                If dateFilterMenu_Field Is Nothing Then
                    dateFilterMenu_Field = New DateFilterMenu(ribbon.Manager, gridView1, filterCriteriaManager)
                End If
                Return dateFilterMenu_Field
            End Get
        End Property
        Private Sub MakeFocusedRowVisible()
            gridView1.MakeRowVisible(gridView1.FocusedRowHandle)
        End Sub
        Protected Friend Overrides Sub SendKeyDown(ByVal e As KeyEventArgs)
            MyBase.SendKeyDown(e)
            If e.KeyData = (Keys.E Or Keys.Control) Then
                If FindControl IsNot Nothing Then
                    FindControl.FindEdit.Focus()
                End If
            End If
        End Sub
        Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
            If e.Column Is gcSubject Then
                Dim message As Message = TryCast(gridView1.GetRow(e.RowHandle), Message)
                If message IsNot Nothing Then
                    e.DisplayText = message.SubjectDisplayText
                End If
            End If
        End Sub
        Protected Overrides ReadOnly Property AllowZoomControl() As Boolean
            Get
                Return True
            End Get
        End Property
        Public Overrides Property ZoomFactor() As Single
            Get
                Return ucMailViewer1.ZoomFactor
            End Get
            Set(ByVal value As Single)
                ucMailViewer1.ZoomFactor = value
            End Set
        End Property

        Private Sub gridView1_ColumnPositionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.ColumnPositionChanged
            CalcPreviewIndent()
        End Sub

        Private Sub CalcPreviewIndent()
            Dim indent As Integer = 0
            For Each column As GridColumn In gridView1.VisibleColumns
                If "Priority;Read;Attachment".IndexOf(column.FieldName) > -1 Then
                    indent += column.Width
                Else
                    Exit For
                End If
            Next column
            gridView1.PreviewIndent = indent
        End Sub
        Private dragStart As New Point(Integer.MinValue, 0)
        Private dragSelection() As Integer = Nothing
        Private Sub ResetDrag()
            Me.dragSelection = Nothing
            Me.dragStart = New Point(Integer.MinValue, Integer.MinValue)
        End Sub
        Private Sub gridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseDown
            If gridView1.CalcHitInfo(e.X, e.Y).InRow Then
                dragStart = New Point(e.X, e.Y)
                If dragSelection Is Nothing OrElse dragSelection.Length = 0 Then
                    dragSelection = New Integer() { gridView1.FocusedRowHandle }
                End If
            Else
                ResetDrag()
            End If
        End Sub

        Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseMove
            If dragStart.X <> Integer.MinValue AndAlso e.Button = System.Windows.Forms.MouseButtons.Left Then
                Dim delta As Point = Point.Subtract(dragStart, New Size(e.X, e.Y))
                If Math.Abs(delta.X) > SystemInformation.DragSize.Width OrElse Math.Abs(delta.Y) > SystemInformation.DragSize.Height Then
                    dragSelection = gridView1.GetSelectedRows()
                    StartRowsDrag()
                End If
            End If
        End Sub

        Private Sub StartRowsDrag()
            gridControl1.DoDragDrop(New DragSelection() With {.Rows = dragSelection}, DragDropEffects.Move)
        End Sub

        Friend Sub OnMoveEmails(ByVal tree As ucMailTree, ByVal e As UCTreeDragDropEventArgs)

            Dim messages As New List(Of Message)()
            For Each row As Integer In e.Selection.Rows
                If row >= 0 AndAlso TypeOf gridView1.GetRow(row) Is Message Then
                    messages.Add(TryCast(gridView1.GetRow(row), Message))
                End If
                If row < 0 Then
                    Dim count As Integer = gridView1.GetChildRowCount(row)
                    For n As Integer = 0 To count - 1
                        Dim r As Integer = gridView1.GetChildRowHandle(row, n)
                        If r >= 0 AndAlso TypeOf gridView1.GetRow(r) Is Message Then
                            messages.Add(TryCast(gridView1.GetRow(r), Message))
                        End If
                    Next n
                End If
            Next row
            Console.WriteLine("Drop {0}", messages.Count)
            For Each m As Message In messages
                Console.WriteLine("{0}", m.From)
                m.MailFolder = CInt(tree.GetNodeMailFolder(e.Node))
                m.MailType = tree.GetNodeMailType(e.Node)
            Next m
            RaiseUpdateTreeViewMessages()
            ResetDrag()
        End Sub
    End Class
    Public Class DragSelection
        Public Rows() As Integer
    End Class
End Namespace
