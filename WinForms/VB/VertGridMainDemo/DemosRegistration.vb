Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.XtraVerticalGrid.Demos

    Public Class DemosInfo
        Inherits ModulesInfo

        Public Shared Overloads Sub ShowModule(ByVal name As String, ByVal group As XtraEditors.GroupControl, ByVal manager As VGridRibbonMenuManager)
            Dim item As ModuleInfo = GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Equals(Instance.CurrentModuleBase.Name, name) Then Return
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If

                Dim ctc As CodeTutorialControlBase = TryCast(item.TModule, CodeTutorialControlBase)
                If ctc IsNot Nothing Then ctc.SelectExampleByName(item.CodeExampleName)
                Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
                tutorial.Bounds = group.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                group.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill
                Dim tc As TutorialControl = TryCast(item.TModule, TutorialControl)
                If tc IsNot Nothing Then
                    manager.AllowExport(tc.ExportControl)
                    manager.RefreshOptionsMenu(tc.ViewOptionsControl)
                Else
                    manager.AllowExport(Nothing)
                    manager.RefreshOptionsMenu(Nothing)
                End If

                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                item.WasShown = True
                If oldTutorial IsNot Nothing Then oldTutorial.Visible = False
            Finally
                Cursor.Current = currentCursor
            End Try

            Call RaiseModuleChanged()
        End Sub
    End Class
End Namespace
