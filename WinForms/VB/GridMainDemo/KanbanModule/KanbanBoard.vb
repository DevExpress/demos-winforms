Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Tile

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class KanbanBoard
        Inherits TutorialControl

        Private tasksData As BindingList(Of TaskRecord)

        Private employeesData As DataTable

        Private membersData As DataTable

        Private checklistData As DataTable

        Public Sub New()
            InitializeComponent()
            InitKanban()
            InitData()
            tileView.OptionsEditForm.CustomEditFormLayout = New KanbanEditControl(tileView, employeesData, membersData, checklistData)
            If MainFormHelper.TakeScreens Then tileView.AnimateArrival = False
        End Sub

        Private Sub InitKanban()
            tileView.OptionsKanban.ShowGroupBackground = DefaultBoolean.True
            tileView.OptionsKanban.Groups.Add(New KanbanGroup() With {.GroupValue = TaskStatus.ToDo})
            tileView.OptionsKanban.Groups.Add(New KanbanGroup() With {.GroupValue = TaskStatus.Planned})
            tileView.OptionsKanban.Groups.Add(New KanbanGroup() With {.GroupValue = TaskStatus.Doing})
            tileView.OptionsKanban.Groups.Add(New KanbanGroup() With {.GroupValue = TaskStatus.Testing})
            tileView.OptionsKanban.Groups.Add(New KanbanGroup() With {.GroupValue = TaskStatus.Done})
            tileView.OptionsKanban.Groups(4).FooterButton.Visible = DefaultBoolean.False
            tileView.OptionsKanban.GroupFooterButton.Visible = DefaultBoolean.True
            tileView.OptionsKanban.GroupFooterButton.Text = "Add a new card"
            AddHandler tileView.GroupFooterButtonClick, AddressOf TileView_GroupFooterButtonClick
            AddHandler tileView.GroupHeaderContextButtonClick, AddressOf TileView_GroupHeaderContextButtonClick
            AddHandler tileView.CustomColumnDisplayText, AddressOf TileView_CustomColumnDisplayText
        End Sub

        Private Sub TileView_CustomColumnDisplayText(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDisplayTextEventArgs)
            If e.IsForGroupRow Then
                Dim kanbanGroup = tileView.GetKanbanGroupByValue(e.Value)
                Dim count As Integer = tileView.GetChildRowCount(kanbanGroup)
                Dim cards As String = If(count = 1, " card", " cards")
                e.DisplayText += "<br><size=-2><r>" & count.ToString() & cards
            End If
        End Sub

        Private Sub InitData()
            tasksData = KanbanHelper.LoadTasks()
            employeesData = KanbanHelper.LoadEmployees()
            membersData = KanbanHelper.LoadMembers()
            checklistData = KanbanHelper.LoadChecklist()
            KanbanHelper.UpdateMembersGlyph(employeesData, LookAndFeel, ScaleHelper.ScaleVertical(30))
            gridControl.DataSource = tasksData
        End Sub

        Private Sub tileView_ItemCustomize(ByVal sender As Object, ByVal e As TileViewItemCustomizeEventArgs)
            Dim task = TryCast(tileView.GetRow(e.RowHandle), TaskRecord)
            If task Is Nothing Then Return
            e.Item("Label").Appearance.Normal.BackColor = GetLabelColor(task.Label)
            Dim elAttach = e.Item.GetElementByName("Attachment")
            elAttach.ImageVisible = task.AttachedImage IsNot Nothing
            Dim elDescription = e.Item.GetElementByName("Description")
            elDescription.ImageVisible = Not String.IsNullOrEmpty(task.Description)
            Dim elProgress = e.Item.GetElementByName("Progress")
            Dim id As Guid = task.Id
            Dim count As Integer = checklistData.AsEnumerable().Count(Function(row) row.Field(Of Guid)("TaskID") = id)
            Dim doneCount As Integer = checklistData.AsEnumerable().Count(Function(row) row.Field(Of Guid)("TaskID") = id AndAlso row.Field(Of Boolean)("Checked"))
            If count = 0 Then
                elProgress.Text = ""
                elProgress.ImageVisible = False
            Else
                elProgress.AnchorIndent = If(elDescription.ImageVisible, elProgress.AnchorIndent, 0)
                elProgress.Text = String.Format("{0}/{1}", doneCount, count)
            End If

            Dim elements = GetMembersElements(id)
            If elements.Count = 0 Then Return
            Dim prev As TileViewItemElement = Nothing
            For Each element In elements
                e.Item.Elements.Add(element)
                If prev IsNot Nothing Then
                    element.AnchorElement = prev
                    element.AnchorAlignment = AnchorAlignment.Left
                    element.AnchorIndent = 4
                Else
                    element.RowIndex = 4
                    element.ImageAlignment = TileItemContentAlignment.BottomRight
                End If

                prev = element
            Next
        End Sub

        Private Function GetMembersElements(ByVal id As Guid) As List(Of TileViewItemElement)
            Dim memberRows As List(Of DataRow) = membersData.AsEnumerable().Where(Function(row) row.Field(Of Guid)("TaskID") = id).ToList()
            Dim result = New List(Of TileViewItemElement)()
            For Each memberRow In memberRows
                Dim photoBytes = employeesData.Rows.Find(memberRow("MemberID"))("Photo")
                Dim element = New TileViewItemElement()
                element.Image = ByteImageConverter.FromByteArray(TryCast(photoBytes, Byte()))
                result.Add(element)
            Next

            Return result
        End Function

        Private Function GetLabelColor(ByVal label As TaskLabel) As Color
            Select Case label
                Case TaskLabel.Red
                    Return ColorTranslator.FromHtml("#f06562")
                Case TaskLabel.Green
                    Return ColorTranslator.FromHtml("#1fb876")
                Case TaskLabel.Yellow
                    Return ColorTranslator.FromHtml("#fca90a")
                Case Else
                    Return ColorTranslator.FromHtml("#969696")
            End Select
        End Function

        Private Sub AddNewCard(ByVal status As TaskStatus)
            Dim newCaption As String = XtraInputBox.Show("", "Add a new card", "New Task")
            If String.IsNullOrEmpty(newCaption) Then Return
            Dim newRow = KanbanHelper.CreateNewTask()
            newRow.Id = Guid.NewGuid()
            newRow.Status = status
            newRow.Caption = newCaption
            tasksData.Add(newRow)
            tileView.FocusedRowHandle = tileView.GetRowHandle(tasksData.IndexOf(newRow))
            tileView.RefreshData()
            tileView.MakeRowVisible(tileView.FocusedRowHandle)
        End Sub

        Private Sub TileView_GroupFooterButtonClick(ByVal sender As Object, ByVal e As GroupFooterButtonClickEventArgs)
            Dim status = CType(e.GroupValue, TaskStatus)
            AddNewCard(status)
        End Sub

        Private Sub TileView_GroupHeaderContextButtonClick(ByVal sender As Object, ByVal e As GroupHeaderContextButtonClickEventArgs)
            Dim status = CType(e.GroupValue, TaskStatus)
            AddNewCard(status)
        End Sub

        Protected Overrides Sub DoDpiChange(ByVal deviceDpiOld As Integer, ByVal deviceDpiNew As Integer)
            MyBase.DoDpiChange(deviceDpiOld, deviceDpiNew)
            KanbanHelper.UpdateMembersGlyph(employeesData, LookAndFeel, ScaleDPI.ScaleVertical(30))
            tileView.RefreshData()
        End Sub
    End Class
End Namespace
