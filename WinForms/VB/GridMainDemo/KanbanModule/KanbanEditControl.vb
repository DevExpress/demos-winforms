Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class KanbanEditControl
        Inherits DevExpress.XtraGrid.Views.Grid.EditFormUserControl

        Private OwnerView As DevExpress.XtraGrid.Views.Tile.TileView

        Private ReadOnly Property OwnerGrid As GridControl
            Get
                Return Me.OwnerView.GridControl
            End Get
        End Property

        Private Property Employees As DataTable

        Private Property Members As DataTable

        Private Property Checklist As DataTable

        '
        Public Sub New(ByVal ownerView As DevExpress.XtraGrid.Views.Tile.TileView, ByVal employees As System.Data.DataTable, ByVal members As System.Data.DataTable, ByVal checkList As System.Data.DataTable)
            Me.InitializeComponent()
            Me.OwnerView = ownerView
            Me.comboBoxEdit1.Properties.Items.AddRange(GetType(DevExpress.XtraGrid.Demos.TaskLabel).GetEnumValues())
            Me.Employees = employees
            Me.Members = members
            Me.Checklist = checkList
            Me.gridControl1.DataSource = Me.Checklist
            Me.memberTiles.AnimateArrival = False
            AddHandler Me.memberTiles.ItemClick, AddressOf Me.tileControl1_ItemClick
            AddHandler Me.VisibleChanged, Sub(s, e)
                If Me.Visible Then Me.ControlShown()
            End Sub
            AddHandler Me.gridChecklist.CellValueChanged, AddressOf Me.gridView1_CellValueChanged
            AddHandler Me.gridChecklist.RowCountChanged, Sub(s, e) Me.UpdateProgressBar()
        End Sub

        Private ReadOnly Property FocusedTaskId As Guid
            Get
                Return TryCast(Me.OwnerView.GetRow(CInt((Me.OwnerView.FocusedRowHandle))), DevExpress.XtraGrid.Demos.TaskRecord).Id
            End Get
        End Property

        Private Sub ControlShown()
            Me.layoutControl1.MenuManager = Me.OwnerGrid.MenuManager
            Me.PopulateMembers()
            Me.UpdateProgressBar()
        End Sub

        Private Sub PopulateMembers()
            Me.tileGroup.Items.Clear()
            Me.addMemberItem.Visible = True
            Me.tileGroup.Items.Add(Me.addMemberItem)
            Dim memberIDs As System.Collections.Generic.List(Of Integer) = Me.GetMemberIDs()
            For Each memberId As Integer In memberIDs
                Dim bytes = Me.Employees.Rows.Find(memberId)("Photo")
                Dim item = New DevExpress.XtraEditors.TileItem()
                item.Image = DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(TryCast(bytes, Byte()))
                item.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
                Dim superTip = New DevExpress.Utils.SuperToolTip()
                superTip.Items.AddTitle(Me.GetEmployeeFullName(memberId))
                item.SuperTip = superTip
                item.Tag = memberId
                Me.tileGroup.Items.Insert(0, item)
                Me.addMemberItem.Visible = If((Me.tileGroup.Items.Count = 5), False, True)
            Next
        End Sub

        Private Sub OnAddMemberMenuClick(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim newId As Integer = CInt(TryCast(sender, DevExpress.Utils.Menu.DXMenuItem).Tag)
            Dim newRow As System.Data.DataRow = Me.Members.NewRow()
            newRow("TaskID") = Me.FocusedTaskId
            newRow("MemberID") = newId
            Me.Members.Rows.Add(newRow)
            Me.PopulateMembers()
        End Sub

        Private Sub addMemberItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs)
            Dim memberIDs As System.Collections.Generic.List(Of Integer) = Me.GetMemberIDs()
            Dim menu As DevExpress.Utils.Menu.DXPopupMenu = New DevExpress.Utils.Menu.DXPopupMenu()
            menu.MenuViewType = DevExpress.Utils.Menu.MenuViewType.Menu
            For i As Integer = 0 To Me.Employees.Rows.Count - 1
                Dim row As System.Data.DataRow = Me.Employees.Rows(i)
                Dim id As Integer = row.Field(Of Integer)("EmployeeID")
                If memberIDs.Contains(id) Then Continue For
                Dim fullName As String = Me.GetEmployeeFullName(id)
                Dim memberMenuItem As DevExpress.Utils.Menu.DXMenuItem = New DevExpress.Utils.Menu.DXMenuItem(fullName, New System.EventHandler(AddressOf Me.OnAddMemberMenuClick)) With {.Tag = id}
                menu.Items.Add(memberMenuItem)
            Next

            Me.ShowPopup(menu)
        End Sub

        Private Sub tileControl1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs)
            If e.Item Is Me.addMemberItem Then Return
            Dim menu As DevExpress.Utils.Menu.DXPopupMenu = New DevExpress.Utils.Menu.DXPopupMenu()
            menu.MenuViewType = DevExpress.Utils.Menu.MenuViewType.Menu
            Dim removeItem As DevExpress.Utils.Menu.DXMenuItem = New DevExpress.Utils.Menu.DXMenuItem("Remove from card", New System.EventHandler(AddressOf Me.OnRemoveItemClick)) With {.Tag = e.Item.Tag}
            menu.Items.Add(removeItem)
            Me.ShowPopup(menu)
        End Sub

        Private Sub OnRemoveItemClick(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim memberId As Integer = CInt(TryCast(sender, DevExpress.Utils.Menu.DXMenuItem).Tag)
            Dim taskId As System.Guid = Me.FocusedTaskId
            Dim rowsToRemove As System.Collections.Generic.List(Of System.Data.DataRow) = Me.Members.AsEnumerable().Where(Function(row) row.Field(Of System.Guid)("TaskID") = taskId AndAlso row.Field(Of Integer)("MemberID") = memberId).ToList()
            For Each row As System.Data.DataRow In rowsToRemove
                Me.Members.Rows.Remove(row)
            Next

            Me.PopulateMembers()
        End Sub

        Private Sub ShowPopup(ByVal menu As DevExpress.Utils.Menu.DXPopupMenu)
            Dim parentControl As System.Windows.Forms.Control = Me.memberTiles
            Dim pt As System.Drawing.Point = parentControl.PointToClient(System.Windows.Forms.Control.MousePosition)
            CType(menu, DevExpress.Utils.Menu.IDXDropDownControl).Show(Me.OwnerGrid.MenuManager, parentControl, pt)
        End Sub

        Private Function GetEmployeeFullName(ByVal employeeId As Integer) As String
            Dim row = Me.Employees.Rows.Find(employeeId)
            Return String.Format("{0} {1}", row("FirstName"), row("LastName"))
        End Function

        Private Function GetMemberIDs() As List(Of Integer)
            Dim taskId As System.Guid = Me.FocusedTaskId
            Return Me.Members.AsEnumerable().Where(Function(row) row.Field(Of System.Guid)("TaskID") = Me.FocusedTaskId).[Select](Function(row) row.Field(Of Integer)("MemberID")).ToList()
        End Function

        Private Sub gridView1_CustomRowFilter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowFilterEventArgs)
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            Dim dataView As System.Data.DataView = TryCast(view.DataSource, System.Data.DataView)
            Dim taskID As System.Guid = CType(dataView(e.ListSourceRow)("TaskID"), System.Guid)
            e.Visible =(taskID = Me.FocusedTaskId)
            e.Handled = True
        End Sub

        Private Sub gridView1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
            Me.gridChecklist.SetRowCellValue(e.RowHandle, Me.gridChecklist.Columns("TaskID"), Me.FocusedTaskId)
            Me.gridChecklist.SetRowCellValue(e.RowHandle, Me.gridChecklist.Columns("Caption"), "New item")
            Me.gridChecklist.SetRowCellValue(e.RowHandle, Me.gridChecklist.Columns("Checked"), False)
        End Sub

        Private Sub gridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
            Me.gridChecklist.UpdateCurrentRow()
            Me.UpdateProgressBar()
        End Sub

        Private Sub repositoryItemCheckEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.gridChecklist.PostEditor()
        End Sub

        Private Sub UpdateProgressBar()
            Dim taskId As System.Guid = Me.FocusedTaskId
            Dim filtered As System.Collections.Generic.List(Of System.Data.DataRow) = Me.Checklist.AsEnumerable().Where(Function(row) row.Field(Of System.Guid)("TaskID") = taskId).ToList()
            Dim totalCount As Integer = filtered.Count
            Dim checkedCount As Integer = System.Linq.Enumerable.ToList(Of System.Data.DataRow)(System.Linq.Enumerable.Where(Of System.Data.DataRow)(filtered, CType((Function(row) CBool((System.Data.DataRowExtensions.Field(Of Boolean)(row, CStr(("Checked"))) = True))), System.Func(Of System.Data.DataRow, System.[Boolean])))).Count
            Me.progressBarControl1.Properties.Maximum =(If(totalCount = 0, 1, totalCount))
            Me.progressBarControl1.Position = checkedCount
        End Sub
    End Class
End Namespace
