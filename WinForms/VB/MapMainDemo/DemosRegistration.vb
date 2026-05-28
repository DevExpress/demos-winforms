Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraMap.Native

Namespace DevExpress.XtraMap.Demos

    Public Class DemosInfo
        Inherits ModulesInfo

        Private Shared Sub UpdateModuleInfo(ByVal item As ModuleInfo)
            item.RecreateModuleIfNecessary(Assembly.GetCallingAssembly())
        End Sub

        Public Shared Sub DoShowModule(ByVal name As String, ByVal groupControl As XtraEditors.GroupControl, ByVal manager As RibbonMenuManager)
            Dim currentCursor As Cursor = Cursor.Current
            Try
                Dim item As ModuleInfo = GetItem(name)
                Dim tutorial As TutorialControlBase = CType(item.TModule, TutorialControlBase)
                Cursor.Current = Cursors.WaitCursor
                Dim oldTutorial As TutorialControlBase = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Equals(Instance.CurrentModuleBase.Name, name) Then Return
                    oldTutorial = If(GetPreviousModule(), CType(Instance.CurrentModuleBase.TModule, TutorialControlBase))
                End If

                tutorial.Bounds = groupControl.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                groupControl.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill
                Dim tc As MapTutorialControl = TryCast(tutorial, MapTutorialControl)
                If tc IsNot Nothing Then
                    RegisterModule(tc)
                    UpdateModuleInfo(item)
                    tc.AppendOverlays()
                End If

                manager.AllowExport(If(tc IsNot Nothing, tc.MapControl, Nothing))
                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                item.WasShown = True
                Instance.CurrentModuleBase = item
                If oldTutorial IsNot Nothing Then
                    oldTutorial.Visible = False
                    Dim mapTutorialControl As MapTutorialControl = TryCast(oldTutorial, MapTutorialControl)
                    If mapTutorialControl IsNot Nothing Then MapUtils.ReleaseMapHandle(mapTutorialControl.MapControl)
                End If
            Finally
                Cursor.Current = currentCursor
            End Try

            Call RaiseModuleChanged()
        End Sub
    End Class
End Namespace
