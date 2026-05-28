Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.MailClient.Win.Forms
    Partial Public Class frmEditTask
        Inherits RibbonForm

        Private task, bindingTask As Task
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal task As Task, ByVal menuManager As IDXMenuManager)
            InitializeComponent()
            Me.task = task
            Me.bindingTask = task.Clone()
            InitEditors()
            InitMenuManager(menuManager)
            If bindingTask.StartDate.HasValue Then
                deStartDate.DateTime = bindingTask.StartDate.Value
            End If
            If bindingTask.DueDate.HasValue Then
                deDueDate.DateTime = bindingTask.DueDate.Value
            End If
            teSubject.DataBindings.Add("Text", bindingTask, "Subject")
            icbStatus.DataBindings.Add("EditValue", bindingTask, "Status")
            icbCategory.DataBindings.Add("EditValue", bindingTask, "Category")
            icbPriority.DataBindings.Add("EditValue", bindingTask, "Priority")
            sePercentComplete.DataBindings.Add("Value", bindingTask, "PercentComplete")
            richEditControl1.DataBindings.Add("HtmlText", bindingTask, "Description")
            UpdateCaption()
            InitValidationProvider()
            If task.AssignTo IsNot Nothing Then
                ucContactInfo1.Init(task.AssignTo, String.Empty)
                splitContainerControl1.Collapsed = LayoutOption.TaskCollapsed
            Else
                splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1
            End If
        End Sub

        Private Sub InitValidationProvider()
            dxValidationProvider1.SetValidationRule(teSubject, ValidationRulesHelper.RuleIsNotBlank)
        End Sub
        Private Sub UpdateCaption()
            Text = bindingTask.Subject
        End Sub
        Private Sub InitMenuManager(ByVal menuManager As IDXMenuManager)
            For Each ctrl As Control In lcMain.Controls
                Dim edit As BaseEdit = TryCast(ctrl, BaseEdit)
                If edit IsNot Nothing Then
                    edit.MenuManager = menuManager
                End If
            Next ctrl
        End Sub
        Private Sub InitEditors()
            EditorHelper.CreateTaskCategoryImageComboBox(icbCategory.Properties)
            EditorHelper.CreateTaskStatusImageComboBox(icbStatus.Properties)
            EditorHelper.InitPriorityComboBox(icbPriority.Properties)
        End Sub
        Private Sub sbOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbOK.Click
            If deDueDate.DateTime <> Date.MinValue Then
                bindingTask.DueDate = deDueDate.DateTime
            End If
            If deStartDate.DateTime <> Date.MinValue Then
                bindingTask.StartDate = deStartDate.DateTime
            End If
            task.Assign(bindingTask)
        End Sub

        Private Sub richEditControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl1.SelectionChanged
            tableToolsRibbonPageCategory1.Visible = richEditControl1.IsSelectionInTable()
            floatingPictureToolsRibbonPageCategory1.Visible = richEditControl1.IsFloatingObjectSelected
        End Sub

        Private Sub sePercentComplete_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles sePercentComplete.EditValueChanged
            sePercentComplete.DoValidate()
        End Sub

        Private Sub icbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbStatus.SelectedIndexChanged
            icbStatus.DoValidate()
        End Sub
        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            MyBase.OnClosing(e)
            If task.AssignTo IsNot Nothing Then
                LayoutOption.TaskCollapsed = splitContainerControl1.Collapsed
            End If
        End Sub
    End Class
End Namespace
