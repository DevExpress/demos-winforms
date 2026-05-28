Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.Taskbar
Imports DevExpress.Utils.Taskbar.Core
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleTaskbarAssistant
        Inherits TutorialControl

        Private _taskbarAssistantInstance As TaskbarAssistant

        Public Sub New()
            InitializeComponent()
            TutorialInfo.TutorialName = "TaskbarAssistant Tutorial"
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            CreateTaskbarAssistant()
            InitControls()
            UpdateControls()
            CreateThumbnailButtons()
        End Sub

        Private Sub CreateThumbnailButtons()
            For i As Integer = 0 To TaskbarAssistant.MaxThumbnailButtonsCount - 1
                Dim thumbButton As ThumbnailButton = CreateThumbnailButton()
                TaskbarAssistantInstance.ThumbnailButtons.Add(thumbButton)
            Next
        End Sub

        Private Sub CreateTaskbarAssistant()
            _taskbarAssistantInstance = New TaskbarAssistant()
            TaskbarAssistantInstance.ParentControl = ParentForm
        End Sub

        Private Sub InitControls()
            Dim progressModes = [Enum].GetValues(GetType(TaskbarButtonProgressMode))
            For Each progressMode As TaskbarButtonProgressMode In progressModes
                cbProgressMode.Properties.Items.Add(progressMode)
            Next

            If cbProgressMode.Properties.Items.Count > 0 Then
                cbProgressMode.SelectedIndex = 0
            End If

            imgOverlayIcons.Properties.Items.Add(New ImageComboBoxNoneItem())
            For i As Integer = 0 To imgCollection.Images.Count - 1
                Dim description As String = imgCollection.Images.Keys(i)
                imgOverlayIcons.Properties.Items.Add(New ImageComboBoxItem(description, i))
            Next

            If imgOverlayIcons.Properties.Items.Count > 0 Then
                imgOverlayIcons.SelectedIndex = 0
            End If
        End Sub

        ' <btnAddThumbnailButton>
        Private Sub OnAddThumbnailButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            For Each button As ThumbnailButton In TaskbarAssistantInstance.ThumbnailButtons
                If Not button.Visible Then
                    button.Visible = True
                    Exit For
                End If
            Next

            TaskbarAssistantInstance.Refresh()
            UpdateControls()
        End Sub

        ' </btnAddThumbnailButton>
        ' <btnRemoveThumbnailButton>
        Private Sub OnRemoveThumbnailButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            For i As Integer = TaskbarAssistantInstance.ThumbnailButtons.Count - 1 To 0 Step -1
                Dim thumbButton As ThumbnailButton = TaskbarAssistantInstance.ThumbnailButtons(i)
                If thumbButton.Visible Then
                    thumbButton.Visible = False
                    Exit For
                End If
            Next

            TaskbarAssistantInstance.Refresh()
            UpdateControls()
        End Sub

        ' </btnRemoveThumbnailButton>
        ' <cbProgressMode>
        Private Sub OnProgressModeComboBoxEditSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim cb As ComboBoxEdit = CType(sender, ComboBoxEdit)
            _taskbarAssistantInstance.ProgressMode = CType(cb.EditValue, TaskbarButtonProgressMode)
        End Sub

        ' </cbProgressMode>
        ' <trackBarProgressValue>
        Private Sub OnCurrentProgressValueTrackBarEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim trackBar As TrackBarControl = CType(sender, TrackBarControl)
            _taskbarAssistantInstance.ProgressCurrentValue = trackBar.Value
        End Sub

        ' </trackBarProgressValue>
        ' <imgOverlayIcons>
        Private Sub OnOverlayIconsComboBoxSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As ImageComboBoxItem = CType(CType(sender, ImageComboBoxEdit).SelectedItem, ImageComboBoxItem)
            Dim img As Image = If(TypeOf item Is ImageComboBoxNoneItem, Nothing, imgCollection.Images(item.ImageIndex))
            _taskbarAssistantInstance.OverlayIcon = CType(img, Bitmap)
        End Sub

        ' </imgOverlayIcons>
        ' <btnAddItemToTasks>
        Private Sub OnAddItemToTasksButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim itemCaption As String = String.Format("Task #{0}", (_taskbarAssistantInstance.JumpListTasksCategory.Count + 1).ToString())
            Dim taskItem As JumpListItemTask = New JumpListItemTask(itemCaption)
            _taskbarAssistantInstance.JumpListTasksCategory.Add(taskItem)
            _taskbarAssistantInstance.Refresh()
            UpdateControls()
        End Sub

        ' </btnAddItemToTasks>
        ' <btnRemoveItemFromTasks>
        Private Sub OnRemoveItemFromTasksButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim itemsCount As Integer = _taskbarAssistantInstance.JumpListTasksCategory.Count
            If itemsCount = 0 Then Return
            _taskbarAssistantInstance.JumpListTasksCategory.RemoveAt(itemsCount - 1)
            _taskbarAssistantInstance.Refresh()
            UpdateControls()
        End Sub

        ' </btnRemoveItemFromTasks>
        ' <btnAddCustomCategory>
        Private Sub OnAddCustomCategoryButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim categoryName As String = String.Format("Custom Category #{0}", (TaskbarAssistantInstance.JumpListCustomCategories.Count + 1).ToString())
            Dim customCategory As JumpListCategory = New JumpListCategory(categoryName)
            For i As Integer = 0 To 2 - 1
                Dim itemCaption As String = String.Format("Task #{0}", (i + 1).ToString())
                Dim item As JumpListItemTask = New JumpListItemTask(itemCaption)
                customCategory.JumpItems.Add(item)
            Next

            TaskbarAssistantInstance.JumpListCustomCategories.Add(customCategory)
            TaskbarAssistantInstance.Refresh()
            UpdateControls()
        End Sub

        ' </btnAddCustomCategory>
        ' <btnRemoveCustomCategory>
        Private Sub OnRemoveCustomCategoryButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim categoriesCount As Integer = TaskbarAssistantInstance.JumpListCustomCategories.Count
            If categoriesCount = 0 Then Return
            TaskbarAssistantInstance.JumpListCustomCategories.RemoveAt(categoriesCount - 1)
            TaskbarAssistantInstance.Refresh()
            UpdateControls()
        End Sub

        ' </btnRemoveCustomCategory>
        Private Function CreateThumbnailButton() As ThumbnailButton
            Dim res As ThumbnailButton = New ThumbnailButton()
            Dim rnd = TutorialConstants.Random
            If imgCollection.Images.Count > 0 Then
                res.Image = CType(imgCollection.Images(rnd.Next(0, imgCollection.Images.Count)), Bitmap)
            End If

            AddHandler res.Click, Sub(s, ee)
                Dim thumbButtonPos As Integer = TaskbarAssistantInstance.ThumbnailButtons.IndexOf(ee.ThumbButton) + 1
                Call XtraMessageBox.Show(ParentForm, String.Format("ThumbnailButton # {0} clicked", thumbButtonPos.ToString()), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Sub
            res.Visible = False
            Return res
        End Function

        Private Sub UpdateControls()
            btnAddThumbnailButton.Enabled = CalcVisibleThumbnailButtonsCount() < TaskbarAssistant.MaxThumbnailButtonsCount
            btnRemoveThumbnailButton.Enabled = CalcVisibleThumbnailButtonsCount() > 0
            btnRemoveCustomCategory.Enabled = TaskbarAssistantInstance.JumpListCustomCategories.Count > 0
            btnRemoveItemFromTasks.Enabled = TaskbarAssistantInstance.JumpListTasksCategory.Count > 0
        End Sub

        Private Function CalcVisibleThumbnailButtonsCount() As Integer
            Dim count As Integer = 0
            For Each thumbButton In TaskbarAssistantInstance.ThumbnailButtons
                If thumbButton.Visible Then count += 1
            Next

            Return count
        End Function

        Private ReadOnly Property TaskbarAssistantInstance As TaskbarAssistant
            Get
                Return _taskbarAssistantInstance
            End Get
        End Property
    End Class

    Friend Class ImageComboBoxNoneItem
        Inherits ImageComboBoxItem

        Public Sub New()
            ImageIndex = -1
            Description = "(none)"
        End Sub
    End Class
End Namespace
