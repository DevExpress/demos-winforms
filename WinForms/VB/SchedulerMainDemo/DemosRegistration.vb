Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraScheduler.Demos

    Public Class DemosInfo
        Inherits ModulesInfo

        Private Shared Sub UpdateOptions(ByVal control As Control)
            If control Is Nothing Then Return
            For Each ctrl As Control In control.Controls
                UpdateOptions(ctrl)
            Next

            Dim scheduler As SchedulerControl = TryCast(control, SchedulerControl)
            If scheduler IsNot Nothing AndAlso MainFormHelper.TakeScreens Then scheduler.OptionsBehavior.UseAsyncMode = False
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
                End If

                Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
                tutorial.Bounds = groupControl.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                groupControl.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill
                Dim tc As TutorialControl = TryCast(item.TModule, TutorialControl)
                UpdateOptions(tc)
                If tc IsNot Nothing Then
                    Dim printingSchedulerControl As SchedulerControl = tc.PrintingSchedulerControl
                    manager.AllowExport(printingSchedulerControl)
                    manager.SchedulerControl = printingSchedulerControl
                Else
                    manager.AllowExport(Nothing)
                End If

                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                item.WasShown = True
                manager.SchedulerReport = TryCast(tc, IDemoSchedulerReport)
                If oldTutorial IsNot Nothing Then oldTutorial.Visible = False
            Finally
                Cursor.Current = currentCursor
            End Try

            Call RaiseModuleChanged()
        End Sub
    End Class
End Namespace
