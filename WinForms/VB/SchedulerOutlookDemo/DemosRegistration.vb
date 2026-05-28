Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraScheduler.Demos

    Public Class DemosInfo
        Inherits ModulesInfo

        Public Shared ReadOnly Property CurrentScheduler As SchedulerControl
            Get
                Return CType(Instance.CurrentModuleBase.TModule, TutorialControl).Scheduler
            End Get
        End Property

        Public Shared Sub DoShowModule(ByVal name As String, ByVal contentPlaceholder As XtraEditors.GroupControl, ByVal dateNavigator As DateNavigator, ByVal manager As RibbonMenuManager)
            Dim item As ModuleInfo = GetItem(name)
            Dim oldTutorial As Control = Nothing
            If Instance.CurrentModuleBase IsNot Nothing Then
                If Equals(Instance.CurrentModuleBase.Name, name) Then Return
                oldTutorial = Instance.CurrentModuleBase.TModule
                Call Detach(CType(oldTutorial, TutorialControl).Scheduler)
            End If

            Dim tutorial As TutorialControl = TryCast(item.TModule, TutorialControl)
            tutorial.Bounds = contentPlaceholder.DisplayRectangle
            Instance.CurrentModuleBase = item
            tutorial.Visible = False
            contentPlaceholder.Controls.Add(tutorial)
            tutorial.Dock = DockStyle.Fill
            Dim scheduler As SchedulerControl = tutorial.Scheduler
            If scheduler IsNot Nothing Then
                CommonOptions.Instance.Apply(tutorial)
                dateNavigator.SchedulerControl = scheduler
                dateNavigator.Refresh()
                ZoomBehaviour.Attach(scheduler)
            End If

            tutorial.RibbonMenuManager = manager
            tutorial.TutorialName = name
            tutorial.Visible = True
            item.WasShown = True
            If oldTutorial IsNot Nothing Then oldTutorial.Visible = False
        End Sub

        Public Shared Sub DoShowModule(ByVal name As String, ByVal groupControl As XtraEditors.GroupControl, ByVal manager As SchedulerRibbonMenuManager)
            Dim item As ModuleInfo = GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Equals(Instance.CurrentModuleBase.Name, name) Then Return
                    oldTutorial = Instance.CurrentModuleBase.TModule
                    Call Detach(CType(oldTutorial, TutorialControl).Scheduler)
                End If

                Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
                tutorial.Bounds = groupControl.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                groupControl.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill
                Dim tc As TutorialControl = TryCast(item.TModule, TutorialControl)
                If tc IsNot Nothing Then
                    Dim scheduler As SchedulerControl = tc.Scheduler
                    manager.AllowExport(scheduler)
                    manager.SchedulerControl = scheduler
                    ZoomBehaviour.Attach(scheduler)
                Else
                    manager.AllowExport(Nothing)
                End If

                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                item.WasShown = True
                manager.SchedulerReport = TryCast(tc, IDemoSchedulerReport)
                If oldTutorial IsNot Nothing Then
                    oldTutorial.Visible = False
                End If
            Finally
                Cursor.Current = currentCursor
            End Try

            Call RaiseModuleChanged()
        End Sub
    End Class
End Namespace
