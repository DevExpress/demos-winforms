Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraNavBar
Imports System.Collections
Imports DevExpress.Utils
Imports DevExpress.MailClient.Win.Forms
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.MailClient.Win
    Partial Public Class Tasks
        Inherits BaseModule

        Private Class NavBarData
            Private contact_Field As Contact
            Private data_Field As Object
            Public Sub New(ByVal data As Object, ByVal contact As Contact)
                Me.contact_Field = contact
                Me.data_Field = data
            End Sub
            Public ReadOnly Property Contact() As Contact
                Get
                    Return contact_Field
                End Get
            End Property
            Public ReadOnly Property Data() As Object
                Get
                    Return data_Field
                End Get
            End Property
        End Class
        Private tasks_Field As New Dictionary(Of Object, Object)()
        Private tooltip As ContactToolTipController
        Private currentKey_Field As Object = Nothing
        Public Overrides ReadOnly Property ModuleName() As String
            Get
                Return My.Resources.TasksName
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
        End Sub
        Friend Overrides Sub InitModule(ByVal manager As DevExpress.Utils.Menu.IDXMenuManager, ByVal data As Object)
            MyBase.InitModule(manager, data)
            EditorHelper.CreateTaskStatusImageComboBox(repositoryItemImageComboBox3)
            EditorHelper.CreateTaskCategoryImageComboBox(repositoryItemImageComboBox4)
            EditorHelper.CreateFlagStatusImageComboBox(repositoryItemImageComboBox5)
            EditorHelper.InitPriorityComboBox(repositoryItemImageComboBox1)
            Dim group As NavBarGroup = TryCast(data, NavBarGroup)
            CreateNavBarItems(group)
            tooltip = New ContactToolTipController(group.NavBar)
            AddHandler group.NavBar.MouseMove, AddressOf NavBar_MouseMove
        End Sub

        Private Sub NavBar_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim navBar As NavBarControl = TryCast(sender, NavBarControl)
            Dim info As NavBarHitInfo = navBar.CalcHitInfo(e.Location)
            If info.InLink Then
                tooltip.ShowHint(CType(info.Link.Item.Tag, NavBarData).Contact, e.Location)
            Else
                tooltip.HideHint(True)
            End If
        End Sub
        Private Sub CreateNavBarItems(ByVal group As NavBarGroup)
            group.NavBar.LinkSelectionMode = LinkSelectionModeType.OneInControl
            Dim link As NavBarItemLink = AddNavBarItem(group, My.Resources.OwnerName, My.Resources.Owner, GetTasksData(Nothing), Nothing)
            link.Item.Appearance.Font = New Font(AppearanceObject.DefaultFont, FontStyle.Underline)
            For Each contact As Contact In TaskGenerator.Customers
                AddNavBarItem(group, contact.Name, contact.Icon, GetTasksData(contact), contact)
            Next contact
            group.SelectedLink = link
            ShowData(group.SelectedLink.Item)
        End Sub
        Private Function GetTasksData(ByVal contact As Contact) As Object
            Dim ret As IEnumerable = From task In DataHelper.Tasks _
                            Where task.AssignTo Is contact _
                            Select task
            Return ret.Cast(Of Task)().ToList()
        End Function
        Private Function AddNavBarItem(ByVal group As NavBarGroup, ByVal caption As String, ByVal image As Image, ByVal data As Object, ByVal contact As Contact) As NavBarItemLink
            Dim item As New NavBarItem(caption)
            item.SmallImage = image
            item.Tag = New NavBarData(data, contact)
            tasks_Field.Add(item.Tag, data)
            Dim link As NavBarItemLink = group.ItemLinks.Add(item)
            AddHandler item.LinkClicked, AddressOf item_LinkClicked
            Return link
        End Function
        Private Sub item_LinkClicked(ByVal sender As Object, ByVal e As NavBarLinkEventArgs)
            ShowData(e.Link.Item)
        End Sub
        Private Sub ShowData(ByVal item As NavBarItem)
            currentKey_Field = item.Tag
            partName_Field = item.Caption
            gridControl1.DataSource = CType(item.Tag, NavBarData).Data
            ShowInfo(gridView1)
        End Sub
        Protected Overrides ReadOnly Property Grid() As DevExpress.XtraGrid.GridControl
            Get
                Return gridControl1
            End Get
        End Property
        Friend Overrides Sub ShowModule(ByVal firstShow As Boolean)
            MyBase.ShowModule(firstShow)
            If firstShow Then
                gridControl1.ForceInitialize()
                GridHelper.SetFindControlImages(gridControl1)
                Dim item As GalleryItem = OwnerForm.TaskGallery.Groups(0).Items(0)
                item.Checked = True
                ButtonClick(String.Format("{0}", item.Tag))
            End If
        End Sub
        Protected Overrides Sub ShowReminder()
            Dim view As ColumnView = TryCast(gridControl1.MainView, ColumnView)
            If view IsNot Nothing AndAlso OwnerForm IsNot Nothing Then
                OwnerForm.ShowReminder(GetReminders(TryCast(gridControl1.DataSource, List(Of Task))))
            Else
                MyBase.ShowReminder()
            End If
        End Sub
        Private Function GetReminders(ByVal tasks As List(Of Task)) As List(Of Task)
            Dim data = From task In tasks
                       Where (Not task.Complete) AndAlso task.DueDate <= Date.Now
                       Select task
            Return data.ToList()
        End Function
        Protected Overrides Sub LookAndFeelStyleChanged()
            MyBase.LookAndFeelStyleChanged()
            ColorHelper.UpdateColor(ilColumns, gridControl1.LookAndFeel)
            ShowReminder()
        End Sub
        Private Sub gridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles gridView1.CustomColumnDisplayText
            If e.Column.ColumnType Is GetType(Date?) Then
                Dim value? As Date = CType(e.Value, Date?)
                If value Is Nothing OrElse (Not value.HasValue) Then
                    e.DisplayText = My.Resources.None
                End If
            End If
        End Sub

        Private Sub gridView1_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView1.CellValueChanging
            If e.Column Is colComplete Then
                Dim task As Task = TryCast(gridView1.GetRow(e.RowHandle), Task)
                If task IsNot Nothing Then
                    task.Complete = Not task.Complete
                    gridView1.CloseEditor()
                    gridView1.UpdateCurrentRow()
                End If
            End If
        End Sub

        Private Sub gridView1_CustomRowCellEditForEditing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gridView1.CustomRowCellEditForEditing
            If e.Column Is colPercent Then
                e.RepositoryItem = repositoryItemTrackBar1
            End If
        End Sub

        Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
            If e.RowHandle < 0 Then
                Return
            End If
            Dim currentTask_Field As Task = TryCast(gridView1.GetRow(e.RowHandle), Task)
            If currentTask_Field Is Nothing Then
                Return
            End If
            If currentTask_Field.Status = TaskStatus.Completed Then
                e.Appearance.Font = FontResources.StrikeoutFont
                e.Appearance.ForeColor = ColorHelper.DisabledTextColor
            End If
            If currentTask_Field.Status = TaskStatus.Deferred Then
                e.Appearance.ForeColor = ColorHelper.DisabledTextColor
            End If
            If currentTask_Field.Status = TaskStatus.WaitingOnSomeoneElse Then
                e.Appearance.ForeColor = ColorHelper.WarningColor
            End If
            If currentTask_Field.Priority = 2 AndAlso currentTask_Field.Status <> TaskStatus.Completed Then
                e.Appearance.Font = FontResources.BoldFont
            End If
            If currentTask_Field.Overdue Then
                e.Appearance.ForeColor = ColorHelper.CriticalColor
            End If
        End Sub
        Protected Friend Overrides Sub ButtonClick(ByVal tag As String)
            If tag.IndexOf("Task") = 0 Then
                gridView1.BeginUpdate()
                Try
                    LoadDefaultLayout()
                    Select Case tag
                        Case TagResources.TaskList
                            colCreated.Group()
                            colCreated.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
                        Case TagResources.TaskToDoList
                            gridView1.ActiveFilterString = "[Status] <> ##Enum#DevExpress.MailClient.Win.TaskStatus,Completed# And [DueDate] Is Not Null"
                            colDueDate.Group()
                            colCompleted.Visible = False
                        Case TagResources.TaskCompleted
                            gridView1.ActiveFilterString = "[Status] = ##Enum#DevExpress.MailClient.Win.TaskStatus,Completed#"
                            colCompleted.Group()
                            colCompleted.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
                        Case TagResources.TaskToday
                            gridView1.ActiveFilterString = "IsOutlookIntervalToday([DueDate])"
                            colPriority.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
                            colCompleted.Visible = False
                        Case TagResources.TaskPrioritized
                            colPriority.Group()
                            colCategory.Group()
                            colDueDate.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                            colCreated.Visible = False
                        Case TagResources.TaskOverdue
                            gridView1.ActiveFilterString = "[Overdue] = True"
                            colDueDate.Group()
                            colCreated.Visible = False
                            colCompleted.Visible = False
                        Case TagResources.TaskSimpleList
                            colDueDate.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                            colPriority.Visible = False
                            colCategory.Visible = False
                            colStatus.Visible = False
                            colPercent.Visible = False
                            colStartDate.Visible = False
                            colCompleted.Visible = False
                        Case TagResources.TaskDeferred
                            gridView1.ActiveFilterString = "[Status] = ##Enum#DevExpress.MailClient.Win.TaskStatus,Deferred# Or [Status] = ##Enum#DevExpress.MailClient.Win.TaskStatus,WaitingOnSomeoneElse#"
                            colCompleted.Group()
                            colCreated.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                            colCompleted.Visible = False
                    End Select
                Finally
                    gridView1.FocusedRowHandle = 0
                    gridView1.MakeRowVisible(gridView1.FocusedRowHandle)
                    gridView1.EndUpdate()
                End Try
            Else
                DoFlagStatusButtonClick(tag)
                DoEditTaskButtonClick(tag)
            End If
        End Sub
        Private ReadOnly Property CurrentKey() As NavBarData
            Get
                Return TryCast(currentKey_Field, NavBarData)
            End Get
        End Property
        Private Sub RemoveCurrentTask(ByVal list As List(Of Task))
            If gridView1.SelectedRowsCount = 0 AndAlso CurrentTask IsNot Nothing Then
                list.Remove(CurrentTask)
            Else
                Dim selectedTasks As New List(Of Task)()
                For Each index As Integer In gridView1.GetSelectedRows()
                    Dim task As Task = TryCast(gridView1.GetRow(index), Task)
                    If task IsNot Nothing Then
                        selectedTasks.Add(task)
                    End If
                Next index
                For Each task As Task In selectedTasks
                    list.Remove(task)
                Next task
            End If
        End Sub
        Private Sub DoEditTaskButtonClick(ByVal tag As String)
            Select Case tag
                Case TagResources.TaskDelete
                    Dim index As Integer = gridView1.FocusedRowHandle
                    gridView1.BeginDataUpdate()
                    Try
                        For Each list As List(Of Task) In tasks_Field.Values
                            RemoveCurrentTask(list)
                        Next list
                    Finally
                        gridView1.EndDataUpdate()
                    End Try
                    If index > gridView1.DataRowCount - 1 Then
                        index -= 1
                    End If
                    gridView1.FocusedRowHandle = index
                    ShowInfo(gridView1)
                Case TagResources.TaskNew
                    If CurrentKey IsNot Nothing Then
                        Dim task As New Task(My.Resources.NewTaskName, TaskCategory.Office)
                        task.AssignTo = CurrentKey.Contact
                        If EditTask(task) = DialogResult.OK Then
                            gridControl1.MainView.BeginDataUpdate()
                            Try
                                DirectCast(tasks_Field(CurrentKey), List(Of Task)).Add(task)
                            Finally
                                gridControl1.MainView.EndDataUpdate()
                            End Try
                            Dim view As ColumnView = TryCast(gridControl1.MainView, ColumnView)
                            If view IsNot Nothing Then
                                GridHelper.GridViewFocusObject(view, task)
                                ShowInfo(view)
                            End If
                        End If
                    End If
                Case TagResources.TaskEdit
                    EditTask(CurrentTask)
            End Select
        End Sub
        Friend Overrides Sub FocusObject(ByVal obj As Object)
            Dim view As ColumnView = TryCast(gridControl1.MainView, ColumnView)
            If view IsNot Nothing Then
                GridHelper.GridViewFocusObject(view, obj)
            End If
        End Sub
        Private Function EditTask(ByVal task As Task) As DialogResult
            If task Is Nothing Then
                Return DialogResult.Ignore
            End If
            Dim ret As DialogResult = DialogResult.Cancel
            Cursor.Current = Cursors.WaitCursor
            Using frm As New frmEditTask(task, OwnerForm.Ribbon)
                ret = frm.ShowDialog(OwnerForm)
            End Using
            UpdateCurrentTask()
            Cursor.Current = Cursors.Default
            ShowReminder()
            Return ret
        End Function
        Private Sub DoFlagStatusButtonClick(ByVal tag As String)
            If CurrentTask Is Nothing Then
                Return
            End If
            If Not System.Enum.IsDefined(GetType(FlagStatus), tag) Then
                Return
            End If
            Dim day As Integer = -1
            If tag.Equals(FlagStatus.Today.ToString()) Then
                CurrentTask.DueDate = Date.Today
            End If
            If tag.Equals(FlagStatus.Tomorrow.ToString()) Then
                CurrentTask.DueDate = Date.Today.AddDays(1)
            End If
            If tag.Equals(FlagStatus.ThisWeek.ToString()) Then
                If CurrentTask.FlagStatus <> FlagStatus.ThisWeek Then
                    day = 5
                End If
            End If
            If tag.Equals(FlagStatus.NextWeek.ToString()) Then
                If CurrentTask.FlagStatus <> FlagStatus.NextWeek Then
                    day = 12
                End If
            End If
            If day > 0 Then
                CurrentTask.DueDate = DevExpress.Data.Filtering.Helpers.EvalHelpers.GetWeekStart(Date.Today).AddDays(day)
            End If
            If tag.Equals(FlagStatus.NoDate.ToString()) Then
                CurrentTask.DueDate = Nothing
            End If
            If tag.Equals(FlagStatus.Custom.ToString()) Then
                Using frm As New frmCustomDate(CurrentTask)
                    frm.ShowDialog(OwnerForm)
                End Using
            End If
            CurrentTask.Complete = False
            gridView1.LayoutChanged()
            OwnerForm.EnabledFlagButtons(True, AllowEdit, CurrentTask)
        End Sub
        Private ReadOnly Property AllowEdit() As Boolean
            Get
                If CurrentTask Is Nothing Then
                    Return False
                End If
                If gridView1.SelectedRowsCount = 1 Then
                    Return gridView1.FocusedRowHandle = gridView1.GetSelectedRows()(0)
                End If
                Return gridView1.SelectedRowsCount = 0
            End Get
        End Property
        Private Sub LoadDefaultLayout()
            gridView1.ClearGrouping()
            gridView1.ClearSorting()
            gridView1.ActiveFilterString = String.Empty
            For i As Integer = 0 To gridView1.Columns.Count - 1
                If gridView1.Columns(i) IsNot colOverdue AndAlso gridView1.Columns(i).OptionsColumn.ShowInCustomizationForm Then
                    gridView1.Columns(i).VisibleIndex = i
                End If
            Next i
        End Sub
        Private ReadOnly Property CurrentTask() As Task
            Get
                If gridView1.FocusedRowHandle < 0 Then
                    Return Nothing
                End If
                Return TryCast(gridView1.GetRow(gridView1.FocusedRowHandle), Task)
            End Get
        End Property
        Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
            UpdateCurrentTask()
        End Sub
        Private Sub gridView1_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.ColumnFilterChanged
            UpdateCurrentTask()
        End Sub
        Private Sub gridView1_SelectionChanged(ByVal sender As Object, ByVal e As Data.SelectionChangedEventArgs) Handles gridView1.SelectionChanged
            UpdateCurrentTask()
        End Sub
        Private Sub UpdateCurrentTask()
            If CurrentTask IsNot Nothing Then
                OwnerForm.EnabledFlagButtons(True, AllowEdit, CurrentTask)
            Else
                OwnerForm.EnabledFlagButtons(False, AllowEdit, Nothing)
            End If
        End Sub

        Private Sub gridView1_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView1.RowCellClick
            If CurrentTask Is Nothing Then
                Return
            End If
            If e.Column Is colFlagStatus Then
                If e.Button = MouseButtons.Left Then
                    CurrentTask.Complete = Not CurrentTask.Complete
                End If
                If e.Button = MouseButtons.Right Then
                    OwnerForm.FlagStatusMenu.ShowPopup(gridControl1.PointToScreen(e.Location))
                End If
                gridView1.LayoutChanged()
            End If
            If e.Button = MouseButtons.Left AndAlso e.RowHandle >= 0 AndAlso e.Clicks = 2 Then
                EditTask(CurrentTask)
            End If
        End Sub

        Private Sub gridView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView1.KeyDown
            If e.KeyData = Keys.Enter AndAlso gridView1.FocusedRowHandle >=0 Then
                EditTask(CurrentTask)
            End If
        End Sub

        Private Sub gridView1_RowCellStyle(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gridView1.RowCellStyle
            If e.RowHandle = gridView1.FocusedRowHandle AndAlso gridView1.FocusedColumn IsNot e.Column Then
                e.Appearance.BackColor = gridView1.PaintAppearance.FocusedRow.BackColor
                e.Appearance.ForeColor = gridView1.PaintAppearance.FocusedRow.ForeColor
            End If
        End Sub
    End Class
End Namespace
